using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace AppTesis
{
    // 1. MODELO PARA LA API PRINCIPAL (DolarApi)
    public class DolarApiOficial
    {
        [JsonPropertyName("promedio")]
        public decimal Promedio { get; set; }
    }

    // 2. MODELO PARA LA API DE RESPALDO (DolarVzla)
    public class DolarVzlaRespaldo
    {
        [JsonPropertyName("price")]
        public decimal Price { get; set; }
    }

    // 3. CLASE DE SERVICIO HÍBRIDA CON TOLERANCIA A FALLOS
    public class ExtractorTasaCambio
    {
        private readonly HttpClient _httpClient;

        // Endpoints estables oficiales
        private const string UrlPrincipal = "https://ve.dolarapi.com/v1/dolares/oficial";
        private const string UrlRespaldo = "https://dolarvzla.com";

        public ExtractorTasaCambio(HttpClient httpClient)
        {
            _httpClient = httpClient;

            // Simular un navegador moderno de escritorio para evitar firewalls basicos
            if (!_httpClient.DefaultRequestHeaders.Contains("User-Agent"))
            {
                _httpClient.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36");
            }
        }

        public async Task<decimal> ObtenerTasaBcvAsync()
        {
            // --- INTENTO 1: Usando el endpoint correcto de DolarApi ---
            try
            {
                HttpResponseMessage respuesta = await _httpClient.GetAsync(UrlPrincipal);

                if (respuesta.IsSuccessStatusCode)
                {
                    string jsonString = await respuesta.Content.ReadAsStringAsync();
                    var datos = JsonSerializer.Deserialize<DolarApiOficial>(jsonString);

                    if (datos != null && datos.Promedio > 0)
                    {
                        return datos.Promedio; // Éxito en canal principal
                    }
                }
            }
            catch { /* Ignoramos el error en silencio para proceder al respaldo */ }

            // --- INTENTO 2: Plan de contingencia (DolarVzla) si el primero falló ---
            try
            {
                HttpResponseMessage respuestaRespaldo = await _httpClient.GetAsync(UrlRespaldo);
                respuestaRespaldo.EnsureSuccessStatusCode();

                string jsonStringRespaldo = await respuestaRespaldo.Content.ReadAsStringAsync();
                var datosRespaldo = JsonSerializer.Deserialize<DolarVzlaRespaldo>(jsonStringRespaldo);

                if (datosRespaldo != null && datosRespaldo.Price > 0)
                {
                    return datosRespaldo.Price; // Éxito en canal de contingencia
                }
            }
            catch (Exception ex)
            {
                // Ambos canales fallaron (por ejemplo, corte general de internet)
                throw new Exception($"Todos los servidores de tasa están caídos o no hay internet. Detalles: {ex.Message}");
            }

            throw new Exception("No se pudo procesar la tasa de cambio en ningún servidor.");
        }
    }
}
