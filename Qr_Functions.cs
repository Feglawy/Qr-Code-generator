using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QRCoder;

namespace Qrcode_Generator
{
    internal class Qr_Functions
    {
        public static Bitmap Get_Qr(string text)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(8);
            return qrCodeImage;
        }

        public static void Save_Qr(Bitmap qrcode)
        {

            // Create a SaveFileDialog object.
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            
            // Set the default file name.
            saveFileDialog.FileName = "Qr.png";

            // Set the filter to only show bitmap files.
            saveFileDialog.Filter = "Bitmap Files (*.bmp)|*.png";

            // Show the save as dialog.
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Save the bitmap to the specified file.
                qrcode.Save(saveFileDialog.FileName);
            }
        }
    }
}
