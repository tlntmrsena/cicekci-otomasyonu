namespace CicekciAPP.Forms
{
    partial class AnaMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            exitBtn = new Button();
            pnlHeader = new Panel();
            lblBaslik = new Label();
            pictureBox1 = new PictureBox();
            pnlMenu = new Panel();
            btnAyarlar = new Button();
            btnRaporlar = new Button();
            btnStokIslemleri = new Button();
            btnSatisGecmisi = new Button();
            btnSatisYap = new Button();
            btnMusteriYonetimi = new Button();
            btnUrunYonetimi = new Button();
            btnDashboard = new Button();
            pnlMain = new Panel();
            pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlMenu.SuspendLayout();
            SuspendLayout();
            // 
            // exitBtn
            // 
            exitBtn.FlatStyle = FlatStyle.Flat;
            exitBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            exitBtn.Location = new Point(986, 7);
            exitBtn.Name = "exitBtn";
            exitBtn.Size = new Size(25, 25);
            exitBtn.TabIndex = 4;
            exitBtn.Text = "X";
            exitBtn.UseVisualStyleBackColor = true;
            exitBtn.Click += exitBtn_Click;
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.White;
            pnlHeader.Controls.Add(lblBaslik);
            pnlHeader.Controls.Add(pictureBox1);
            pnlHeader.Controls.Add(exitBtn);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1035, 125);
            pnlHeader.TabIndex = 13;
            pnlHeader.MouseDown += pnlHeader_MouseDown;
            // 
            // lblBaslik
            // 
            lblBaslik.AutoSize = true;
            lblBaslik.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblBaslik.ForeColor = SystemColors.Highlight;
            lblBaslik.Location = new Point(249, 45);
            lblBaslik.Name = "lblBaslik";
            lblBaslik.Size = new Size(0, 45);
            lblBaslik.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Yeşil_Pembe_Suluboya_Çiçek_Mağazası_Logo;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 160);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.White;
            pnlMenu.Controls.Add(btnAyarlar);
            pnlMenu.Controls.Add(btnRaporlar);
            pnlMenu.Controls.Add(btnStokIslemleri);
            pnlMenu.Controls.Add(btnSatisGecmisi);
            pnlMenu.Controls.Add(btnSatisYap);
            pnlMenu.Controls.Add(btnMusteriYonetimi);
            pnlMenu.Controls.Add(btnUrunYonetimi);
            pnlMenu.Controls.Add(btnDashboard);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 125);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(243, 510);
            pnlMenu.TabIndex = 14;
            pnlMenu.Paint += pnlMenu_Paint;
            // 
            // btnAyarlar
            // 
            btnAyarlar.BackColor = Color.Transparent;
            btnAyarlar.Dock = DockStyle.Top;
            btnAyarlar.FlatAppearance.BorderSize = 0;
            btnAyarlar.FlatStyle = FlatStyle.Flat;
            btnAyarlar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAyarlar.Image = Properties.Resources.icons8_settings_24;
            btnAyarlar.Location = new Point(0, 385);
            btnAyarlar.Name = "btnAyarlar";
            btnAyarlar.Size = new Size(243, 55);
            btnAyarlar.TabIndex = 8;
            btnAyarlar.Text = "Ayarlar";
            btnAyarlar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnAyarlar.UseVisualStyleBackColor = false;
            btnAyarlar.Click += btnAyarlar_Click;
            // 
            // btnRaporlar
            // 
            btnRaporlar.BackColor = Color.Transparent;
            btnRaporlar.Dock = DockStyle.Top;
            btnRaporlar.FlatAppearance.BorderSize = 0;
            btnRaporlar.FlatStyle = FlatStyle.Flat;
            btnRaporlar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnRaporlar.Image = Properties.Resources.icons8_reports_24;
            btnRaporlar.Location = new Point(0, 330);
            btnRaporlar.Name = "btnRaporlar";
            btnRaporlar.Size = new Size(243, 55);
            btnRaporlar.TabIndex = 7;
            btnRaporlar.Text = "Raporlar";
            btnRaporlar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnRaporlar.UseVisualStyleBackColor = false;
            btnRaporlar.Click += btnRaporlar_Click;
            // 
            // btnStokIslemleri
            // 
            btnStokIslemleri.BackColor = Color.Transparent;
            btnStokIslemleri.Dock = DockStyle.Top;
            btnStokIslemleri.FlatAppearance.BorderSize = 0;
            btnStokIslemleri.FlatStyle = FlatStyle.Flat;
            btnStokIslemleri.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnStokIslemleri.Image = Properties.Resources.icons8_stock_24;
            btnStokIslemleri.Location = new Point(0, 275);
            btnStokIslemleri.Name = "btnStokIslemleri";
            btnStokIslemleri.Size = new Size(243, 55);
            btnStokIslemleri.TabIndex = 6;
            btnStokIslemleri.Text = "Stok İşlemleri";
            btnStokIslemleri.TextImageRelation = TextImageRelation.ImageAboveText;
            btnStokIslemleri.UseVisualStyleBackColor = false;
            btnStokIslemleri.Click += btnStokIslemleri_Click;
            // 
            // btnSatisGecmisi
            // 
            btnSatisGecmisi.BackColor = Color.Transparent;
            btnSatisGecmisi.Dock = DockStyle.Top;
            btnSatisGecmisi.FlatAppearance.BorderSize = 0;
            btnSatisGecmisi.FlatStyle = FlatStyle.Flat;
            btnSatisGecmisi.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSatisGecmisi.Image = Properties.Resources.icons8_order_history_24;
            btnSatisGecmisi.Location = new Point(0, 220);
            btnSatisGecmisi.Name = "btnSatisGecmisi";
            btnSatisGecmisi.Size = new Size(243, 55);
            btnSatisGecmisi.TabIndex = 5;
            btnSatisGecmisi.Text = "Satış Geçmişi";
            btnSatisGecmisi.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSatisGecmisi.UseVisualStyleBackColor = false;
            btnSatisGecmisi.Click += btnSatisGecmisi_Click;
            // 
            // btnSatisYap
            // 
            btnSatisYap.BackColor = Color.Transparent;
            btnSatisYap.Dock = DockStyle.Top;
            btnSatisYap.FlatAppearance.BorderSize = 0;
            btnSatisYap.FlatStyle = FlatStyle.Flat;
            btnSatisYap.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSatisYap.Image = Properties.Resources.icons8_point_of_sale_24;
            btnSatisYap.Location = new Point(0, 165);
            btnSatisYap.Name = "btnSatisYap";
            btnSatisYap.Size = new Size(243, 55);
            btnSatisYap.TabIndex = 4;
            btnSatisYap.Text = "Satış Yap";
            btnSatisYap.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSatisYap.UseVisualStyleBackColor = false;
            btnSatisYap.Click += btnSatisYap_Click;
            // 
            // btnMusteriYonetimi
            // 
            btnMusteriYonetimi.BackColor = Color.Transparent;
            btnMusteriYonetimi.Dock = DockStyle.Top;
            btnMusteriYonetimi.FlatAppearance.BorderSize = 0;
            btnMusteriYonetimi.FlatStyle = FlatStyle.Flat;
            btnMusteriYonetimi.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnMusteriYonetimi.Image = Properties.Resources.icons8_customer_24;
            btnMusteriYonetimi.Location = new Point(0, 110);
            btnMusteriYonetimi.Name = "btnMusteriYonetimi";
            btnMusteriYonetimi.Size = new Size(243, 55);
            btnMusteriYonetimi.TabIndex = 3;
            btnMusteriYonetimi.Text = "Müşteri Yönetimi";
            btnMusteriYonetimi.TextImageRelation = TextImageRelation.ImageAboveText;
            btnMusteriYonetimi.UseVisualStyleBackColor = false;
            btnMusteriYonetimi.Click += btnMusteriYonetimi_Click;
            // 
            // btnUrunYonetimi
            // 
            btnUrunYonetimi.BackColor = Color.Transparent;
            btnUrunYonetimi.Dock = DockStyle.Top;
            btnUrunYonetimi.FlatAppearance.BorderSize = 0;
            btnUrunYonetimi.FlatStyle = FlatStyle.Flat;
            btnUrunYonetimi.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUrunYonetimi.Image = Properties.Resources.icons8_flowers_24;
            btnUrunYonetimi.Location = new Point(0, 55);
            btnUrunYonetimi.Name = "btnUrunYonetimi";
            btnUrunYonetimi.Size = new Size(243, 55);
            btnUrunYonetimi.TabIndex = 2;
            btnUrunYonetimi.Text = "Ürün Yönetimi";
            btnUrunYonetimi.TextImageRelation = TextImageRelation.ImageAboveText;
            btnUrunYonetimi.UseVisualStyleBackColor = false;
            btnUrunYonetimi.Click += btnUrunYonetimi_Click;
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.Transparent;
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatAppearance.BorderSize = 0;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDashboard.Image = Properties.Resources.icons8_dashboard_24;
            btnDashboard.ImageAlign = ContentAlignment.BottomCenter;
            btnDashboard.Location = new Point(0, 0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(243, 55);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.TextImageRelation = TextImageRelation.ImageAboveText;
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // pnlMain
            // 
            pnlMain.BackColor = Color.White;
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(243, 125);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(792, 510);
            pnlMain.TabIndex = 15;
            // 
            // AnaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 635);
            Controls.Add(pnlMain);
            Controls.Add(pnlMenu);
            Controls.Add(pnlHeader);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AnaMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AnaMenu";
            Load += AnaMenu_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlMenu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button exitBtn;
        private Panel pnlHeader;
        private Panel pnlMenu;
        private Panel pnlMain;
        private Button button1;
        private Button btnDashboard;
        private Button btnMusteriYonetimi;
        private Button btnSatisYap;
        private Button btnSatisGecmisi;
        private Button btnStokIslemleri;
        private Button button13;
        private Button btnRaporlar;
        private Button btnUrunYonetimi;
        private Button btnAyarlar;
        private PictureBox pictureBox1;
        private Label lblBaslik;
    }
}