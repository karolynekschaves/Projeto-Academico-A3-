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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            lblWelcome = new Label();
            lblTitle = new Label();
            pnlInfo = new Panel();
            lblInfoIcon = new Label();
            lblInfoText = new Label();
            lblMain = new Label();
            lblDesc = new Label();
            btnEnter = new Button();
            lblFooter = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pnlInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(45, 62, 48);
            lblTitle.Location = new Point(12, 221);
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
            pnlInfo.Location = new Point(30, 288);
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
            lblMain.Location = new Point(36, 398);
            lblMain.Name = "lblMain";
            lblMain.Size = new Size(284, 80);
            lblMain.TabIndex = 4;
            lblMain.Text = "Cada quilômetro conta.\r\nCada escolha planta um futuro.";
            // 
            // lblDesc
            // 
            lblDesc.Font = new Font("Segoe UI", 9F);
            lblDesc.ForeColor = Color.FromArgb(110, 110, 110);
            lblDesc.Location = new Point(36, 478);
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
            btnEnter.Location = new Point(36, 541);
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
            lblFooter.Location = new Point(30, 602);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(317, 13);
            lblFooter.TabIndex = 7;
            lblFooter.Text = "Ao entrar você aceita nossos Termos e Política de Privacidade";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(70, 47);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(208, 171);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(179, 216, 139);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(125, 86);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 85);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(370, 800);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(lblWelcome);
            Controls.Add(lblTitle);
            Controls.Add(pnlInfo);
            Controls.Add(lblMain);
            Controls.Add(lblDesc);
            Controls.Add(btnEnter);
            Controls.Add(lblFooter);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EcoTrace - Login";
            pnlInfo.ResumeLayout(false);
            pnlInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}
