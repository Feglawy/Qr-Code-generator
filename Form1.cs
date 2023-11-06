using System.Drawing;
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
            Bitmap bmp = new Bitmap(Qr_Functions.Get_Qr(Input_Box.Text));
            pictureBox1.Image = bmp;

            pictureBox1.Width = bmp.Width;
            pictureBox1.Height = bmp.Height;

            int new_height = pictureBox1.Height + 130;
            int new_width = pictureBox1.Width + 440;

            pictureBox1.Location = new Point(900 / 2, 40);

            if (this.Width < new_width)
            {
                Width_increase_timer.Enabled = true;
            }

            if (this.Height < new_height)
            {
                Hight_increase_timer.Enabled = true;
            }

            if (this.Width > new_width)
            {
                Width_decrease_timer.Enabled = true;
            }

            if (this.Height > new_height)
            {
                Hight_decrease_timer.Enabled = true;
            }

        }

        private void Save_Qr_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(Qr_Functions.Get_Qr(Input_Box.Text));
            pictureBox1.Image = bmp;
            Qr_Functions.Save_Qr(bmp);
        }


        private void Width_increase_timer_Tick(object sender, EventArgs e)
        {
            if (this.Size.Width < pictureBox1.Width + 440)
            {
                this.Width += 100;
            }
            else
            {
                this.Width += 60;
                Width_increase_timer.Enabled = false;
            }
        }
        private void Hight_increase_timer_Tick(object sender, EventArgs e)
        {

            if (this.Size.Height < pictureBox1.Height + 60)
            {
                this.Height += 60;
            }

            else
            {
                this.Height += 40;
                Hight_increase_timer.Enabled = false;
            }
        }

        private void Width_decrease_timer_Tick(object sender, EventArgs e)
        {
            if (this.Size.Width > pictureBox1.Width + 600)
            {
                this.Width -= 60;
            }
            else
            {
                Width_decrease_timer.Enabled = false;
            }
        }

        private void Hight_decrease_timer_Tick(object sender, EventArgs e)
        {
            if (this.Size.Height > 580)
            {
                this.Height -= 60;
            }
            else
            {
                Hight_decrease_timer.Enabled = false;
            }
        }
    }
}