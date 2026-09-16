namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWelcome = new Label();
            pnlCircle = new Panel();
            lblIcon = new Label();
            lblTitle = new Label();
            pnlInfo = new Panel();
            lblInfoIcon = new Label();
            lblInfoText = new Label();
            lblMain = new Label();
            lblDesc = new Label();
            btnEnter = new Button();
            lblFooter = new Label();
            pnlCircle.SuspendLayout();
            pnlInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 9F);
            lblWelcome.ForeColor = Color.FromArgb(120, 120, 120);
            lblWelcome.Location = new Point(20, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(110, 15);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Boas-vindas e login";
            lblWelcome.Click += lblWelcome_Click;
            // 
            // pnlCircle
            // 
            pnlCircle.Anchor = AnchorStyles.Top;
            pnlCircle.BackColor = Color.FromArgb(212, 249, 224);
            pnlCircle.Controls.Add(lblIcon);
            pnlCircle.Location = new Point(284, 70);
            pnlCircle.Name = "pnlCircle";
            pnlCircle.Size = new Size(140, 140);
            pnlCircle.TabIndex = 1;
            pnlCircle.Paint += PnlCircle_Paint;
            // 
            // lblIcon
            // 
            lblIcon.Dock = DockStyle.Fill;
            lblIcon.Font = new Font("Segoe UI Emoji", 36F);
            lblIcon.Location = new Point(0, 0);
            lblIcon.Name = "lblIcon";
            lblIcon.Size = new Size(140, 140);
            lblIcon.TabIndex = 0;
            lblIcon.Text = "🌱";
            lblIcon.TextAlign = ContentAlignment.MiddleCenter;
            lblIcon.Click += lblIcon_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(45, 62, 48);
            lblTitle.Location = new Point(284, 230);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(104, 30);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "EcoTrace";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlInfo
            // 
            pnlInfo.BackColor = Color.FromArgb(225, 245, 236);
            pnlInfo.Controls.Add(lblInfoIcon);
            pnlInfo.Controls.Add(lblInfoText);
            pnlInfo.Location = new Point(20, 287);
            pnlInfo.Name = "pnlInfo";
            pnlInfo.Size = new Size(284, 80);
            pnlInfo.TabIndex = 3;
            pnlInfo.Paint += PnlInfo_Paint;
            // 
            // lblInfoIcon
            // 
            lblInfoIcon.Font = new Font("Segoe UI Emoji", 12F);
            lblInfoIcon.Location = new Point(16, 26);
            lblInfoIcon.Name = "lblInfoIcon";
            lblInfoIcon.Size = new Size(28, 28);
            lblInfoIcon.TabIndex = 0;
            lblInfoIcon.Text = "🌳";
            // 
            // lblInfoText
            // 
            lblInfoText.AutoSize = true;
            lblInfoText.Font = new Font("Segoe UI", 9F);
            lblInfoText.ForeColor = Color.FromArgb(50, 90, 60);
            lblInfoText.Location = new Point(50, 31);
            lblInfoText.Name = "lblInfoText";
            lblInfoText.Size = new Size(159, 15);
            lblInfoText.TabIndex = 1;
            lblInfoText.Text = "Ilustração: florestas e planeta";
            // 
            // lblMain
            // 
            lblMain.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblMain.ForeColor = Color.FromArgb(30, 30, 30);
            lblMain.Location = new Point(30, 370);
            lblMain.Name = "lblMain";
            lblMain.Size = new Size(284, 80);
            lblMain.TabIndex = 4;
            lblMain.Text = "Cada quilômetro conta.\r\nCada escolha planta um futuro.";
            // 
            // lblDesc
            // 
            lblDesc.Font = new Font("Segoe UI", 9F);
            lblDesc.ForeColor = Color.FromArgb(110, 110, 110);
            lblDesc.Location = new Point(30, 460);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(284, 60);
            lblDesc.TabIndex = 5;
            lblDesc.Text = "Meça, entenda e reduza sua pegada de carbono no dia a dia.";
            // 
            // btnEnter
            // 
            btnEnter.BackColor = Color.FromArgb(54, 51, 44);
            btnEnter.FlatAppearance.BorderSize = 0;
            btnEnter.FlatStyle = FlatStyle.Flat;
            btnEnter.Font = new Font("Segoe UI", 10F);
            btnEnter.ForeColor = Color.White;
            btnEnter.Location = new Point(60, 540);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(284, 44);
            btnEnter.TabIndex = 6;
            btnEnter.Text = "Entrar";
            btnEnter.UseVisualStyleBackColor = false;
            btnEnter.Click += BtnEnter_Click;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Font = new Font("Segoe UI", 8F);
            lblFooter.ForeColor = Color.FromArgb(160, 160, 160);
            lblFooter.Location = new Point(40, 261);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(317, 13);
            lblFooter.TabIndex = 7;
            lblFooter.Text = "Ao entrar você aceita nossos Termos e Política de Privacidade";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(400, 800);
            Controls.Add(lblWelcome);
            Controls.Add(pnlCircle);
            Controls.Add(lblTitle);
            Controls.Add(pnlInfo);
            Controls.Add(lblMain);
            Controls.Add(lblDesc);
            Controls.Add(btnEnter);
            Controls.Add(lblFooter);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EcoTrace - Login";
            pnlCircle.ResumeLayout(false);
            pnlInfo.ResumeLayout(false);
            pnlInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
