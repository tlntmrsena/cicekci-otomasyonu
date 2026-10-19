namespace CicekciAPP.Forms
{
    partial class frmUrun
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
            pictureBox2 = new PictureBox();
            btnIptal = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnKaydet = new Button();
            txtAciklama = new RichTextBox();
            txtUrunAdi = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvUrunler = new DataGridView();
            btnUrunEkle = new Button();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            txtArama = new TextBox();
            pnlUrunIslem = new Panel();
            chkDurum = new CheckBox();
            pictureBox6 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            pictureBox5 = new PictureBox();
            cmbKategori = new ComboBox();
            pictureBox4 = new PictureBox();
            numStok = new NumericUpDown();
            pictureBox3 = new PictureBox();
            numFiyat = new NumericUpDown();
            panel1 = new Panel();
            cmbFiltre = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnlUrunIslem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numStok).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFiyat).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.icons8_flowers_100;
            pictureBox2.Location = new Point(36, 6);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(232, 76);
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
            btnIptal.Click += btnIptal_Click;
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
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtAciklama
            // 
            txtAciklama.AutoWordSelection = true;
            txtAciklama.BorderStyle = BorderStyle.None;
            txtAciklama.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtAciklama.Location = new Point(116, 236);
            txtAciklama.Name = "txtAciklama";
            txtAciklama.Size = new Size(152, 71);
            txtAciklama.TabIndex = 7;
            txtAciklama.Text = "";
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.BorderStyle = BorderStyle.None;
            txtUrunAdi.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtUrunAdi.Location = new Point(116, 100);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.PlaceholderText = "Ürün Adı";
            txtUrunAdi.Size = new Size(152, 18);
            txtUrunAdi.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(39, 184);
            label4.Name = "label4";
            label4.Size = new Size(66, 17);
            label4.TabIndex = 3;
            label4.Text = "Kategori :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(61, 155);
            label3.Name = "label3";
            label3.Size = new Size(44, 17);
            label3.TabIndex = 2;
            label3.Text = "Adet :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(61, 128);
            label2.Name = "label2";
            label2.Size = new Size(44, 17);
            label2.TabIndex = 1;
            label2.Text = "Fiyat :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(36, 100);
            label1.Name = "label1";
            label1.Size = new Size(69, 17);
            label1.TabIndex = 0;
            label1.Text = "Ürün Adı :";
            // 
            // dgvUrunler
            // 
            dgvUrunler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dgvUrunler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvUrunler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgvUrunler.BackgroundColor = Color.White;
            dgvUrunler.BorderStyle = BorderStyle.None;
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Dock = DockStyle.Fill;
            dgvUrunler.Location = new Point(0, 57);
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.Size = new Size(511, 453);
            dgvUrunler.TabIndex = 5;
            dgvUrunler.CellDoubleClick += dgvUrunler_CellDoubleClick;
            // 
            // btnUrunEkle
            // 
            btnUrunEkle.BackColor = Color.FromArgb(192, 255, 192);
            btnUrunEkle.FlatAppearance.BorderColor = Color.FromArgb(192, 255, 192);
            btnUrunEkle.FlatStyle = FlatStyle.Flat;
            btnUrunEkle.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnUrunEkle.Image = Properties.Resources.icons8_flowers_24;
            btnUrunEkle.Location = new Point(4, 4);
            btnUrunEkle.Name = "btnUrunEkle";
            btnUrunEkle.Size = new Size(89, 48);
            btnUrunEkle.TabIndex = 2;
            btnUrunEkle.Text = "Yeni Ürün";
            btnUrunEkle.TextImageRelation = TextImageRelation.ImageAboveText;
            btnUrunEkle.UseVisualStyleBackColor = false;
            btnUrunEkle.Click += btnUrunEkle_Click;
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
            // pnlUrunIslem
            // 
            pnlUrunIslem.BackColor = Color.FromArgb(192, 255, 192);
            pnlUrunIslem.Controls.Add(chkDurum);
            pnlUrunIslem.Controls.Add(pictureBox6);
            pnlUrunIslem.Controls.Add(label6);
            pnlUrunIslem.Controls.Add(label5);
            pnlUrunIslem.Controls.Add(pictureBox5);
            pnlUrunIslem.Controls.Add(cmbKategori);
            pnlUrunIslem.Controls.Add(pictureBox4);
            pnlUrunIslem.Controls.Add(numStok);
            pnlUrunIslem.Controls.Add(pictureBox3);
            pnlUrunIslem.Controls.Add(numFiyat);
            pnlUrunIslem.Controls.Add(pictureBox2);
            pnlUrunIslem.Controls.Add(btnIptal);
            pnlUrunIslem.Controls.Add(btnSil);
            pnlUrunIslem.Controls.Add(btnGuncelle);
            pnlUrunIslem.Controls.Add(btnKaydet);
            pnlUrunIslem.Controls.Add(txtAciklama);
            pnlUrunIslem.Controls.Add(txtUrunAdi);
            pnlUrunIslem.Controls.Add(label4);
            pnlUrunIslem.Controls.Add(label3);
            pnlUrunIslem.Controls.Add(label2);
            pnlUrunIslem.Controls.Add(label1);
            pnlUrunIslem.Dock = DockStyle.Right;
            pnlUrunIslem.Location = new Point(511, 57);
            pnlUrunIslem.Name = "pnlUrunIslem";
            pnlUrunIslem.Size = new Size(281, 453);
            pnlUrunIslem.TabIndex = 6;
            pnlUrunIslem.Visible = false;
            // 
            // chkDurum
            // 
            chkDurum.AutoSize = true;
            chkDurum.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            chkDurum.Location = new Point(116, 209);
            chkDurum.Name = "chkDurum";
            chkDurum.Size = new Size(55, 21);
            chkDurum.TabIndex = 20;
            chkDurum.Text = "Aktif";
            chkDurum.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.icons8_control_24;
            pictureBox6.Location = new Point(246, 207);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(22, 22);
            pictureBox6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox6.TabIndex = 19;
            pictureBox6.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(48, 210);
            label6.Name = "label6";
            label6.Size = new Size(57, 17);
            label6.TabIndex = 17;
            label6.Text = "Durum :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(36, 236);
            label5.Name = "label5";
            label5.Size = new Size(69, 17);
            label5.TabIndex = 16;
            label5.Text = "Açıklama :";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.icons8_category_24;
            pictureBox5.Location = new Point(246, 178);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(22, 22);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            // 
            // cmbKategori
            // 
            cmbKategori.FlatStyle = FlatStyle.Flat;
            cmbKategori.FormattingEnabled = true;
            cmbKategori.Location = new Point(116, 178);
            cmbKategori.Name = "cmbKategori";
            cmbKategori.Size = new Size(121, 23);
            cmbKategori.TabIndex = 4;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.icons8_plus_24;
            pictureBox4.Location = new Point(246, 150);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(22, 22);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 13;
            pictureBox4.TabStop = false;
            // 
            // numStok
            // 
            numStok.BorderStyle = BorderStyle.None;
            numStok.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            numStok.Location = new Point(116, 151);
            numStok.Maximum = new decimal(new int[] { -1486618625, 232830643, 0, 0 });
            numStok.Name = "numStok";
            numStok.Size = new Size(124, 21);
            numStok.TabIndex = 14;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.icons8_turkish_lira_24;
            pictureBox3.Location = new Point(246, 123);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(22, 22);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // numFiyat
            // 
            numFiyat.BorderStyle = BorderStyle.None;
            numFiyat.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            numFiyat.Location = new Point(116, 124);
            numFiyat.Maximum = new decimal(new int[] { -1486618625, 232830643, 0, 0 });
            numFiyat.Name = "numFiyat";
            numFiyat.Size = new Size(124, 21);
            numFiyat.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.Controls.Add(cmbFiltre);
            panel1.Controls.Add(btnUrunEkle);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(txtArama);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(792, 57);
            panel1.TabIndex = 4;
            // 
            // cmbFiltre
            // 
            cmbFiltre.FlatStyle = FlatStyle.Flat;
            cmbFiltre.FormattingEnabled = true;
            cmbFiltre.Location = new Point(481, 21);
            cmbFiltre.Name = "cmbFiltre";
            cmbFiltre.Size = new Size(121, 23);
            cmbFiltre.TabIndex = 3;
            cmbFiltre.SelectedIndexChanged += cmbFiltre_SelectedIndexChanged;
            // 
            // frmUrun
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 510);
            Controls.Add(dgvUrunler);
            Controls.Add(pnlUrunIslem);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUrun";
            Text = "frmUrun";
            Load += frmUrun_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnlUrunIslem.ResumeLayout(false);
            pnlUrunIslem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numStok).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFiyat).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox2;
        private Button btnIptal;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnKaydet;
        private RichTextBox txtAciklama;
        private TextBox txtUrunAdi;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dgvUrunler;
        private Button btnUrunEkle;
        private PictureBox pictureBox1;
        private Panel panel2;
        private TextBox txtArama;
        private Panel pnlUrunIslem;
        private Panel panel1;
        private ComboBox cmbFiltre;
        private PictureBox pictureBox4;
        private NumericUpDown numStok;
        private PictureBox pictureBox3;
        private NumericUpDown numFiyat;
        private Label label5;
        private PictureBox pictureBox5;
        private ComboBox cmbKategori;
        private PictureBox pictureBox6;
        private Label label6;
        private CheckBox chkDurum;
    }
}