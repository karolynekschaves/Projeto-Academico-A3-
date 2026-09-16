using System;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public class FormCalculator : Form
    {
        private Label lblTitle;
        private ComboBox cmbVehicle;
        private Label lblKm;
        private TextBox txtKm;
        private Button btnCalculate;

        public FormCalculator()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.Text = "EcoTrace - Calculadora";
            this.ClientSize = new Size(400, 700);
            this.StartPosition = FormStartPosition.CenterParent;
            this.BackColor = Color.White;

            lblTitle = new Label();
            lblTitle.Text = "Transforme seus km em árvores";
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.AutoSize = false;
            lblTitle.Size = new Size(this.ClientSize.Width - 60, 60);
            lblTitle.Location = new Point(30, 20);
            this.Controls.Add(lblTitle);

            Label lblDesc = new Label();
            lblDesc.Text = "Descubra quanto CO₂ você está produzindo e quantas árvores compensam.";
            lblDesc.Font = new Font("Segoe UI", 9F);
            lblDesc.AutoSize = false;
            lblDesc.Size = new Size(this.ClientSize.Width - 60, 40);
            lblDesc.Location = new Point(30, 80);
            this.Controls.Add(lblDesc);

            Label lblVehicle = new Label();
            lblVehicle.Text = "Qual veículo você utiliza?";
            lblVehicle.Font = new Font("Segoe UI", 9F);
            lblVehicle.Location = new Point(30, 140);
            lblVehicle.AutoSize = true;
            this.Controls.Add(lblVehicle);

            cmbVehicle = new ComboBox();
            cmbVehicle.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbVehicle.Items.AddRange(new object[] { "Carro", "Moto", "Ônibus", "Bike" });
            cmbVehicle.SelectedIndex = 0;
            cmbVehicle.Location = new Point(30, 165);
            cmbVehicle.Size = new Size(this.ClientSize.Width - 60, 36);
            cmbVehicle.Font = new Font("Segoe UI", 10F);
            this.Controls.Add(cmbVehicle);

            lblKm = new Label();
            lblKm.Text = "Quantos km você percorre por dia?";
            lblKm.Font = new Font("Segoe UI", 9F);
            lblKm.Location = new Point(30, 220);
            lblKm.AutoSize = true;
            this.Controls.Add(lblKm);

            txtKm = new TextBox();
            txtKm.PlaceholderText = "Ex: 25";
            txtKm.Location = new Point(30, 245);
            txtKm.Size = new Size(this.ClientSize.Width - 60, 36);
            txtKm.Font = new Font("Segoe UI", 10F);
            this.Controls.Add(txtKm);

            Label lblTip = new Label();
            lblTip.Text = "Dica: informe uma média semanal para resultados mais precisos";
            lblTip.Font = new Font("Segoe UI", 8.5F);
            lblTip.BackColor = Color.FromArgb(255, 249, 215);
            lblTip.Padding = new Padding(8);
            lblTip.Location = new Point(30, 300);
            lblTip.Size = new Size(this.ClientSize.Width - 60, 50);
            this.Controls.Add(lblTip);

            btnCalculate = new Button();
            btnCalculate.Text = "Calcular impacto →";
            btnCalculate.BackColor = Color.FromArgb(34, 153, 84);
            btnCalculate.ForeColor = Color.White;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.FlatAppearance.BorderSize = 0;
            btnCalculate.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            btnCalculate.Size = new Size(this.ClientSize.Width - 80, 44);
            btnCalculate.Location = new Point(40, 380);
            btnCalculate.Click += BtnCalculate_Click;
            this.Controls.Add(btnCalculate);
        }

        private void BtnCalculate_Click(object? sender, EventArgs e)
        {
            if (!double.TryParse(txtKm.Text, out double kmPerDay) || kmPerDay < 0)
            {
                MessageBox.Show("Informe um valor de km válido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string vehicle = cmbVehicle.SelectedItem?.ToString() ?? "Carro";

            // Emission factors (kg CO2 per km) - exemplos aproximados
            double factor = vehicle switch
            {
                "Carro" => 0.21,
                "Moto" => 0.11,
                "Ônibus" => 0.05,
                "Bike" => 0.0,
                _ => 0.21
            };

            double daily = kmPerDay * factor; // kg/day
            double weekly = daily * 7;
            double monthly = daily * 30;
            double annual = daily * 365;

            var results = new FormResults(weekly, daily, monthly, annual);
            results.ShowDialog(this);
        }
    }
}
