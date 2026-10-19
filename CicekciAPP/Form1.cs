using System.Runtime.InteropServices;

namespace CicekciAPP
{
    public partial class Main : Form
    {
        //Formun kenarlarından tutup sürükleyerek hareket ettirmek için gerekli Windows API'ları
        [DllImport("user32.dll", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        public Main()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;//Titremeyi Önlemek İçin
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }


        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            Forms.AnaMenu frm= new Forms.AnaMenu();
            frm.Show();
            this.Hide();
        }
    }
}
