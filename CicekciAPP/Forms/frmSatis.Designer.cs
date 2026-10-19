namespace CicekciAPP.Forms
{
    partial class frmSatis
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
            pnlSol = new Panel();
            panel1 = new Panel();
            dgvUrunler = new DataGridView();
            txtUrunAra = new TextBox();
            pnlAlt = new Panel();
            btnSatisiTamamla = new Button();
            lblToplamTutar = new Label();
            cmbMusteri = new ComboBox();
            dgvSepet = new DataGridView();
            pnlSol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).BeginInit();
            pnlAlt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSepet).BeginInit();
            SuspendLayout();
            // 
            // pnlSol
            // 
            pnlSol.Controls.Add(panel1);
            pnlSol.Controls.Add(dgvUrunler);
            pnlSol.Controls.Add(txtUrunAra);
            pnlSol.Dock = DockStyle.Left;
            pnlSol.Location = new Point(0, 0);
            pnlSol.Name = "pnlSol";
            pnlSol.Size = new Size(300, 510);
            pnlSol.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(0, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 1);
            panel1.TabIndex = 2;
            // 
            // dgvUrunler
            // 
            dgvUrunler.BackgroundColor = Color.Gainsboro;
            dgvUrunler.BorderStyle = BorderStyle.None;
            dgvUrunler.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUrunler.Dock = DockStyle.Fill;
            dgvUrunler.Location = new Point(0, 30);
            dgvUrunler.Name = "dgvUrunler";
            dgvUrunler.Size = new Size(300, 480);
            dgvUrunler.TabIndex = 1;
            dgvUrunler.CellDoubleClick += dgvUrunler_CellDoubleClick;
            // 
            // txtUrunAra
            // 
            txtUrunAra.BorderStyle = BorderStyle.None;
            txtUrunAra.Dock = DockStyle.Top;
            txtUrunAra.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            txtUrunAra.Location = new Point(0, 0);
            txtUrunAra.MinimumSize = new Size(300, 30);
            txtUrunAra.Name = "txtUrunAra";
            txtUrunAra.PlaceholderText = "Ürün Ara";
            txtUrunAra.Size = new Size(300, 30);
            txtUrunAra.TabIndex = 0;
            txtUrunAra.TextAlign = HorizontalAlignment.Center;
            txtUrunAra.TextChanged += txtUrunAra_TextChanged;
            // 
            // pnlAlt
            // 
            pnlAlt.BackColor = SystemColors.Highlight;
            pnlAlt.Controls.Add(btnSatisiTamamla);
            pnlAlt.Controls.Add(lblToplamTutar);
            pnlAlt.Controls.Add(cmbMusteri);
            pnlAlt.Dock = DockStyle.Bottom;
            pnlAlt.Location = new Point(300, 431);
            pnlAlt.Name = "pnlAlt";
            pnlAlt.Size = new Size(492, 79);
            pnlAlt.TabIndex = 1;
            // 
            // btnSatisiTamamla
            // 
            btnSatisiTamamla.FlatStyle = FlatStyle.Flat;
            btnSatisiTamamla.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnSatisiTamamla.ForeColor = Color.White;
            btnSatisiTamamla.Location = new Point(326, 13);
            btnSatisiTamamla.Name = "btnSatisiTamamla";
            btnSatisiTamamla.Size = new Size(154, 39);
            btnSatisiTamamla.TabIndex = 2;
            btnSatisiTamamla.Text = "Satışı Tamamla";
            btnSatisiTamamla.UseVisualStyleBackColor = true;
            btnSatisiTamamla.Click += btnSatisiTamamla_Click;
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblToplamTutar.ForeColor = Color.White;
            lblToplamTutar.Location = new Point(204, 13);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new Size(73, 30);
            lblToplamTutar.TabIndex = 1;
            lblToplamTutar.Text = "0,00 ₺";
            // 
            // cmbMusteri
            // 
            cmbMusteri.FlatStyle = FlatStyle.Flat;
            cmbMusteri.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            cmbMusteri.ForeColor = Color.Black;
            cmbMusteri.FormattingEnabled = true;
            cmbMusteri.Location = new Point(6, 13);
            cmbMusteri.Name = "cmbMusteri";
            cmbMusteri.Size = new Size(140, 28);
            cmbMusteri.TabIndex = 0;
            cmbMusteri.Enter += cmbMusteri_Enter;
            // 
            // dgvSepet
            // 
            dgvSepet.BackgroundColor = Color.Gainsboro;
            dgvSepet.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSepet.Dock = DockStyle.Fill;
            dgvSepet.Location = new Point(300, 0);
            dgvSepet.Name = "dgvSepet";
            dgvSepet.Size = new Size(492, 431);
            dgvSepet.TabIndex = 2;
            // 
            // frmSatis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(792, 510);
            Controls.Add(dgvSepet);
            Controls.Add(pnlAlt);
            Controls.Add(pnlSol);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmSatis";
            Text = "frmSatis";
            Load += frmSatis_Load;
            pnlSol.ResumeLayout(false);
            pnlSol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUrunler).EndInit();
            pnlAlt.ResumeLayout(false);
            pnlAlt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvSepet).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSol;
        private Panel pnlAlt;
        private DataGridView dgvUrunler;
        private TextBox txtUrunAra;
        private ComboBox cmbMusteri;
        private Panel panel1;
        private Label lblToplamTutar;
        private Button btnSatisiTamamla;
        private DataGridView dgvSepet;
    }
}