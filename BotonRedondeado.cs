using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;

#pragma warning disable WFO1000 
public class BotonRedondeado : Button
{
    public int RadioBorde { get; set; } = 20;
    public Color ColorBorde { get; set; } = Color.FromArgb(39, 174, 96);
    public int TamañoBorde { get; set; } = 2;

    public BotonRedondeado()
    {
        this.FlatStyle = FlatStyle.Flat;
        this.FlatAppearance.BorderSize = 0;
        this.BackColor = Color.Transparent;
        this.ForeColor = Color.White;
        this.Size = new Size(150, 40);
    }

    // ESTO ELIMINA EL RECUADRO BLANCO DEFINITIVAMENTE
    protected override CreateParams CreateParams
    {
        get
        {
            CreateParams cp = base.CreateParams;
            cp.ExStyle |= 0x00000020; // WS_EX_TRANSPARENT
            return cp;
        }
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        Graphics graph = pevent.Graphics;
        graph.SmoothingMode = SmoothingMode.AntiAlias;

        Rectangle rectSuperficie = this.ClientRectangle;
        Rectangle rectBorde = Rectangle.Inflate(rectSuperficie, -TamañoBorde, -TamañoBorde);
        int radioReal = RadioBorde;
        if (radioReal > rectSuperficie.Height / 2) radioReal = rectSuperficie.Height / 2;

        using (GraphicsPath pathSuperficie = GetFigurePath(rectSuperficie, radioReal))
        using (GraphicsPath pathBorde = GetFigurePath(rectBorde, radioReal))
        using (SolidBrush brushFondo = new SolidBrush(this.BackColor == Color.Transparent ? Color.FromArgb(60, 255, 255, 255) : this.BackColor))
        using (Pen penBorde = new Pen(ColorBorde, TamañoBorde))
        {
            // Dibujar el fondo del botón (relleno)
            // Si el BackColor es Transparent en el diseñador, aquí le damos un color sólido
            // para que se vea el cuerpo del botón.
            Color colorRelleno = (this.BackColor == Color.Transparent) ? Color.FromArgb(45, 45, 48) : this.BackColor;
            using (SolidBrush brushReal = new SolidBrush(colorRelleno))
            {
                graph.FillPath(brushReal, pathSuperficie);
            }

            // Dibujar el borde suavizado
            if (TamañoBorde >= 1)
            {
                graph.DrawPath(penBorde, pathSuperficie);
            }

            // Dibujar texto centrado
            TextRenderer.DrawText(graph, this.Text, this.Font, rectSuperficie, this.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
        }
    }

    private GraphicsPath GetFigurePath(Rectangle rect, int radius)
    {
        GraphicsPath path = new GraphicsPath();
        float curveSize = radius * 2F;
        path.StartFigure();
        path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
        path.AddArc(rect.Width - curveSize, rect.Y, curveSize, curveSize, 270, 90);
        path.AddArc(rect.Width - curveSize, rect.Height - curveSize, curveSize, curveSize, 0, 90);
        path.AddArc(rect.X, rect.Height - curveSize, curveSize, curveSize, 90, 90);
        path.CloseFigure();
        return path;
    }

    // Forzar redibujado cuando se mueve o cambia el fondo
    protected override void OnParentBackColorChanged(EventArgs e) { base.OnParentBackColorChanged(e); this.Invalidate(); }
}