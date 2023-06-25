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
        }

        private void Save_Qr_Click(object sender, EventArgs e)
        {
            Qr_Functions.Save_Qr(Qr_Functions.Get_Qr(Input_Box.Text));
        }
    }
}