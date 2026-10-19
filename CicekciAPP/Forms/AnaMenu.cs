using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace CicekciAPP.Forms
{
    public partial class AnaMenu : Form
    {
        //Formun kenarlarından tutup sürükleyerek hareket ettirmek için gerekli Windows API'ları
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        public AnaMenu()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;//Titremeyi Önlemek İçin
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void AnaMenu_Load(object sender, EventArgs e)
        {

        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlMenu_Paint(object sender, PaintEventArgs e)
        {

        }
        private Form activeForm = null;
        private void openChildForm(Form childForm, string baslik)
        {
            // Eğer halihazırda açık bir form varsa onu kapat
            if (activeForm != null)
                activeForm.Close();

            activeForm = childForm;

            // Formun "üst seviye" bir pencere olmadığını, bir alt bileşen olduğunu belirtiyoruz
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None; // Çerçeveyi kaldır
            childForm.Dock = DockStyle.Fill; // Paneli tamamen kapla

            pnlMain.Controls.Add(childForm); // Panelin içine ekle
            pnlMain.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
            lblBaslik.Text = baslik;
        }

        private void btnMusteriYonetimi_Click(object sender, EventArgs e)
        {
            openChildForm(new frmMusteri(), "Müşteri Yönetimi");
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDashboard(), "Genel");
        }

        private void btnUrunYonetimi_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUrun(), "Ürün Yönetimi");
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSatis(), "Satış Yap");
        }

        private void btnSatisGecmisi_Click(object sender, EventArgs e)
        {
            openChildForm(new frmSatisGecmisi(), "Satış Geçmişi");
        }

        private void btnStokIslemleri_Click(object sender, EventArgs e)
        {
            openChildForm(new frmStokIslemleri(), "Stok İşlemleri");
        }

        private void btnRaporlar_Click(object sender, EventArgs e)
        {
            openChildForm(new frmRaporlar(), "Raporlar");
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAyarlar(), "Ayarlar");
        }
    }
}
