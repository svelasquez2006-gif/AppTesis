using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTesis
{
    public partial class mantenimiento : Form
    {
        public mantenimiento()
        {
            InitializeComponent();
        }

        private void mantenimiento_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataBaseDataSet.Mantenimiento' Puede moverla o quitarla según sea necesario.
            this.mantenimientoTableAdapter.Fill(this.dataBaseDataSet.Mantenimiento);

            this.reportViewer1.RefreshReport();

            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
        }

        private void salir_Click(object sender, EventArgs e)
        {
            this.Close();
            Reportes rep = new Reportes();
            rep.Show();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            try
            {
                // Si tu método en el XSD espera cadenas (string) en lugar de DateTime:
                string fechaInicio = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                string fechaFin = dateTimePicker2.Value.ToString("yyyy-MM-dd");

                // Llamada adaptada
                this.mantenimientoTableAdapter.FillByRangoFechas(this.dataBaseDataSet.Mantenimiento, fechaInicio, fechaFin);

                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al filtrar el reporte: " + ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
