namespace CicekciAPP.Forms
{
    partial class frmMusteri
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
            panel1 = new Panel();
            btnMusteriEkle = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            txtArama = new TextBox();
            dgvMusteriler = new DataGridView();
            pnlMusteriIslem = new Panel();
            pictureBox2 = new PictureBox();
            btnIptal = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnKaydet = new Button();
            txtNotlar = new RichTextBox();
            txtTelefon = new TextBox();
            txtSoyad = new TextBox();
            txtAd = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).BeginInit();
            pnlMusteriIslem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnMusteriEkle);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtArama);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(792, 57);
            panel1.TabIndex = 0;
            // 
            // btnMusteriEkle
            // 
            btnMusteriEkle.BackColor = Color.FromArgb(192, 255, 192);
            btnMusteriEkle.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            btnMusteriEkle.FlatStyle = FlatStyle.Flat;
            btnMusteriEkle.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnMusteriEkle.Image = Properties.Resources.icons8_customer_24;
            btnMusteriEkle.Location = new Point(4, 4);
            btnMusteriEkle.Name = "btnMusteriEkle";
            btnMusteriEkle.Size = new Size(89, 48);
            btnMusteriEkle.TabIndex = 2;
            btnMusteriEkle.Text = "Yeni Müşteri";
            btnMusteriEkle.TextImageRelation = TextImageRelation.ImageAboveText;
            btnMusteriEkle.UseVisualStyleBackColor = false;
            btnMusteriEkle.Click += btnMusteriEkle_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_search_24;
            pictureBox1.Location = new Point(757, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 22);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(608, 46);
            panel2.Name = "panel2";
            panel2.Size = new Size(143, 1);
            panel2.TabIndex = 1;
            // 
            // txtArama
            // 
            txtArama.BorderStyle = BorderStyle.None;
            txtArama.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtArama.Location = new Point(608, 21);
            txtArama.Name = "txtArama";
            txtArama.PlaceholderText = "Arama";
            txtArama.Size = new Size(143, 22);
            txtArama.TabIndex = 0;
            txtArama.TextChanged += txtArama_TextChanged;
            // 
            // dgvMusteriler
            // 
            dgvMusteriler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvMusteriler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvMusteriler.BackgroundColor = Color.White;
            dgvMusteriler.BorderStyle = BorderStyle.None;
            dgvMusteriler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMusteriler.Dock = DockStyle.Fill;
            dgvMusteriler.Location = new Point(0, 57);
            dgvMusteriler.Name = "dgvMusteriler";
            dgvMusteriler.Size = new Size(792, 453);
            dgvMusteriler.TabIndex = 2;
            dgvMusteriler.CellDoubleClick += dgvMusteriler_CellDoubleClick;
            // 
            // pnlMusteriIslem
            // 
            pnlMusteriIslem.BackColor = Color.FromArgb(192, 255, 192);
            pnlMusteriIslem.Controls.Add(pictureBox2);
            pnlMusteriIslem.Controls.Add(btnIptal);
            pnlMusteriIslem.Controls.Add(btnSil);
            pnlMusteriIslem.Controls.Add(btnGuncelle);
            pnlMusteriIslem.Controls.Add(btnKaydet);
            pnlMusteriIslem.Controls.Add(txtNotlar);
            pnlMusteriIslem.Controls.Add(txtTelefon);
            pnlMusteriIslem.Controls.Add(txtSoyad);
            pnlMusteriIslem.Controls.Add(txtAd);
            pnlMusteriIslem.Controls.Add(label4);
            pnlMusteriIslem.Controls.Add(label3);
            pnlMusteriIslem.Controls.Add(label2);
            pnlMusteriIslem.Controls.Add(label1);
            pnlMusteriIslem.Dock = DockStyle.Right;
            pnlMusteriIslem.Location = new Point(511, 57);
            pnlMusteriIslem.Name = "pnlMusteriIslem";
            pnlMusteriIslem.Size = new Size(281, 453);
            pnlMusteriIslem.TabIndex = 3;
            pnlMusteriIslem.Visible = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_customer_100;
            pictureBox2.Location = new Point(116, 18);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(152, 76);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // btnIptal
            // 
            btnIptal.BackColor = Color.White;
            btnIptal.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            btnIptal.FlatStyle = FlatStyle.Flat;
            btnIptal.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnIptal.ForeColor = SystemColors.ControlText;
            btnIptal.Image = Properties.Resources.icons8_give_up_24;
            btnIptal.Location = new Point(16, 379);
            btnIptal.Name = "btnIptal";
            btnIptal.Size = new Size(252, 52);
            btnIptal.TabIndex = 10;
            btnIptal.Text = "Vazgeç";
            btnIptal.TextImageRelation = TextImageRelation.ImageAboveText;
            btnIptal.UseVisualStyleBackColor = false;
            btnIptal.Click += Button4_Click;
            // 
            // btnSil
            // 
            btnSil.BackColor = Color.White;
            btnSil.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSil.ForeColor = SystemColors.ControlText;
            btnSil.Image = Properties.Resources.icons8_delete_24;
            btnSil.Location = new Point(188, 313);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(80, 60);
            btnSil.TabIndex = 9;
            btnSil.Text = "Sil";
            btnSil.TextImageRelation = TextImageRelation.ImageAboveText;
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.White;
            btnGuncelle.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnGuncelle.ForeColor = SystemColors.ControlText;
            btnGuncelle.Image = Properties.Resources.icons8_update_24;
            btnGuncelle.Location = new Point(102, 313);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(80, 60);
            btnGuncelle.TabIndex = 8;
            btnGuncelle.Text = "Güncelle";
            btnGuncelle.TextImageRelation = TextImageRelation.ImageAboveText;
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.White;
            btnKaydet.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            btnKaydet.FlatStyle = FlatStyle.Flat;
            btnKaydet.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnKaydet.ForeColor = SystemColors.ControlText;
            btnKaydet.Image = Properties.Resources.icons8_save_24;
            btnKaydet.Location = new Point(16, 313);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(80, 60);
            btnKaydet.TabIndex = 3;
            btnKaydet.Text = "Kaydet";
            btnKaydet.TextImageRelation = TextImageRelation.ImageAboveText;
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += button1_Click;
            // 
            // txtNotlar
            // 
            txtNotlar.AutoWordSelection = true;
            txtNotlar.BorderStyle = BorderStyle.None;
            txtNotlar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtNotlar.Location = new Point(116, 172);
            txtNotlar.Name = "txtNotlar";
            txtNotlar.Size = new Size(152, 96);
            txtNotlar.TabIndex = 7;
            txtNotlar.Text = "";
            // 
            // txtTelefon
            // 
            txtTelefon.BorderStyle = BorderStyle.None;
            txtTelefon.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtTelefon.Location = new Point(116, 148);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.PlaceholderText = "Telefon";
            txtTelefon.Size = new Size(152, 18);
            txtTelefon.TabIndex = 6;
            // 
            // txtSoyad
            // 
            txtSoyad.BorderStyle = BorderStyle.None;
            txtSoyad.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtSoyad.Location = new Point(116, 124);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.PlaceholderText = "Soyad";
            txtSoyad.Size = new Size(152, 18);
            txtSoyad.TabIndex = 5;
            // 
            // txtAd
            // 
            txtAd.BorderStyle = BorderStyle.None;
            txtAd.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtAd.Location = new Point(116, 100);
            txtAd.Name = "txtAd";
            txtAd.PlaceholderText = "Ad";
            txtAd.Size = new Size(152, 18);
            txtAd.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(9, 175);
            label4.Name = "label4";
            label4.Size = new Size(96, 17);
            label4.TabIndex = 3;
            label4.Text = "Müşteri Notu :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(47, 148);
            label3.Name = "label3";
            label3.Size = new Size(58, 17);
            label3.TabIndex = 2;
            label3.Text = "Telefon :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(50, 124);
            label2.Name = "label2";
            label2.Size = new Size(55, 17);
            label2.TabIndex = 1;
            label2.Text = "Soyadı :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(73, 101);
            label1.Name = "label1";
            label1.Size = new Size(32, 17);
            label1.TabIndex = 0;
            label1.Text = "Ad :";
            // 
            // frmMusteri
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(792, 510);
            Controls.Add(pnlMusteriIslem);
            Controls.Add(dgvMusteriler);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMusteri";
            Text = "frmMusteri";
            Load += frmMusteri_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvMusteriler).EndInit();
            pnlMusteriIslem.ResumeLayout(false);
            pnlMusteriIslem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtArama;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Button btnMusteriEkle;
        private DataGridView dgvMusteriler;
        private Panel pnlMusteriIslem;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtAd;
        private RichTextBox txtNotlar;
        private TextBox txtTelefon;
        private TextBox txtSoyad;
        private Button btnIptal;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnKaydet;
        private PictureBox pictureBox2;
    }
}