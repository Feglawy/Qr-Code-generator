using System.Windows.Forms;

namespace Qrcode_Generator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Generate_Button_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Qr_Functions.Get_Qr(Input_Box.Text);
            if (this.Width < 1100)
            {
                timer1.Enabled = true;
            }
        }

        private void Save_Qr_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(Qr_Functions.Get_Qr(Input_Box.Text));
            pictureBox1.Image = bmp;
            Qr_Functions.Save_Qr(bmp);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = Qr_Functions.Get_Qr("hi");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Size.Width < 1040)
            {
                this.Width += 100;
            }
            else
            {
                this.Width += 60;
                timer1.Enabled = false;
            }
        }
    }
}