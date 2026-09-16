using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        // Controls
        private Label lblWelcome;
        private Panel pnlCircle;
        private Label lblIcon;
        private Label lblTitle;
        private Panel pnlInfo;
        private Label lblInfoIcon;
        private Label lblInfoText;
        private Label lblMain;
        private Label lblDesc;
        private Button btnEnter;
        private Label lblFooter;

        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            // center some controls that relied on ClientSize during Initialize
            pnlCircle.Left = (this.ClientSize.Width - pnlCircle.Width) / 2;
            lblTitle.Left = 0;
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.Left = 0;
            lblTitle.Width = this.ClientSize.Width;

            // Round the enter button
            SetRoundedRegion(btnEnter, 22);

            // Round the info panel
            SetRoundedRegion(pnlInfo, 12);
        }

        private void SetRoundedRegion(Control ctrl, int radius)
        {
            var rect = new Rectangle(0, 0, ctrl.Width, ctrl.Height);
            using var path = RoundedRect(rect, radius);
            ctrl.Region = new Region(path);
        }

        private GraphicsPath RoundedRect(Rectangle bounds, int radius)
        {
            var path = new GraphicsPath();
            int d = radius * 2;
            path.AddArc(bounds.X, bounds.Y, d, d, 180, 90);
            path.AddArc(bounds.Right - d, bounds.Y, d, d, 270, 90);
            path.AddArc(bounds.Right - d, bounds.Bottom - d, d, d, 0, 90);
            path.AddArc(bounds.X, bounds.Bottom - d, d, d, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void PnlCircle_Paint(object? sender, PaintEventArgs e)
        {
            var panel = sender as Panel;
            if (panel == null) return;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using var brush = new SolidBrush(panel.BackColor);
            e.Graphics.FillEllipse(brush, 0, 0, panel.Width - 1, panel.Height - 1);
        }

        private void PnlInfo_Paint(object? sender, PaintEventArgs e)
        {
            var panel = sender as Panel;
            if (panel == null) return;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            using var path = RoundedRect(new Rectangle(0, 0, panel.Width - 1, panel.Height - 1), 12);
            using var brush = new SolidBrush(panel.BackColor);
            e.Graphics.FillPath(brush, path);
        }

        private void BtnEnter_Click(object? sender, EventArgs e)
        {
            // Abrir a calculadora de impacto
            var calc = new FormCalculator();
            calc.ShowDialog(this);
        }

        private void lblIcon_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }
    }
}
