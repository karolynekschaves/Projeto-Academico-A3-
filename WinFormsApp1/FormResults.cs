using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class FormResults : Form
    {
        private double weeklyKg;
        private double dailyKg;
        private double monthlyKg;
        private double annualKg;

        private Label lblMainGreen;
        private Label lblWeeklyValue;

        public FormResults(double weeklyKg, double dailyKg, double monthlyKg, double annualKg)
        {
            this.weeklyKg = weeklyKg;
            this.dailyKg = dailyKg;
            this.monthlyKg = monthlyKg;
            this.annualKg = annualKg;
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "EcoTrace - Resultados";
            this.ClientSize = new Size(400, 800);
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.White;

            Label lblHeader = new Label();
            lblHeader.Text = "Seu Impacto Ambiental";
            lblHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblHeader.Location = new Point(20, 20);
            lblHeader.AutoSize = true;
            this.Controls.Add(lblHeader);

            // Main green box with weekly estimate
            Panel pnlMain = new Panel();
            pnlMain.BackColor = Color.FromArgb(14, 129, 63);
            pnlMain.Size = new Size(this.ClientSize.Width - 40, 110);
            pnlMain.Location = new Point(20, 60);
            this.Controls.Add(pnlMain);

            Label lblSmall = new Label();
            lblSmall.Text = "CO₂ estimado esta semana";
            lblSmall.Font = new Font("Segoe UI", 9F);
            lblSmall.ForeColor = Color.White;
            lblSmall.Location = new Point(12, 10);
            lblSmall.AutoSize = true;
            pnlMain.Controls.Add(lblSmall);

            lblWeeklyValue = new Label();
            lblWeeklyValue.Text = $"{weeklyKg:0.0} kg CO₂";
            lblWeeklyValue.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblWeeklyValue.ForeColor = Color.White;
            lblWeeklyValue.Location = new Point(12, 35);
            lblWeeklyValue.AutoSize = true;
            pnlMain.Controls.Add(lblWeeklyValue);

            // Small cards
            Panel pnlDaily = CreateCard("Emissão diária", $"{dailyKg:0.0} kg");
            pnlDaily.Location = new Point(20, 190);
            this.Controls.Add(pnlDaily);

            Panel pnlMonthly = CreateCard("Emissão mensal", $"{monthlyKg:0.0} kg");
            pnlMonthly.Location = new Point(220, 190);
            this.Controls.Add(pnlMonthly);

            Panel pnlAnnual = CreateCard("Emissão anual estimada", $"{annualKg:0.0} kg CO₂");
            pnlAnnual.Location = new Point(20, 260);
            pnlAnnual.Size = new Size(this.ClientSize.Width - 40, 60);
            this.Controls.Add(pnlAnnual);

            // Simple bar evolution placeholder
            Label lblEvol = new Label();
            lblEvol.Text = "Evolução semanal";
            lblEvol.Font = new Font("Segoe UI", 9F);
            lblEvol.Location = new Point(20, 340);
            lblEvol.AutoSize = true;
            this.Controls.Add(lblEvol);

            Panel pnlBars = new Panel();
            pnlBars.Location = new Point(20, 370);
            pnlBars.Size = new Size(this.ClientSize.Width - 40, 80);
            this.Controls.Add(pnlBars);

            // Add some simple bars
            for (int i = 0; i < 7; i++)
            {
                Panel b = new Panel();
                b.Size = new Size(30, 20 + (i % 4) * 15);
                b.Location = new Point(i * 45, pnlBars.Height - b.Height);
                b.BackColor = Color.FromArgb(179, 230, 192);
                pnlBars.Controls.Add(b);
            }

            // Tips box
            Panel pnlTips = new Panel();
            pnlTips.BackColor = Color.FromArgb(255, 249, 215);
            pnlTips.Location = new Point(20, 470);
            pnlTips.Size = new Size(this.ClientSize.Width - 40, 120);
            this.Controls.Add(pnlTips);

            Label lblTipsTitle = new Label();
            lblTipsTitle.Text = "Dicas para reduzir";
            lblTipsTitle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblTipsTitle.Location = new Point(10, 10);
            pnlTips.Controls.Add(lblTipsTitle);

            Label lblTips = new Label();
            lblTips.Text = "• Troque 2 dias de carro por bicicleta\n• Use transporte público em rotas longas\n• Plante árvores para compensar";
            lblTips.Font = new Font("Segoe UI", 9F);
            lblTips.Location = new Point(10, 35);
            lblTips.AutoSize = true;
            pnlTips.Controls.Add(lblTips);

            Button btnClose = new Button();
            btnClose.Text = "Fechar";
            btnClose.Location = new Point((this.ClientSize.Width - 100) / 2, this.ClientSize.Height - 70);
            btnClose.Size = new Size(100, 36);
            btnClose.Click += (s, e) => this.Close();
            this.Controls.Add(btnClose);
        }

        private Panel CreateCard(string title, string value)
        {
            Panel p = new Panel();
            p.Size = new Size(160, 60);
            p.BackColor = Color.FromArgb(250, 250, 250);
            p.BorderStyle = BorderStyle.None;

            Label l1 = new Label();
            l1.Text = title;
            l1.Font = new Font("Segoe UI", 8.5F);
            l1.Location = new Point(8, 6);
            l1.AutoSize = true;
            p.Controls.Add(l1);

            Label l2 = new Label();
            l2.Text = value;
            l2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            l2.Location = new Point(8, 28);
            l2.AutoSize = true;
            p.Controls.Add(l2);

            return p;
        }
    }
}
