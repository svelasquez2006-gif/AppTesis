using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class BotonRedondo : Button
{
    public int RadioBorde { get; set; } = 20;

    public BotonRedondo()
    {
        // SOLUCIÓN 1: Forzar estilo plano para eliminar los bordes nativos grises/negros
        this.FlatStyle = FlatStyle.Flat;
        this.FlatAppearance.BorderSize = 1;
        this.Size = new Size(150, 40); // Tamaño inicial sugerido
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        // NO llamamos a base.OnPaint(pevent) para evitar que Windows pinte el fondo cuadrado original

        Graphics graphics = pevent.Graphics;
        graphics.SmoothingMode = SmoothingMode.AntiAlias; // Suaviza los pixeles del borde

        // SOLUCIÓN 2: Reducir 1 píxel el área para que el contorno no se recorte con el borde del botón
        Rectangle rectSuperficie = new Rectangle(0, 0, this.Width, this.Height);
        Rectangle rectBorde = new Rectangle(1, 1, this.Width - 2, this.Height - 2);

        using (GraphicsPath pathSuperficie = ObtenerRutaRedonda(rectSuperficie, RadioBorde))
        using (GraphicsPath pathBorde = ObtenerRutaRedonda(rectBorde, RadioBorde - 1))
        using (SolidBrush brushFondo = new SolidBrush(this.BackColor))
        using (SolidBrush brushTexto = new SolidBrush(this.ForeColor))
        using (Pen penBorde = new Pen(this.FlatAppearance.BorderColor, 1.5f)) // Grosor del borde
        {
            // Definir la región de clic del botón
            this.Region = new Region(pathSuperficie);

            // 1. Pintar el fondo del botón
            graphics.FillPath(brushFondo, pathSuperficie);

            // 2. Pintar el borde (solo si no es transparente)
            if (this.FlatAppearance.BorderSize > 0 || penBorde.Color != Color.Transparent)
            {
                penBorde.Alignment = PenAlignment.Inset; // Dibuja hacia adentro para evitar recortes
                graphics.DrawPath(penBorde, pathBorde);
            }

            // 3. Pintar el texto centrado manualmente
            TextRenderer.DrawText(
                graphics,
                this.Text,
                this.Font,
                rectSuperficie,
                this.ForeColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
            );
        }
    }

    // Método auxiliar para generar la geometría de esquinas curvas perfectamente alineadas
    private GraphicsPath ObtenerRutaRedonda(Rectangle rect, int radio)
    {
        GraphicsPath path = new GraphicsPath();
        int diametro = Math.Max(radio * 2, 1); // Evita errores si el radio es cero

        path.StartFigure();
        path.AddArc(rect.X, rect.Y, diametro, diametro, 180, 90);
        path.AddArc(rect.Width - diametro + rect.X, rect.Y, diametro, diametro, 270, 90);
        path.AddArc(rect.Width - diametro + rect.X, rect.Height - diametro + rect.Y, diametro, diametro, 0, 90);
        path.AddArc(rect.X, rect.Height - diametro + rect.Y, diametro, diametro, 90, 90);
        path.CloseFigure();

        return path;
    }
}
