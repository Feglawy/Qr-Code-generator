﻿namespace Qrcode_Generator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Generate_Button = new Button();
            Input_Box = new TextBox();
            pictureBox1 = new PictureBox();
            Save_Qr = new Button();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Generate_Button
            // 
            Generate_Button.Location = new Point(41, 142);
            Generate_Button.Name = "Generate_Button";
            Generate_Button.Size = new Size(145, 73);
            Generate_Button.TabIndex = 0;
            Generate_Button.Text = "Generate QR";
            Generate_Button.UseVisualStyleBackColor = true;
            Generate_Button.Click += Generate_Button_Click;
            // 
            // Input_Box
            // 
            Input_Box.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            Input_Box.Location = new Point(12, 63);
            Input_Box.Multiline = true;
            Input_Box.Name = "Input_Box";
            Input_Box.Size = new Size(403, 73);
            Input_Box.TabIndex = 1;
            Input_Box.TextAlign = HorizontalAlignment.Center;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(421, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(646, 446);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Save_Qr
            // 
            Save_Qr.Location = new Point(237, 142);
            Save_Qr.Name = "Save_Qr";
            Save_Qr.Size = new Size(145, 73);
            Save_Qr.TabIndex = 3;
            Save_Qr.Text = "Save QR";
            Save_Qr.UseVisualStyleBackColor = true;
            Save_Qr.Click += Save_Qr_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 35);
            label1.Name = "label1";
            label1.Size = new Size(127, 21);
            label1.TabIndex = 4;
            label1.Text = "Enter your text ";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.Location = new Point(421, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(2, 449);
            panel1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1079, 455);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(Save_Qr);
            Controls.Add(pictureBox1);
            Controls.Add(Input_Box);
            Controls.Add(Generate_Button);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Generate_Button;
        private TextBox Input_Box;
        private PictureBox pictureBox1;
        private Button Save_Qr;
        private Label label1;
        private Panel panel1;
    }
}