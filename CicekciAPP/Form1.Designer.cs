namespace CicekciAPP
{
    partial class Main
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
            panel1 = new Panel();
            linkLabel1 = new LinkLabel();
            picLogo = new PictureBox();
            exitBtn = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            txtSifre = new TextBox();
            btnGiris = new Button();
            txtKullaniciAdi = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(picLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(269, 274);
            panel1.TabIndex = 0;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(74, 250);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(125, 15);
            linkLabel1.TabIndex = 5;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "www.senayazilim.com";
            // 
            // picLogo
            // 
            picLogo.Dock = DockStyle.Fill;
            picLogo.Image = Properties.Resources.SenaCicekcilik;
            picLogo.Location = new Point(0, 0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(269, 274);
            picLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogo.TabIndex = 0;
            picLogo.TabStop = false;
            // 
            // exitBtn
            // 
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            exitBtn.Location = new Point(333, 6);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(25, 25);
            exitBtn.TabIndex = 4;
            exitBtn.Text = "X";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(398, 101);
            panel2.Name = "panel2";
            panel2.Size = new Size(177, 1);
            panel2.TabIndex = 5;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(398, 130);
            panel3.Name = "panel3";
            panel3.Size = new Size(177, 1);
            panel3.TabIndex = 7;
            // 
            // txtSifre
            // 
            txtSifre.BorderStyle = BorderStyle.None;
            txtSifre.Location = new Point(398, 112);
            txtSifre.Name = "txtSifre";
            txtSifre.PasswordChar = '*';
            txtSifre.PlaceholderText = "Şifre";
            txtSifre.Size = new Size(177, 16);
            txtSifre.TabIndex = 2;
            // 
            // btnGiris
            // 
            btnGiris.BackgroundImageLayout = ImageLayout.Stretch;
            btnGiris.FlatStyle = FlatStyle.Flat;
            btnGiris.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGiris.Image = Properties.Resources.icons8_login_24;
            btnGiris.Location = new Point(398, 137);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(177, 35);
            btnGiris.TabIndex = 3;
            btnGiris.Text = "    Giriş Yap";
            btnGiris.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.BorderStyle = BorderStyle.None;
            txtKullaniciAdi.Location = new Point(398, 83);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.PasswordChar = '*';
            txtKullaniciAdi.PlaceholderText = "Kullanıcı Adı";
            txtKullaniciAdi.Size = new Size(177, 16);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_password_24;
            pictureBox1.Location = new Point(368, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(24, 24);
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_account_24;
            pictureBox2.Location = new Point(368, 78);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(24, 24);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(exitBtn);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(269, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(370, 39);
            panel4.TabIndex = 12;
            panel4.Paint += panel4_Paint;
            panel4.MouseDown += panel4_MouseDown;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(639, 274);
            Controls.Add(panel4);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(btnGiris);
            Controls.Add(panel3);
            Controls.Add(txtSifre);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sena Çiçekçilil";
            Load += Main_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox picLogo;
        private Button exitBtn;
        private Panel panel2;
        private Panel panel3;
        private TextBox txtSifre;
        private Button btnGiris;
        private TextBox txtKullaniciAdi;
        private LinkLabel linkLabel1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel4;
    }
}
