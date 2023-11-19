namespace Qrcode_Generator
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Generate_Button = new Button();
            Input_Box = new TextBox();
            pictureBox1 = new PictureBox();
            Save_Qr = new Button();
            label1 = new Label();
            Width_increase_timer = new System.Windows.Forms.Timer(components);
            Hight_increase_timer = new System.Windows.Forms.Timer(components);
            Hight_decrease_timer = new System.Windows.Forms.Timer(components);
            Width_decrease_timer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Generate_Button
            // 
            Generate_Button.Location = new Point(140, 192);
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
            Input_Box.KeyUp += Input_Box_KeyUp;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(421, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(669, 526);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Save_Qr
            // 
            Save_Qr.Location = new Point(140, 291);
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
            // Width_increase_timer
            // 
            Width_increase_timer.Interval = 10;
            Width_increase_timer.Tick += Width_increase_timer_Tick;
            // 
            // Hight_increase_timer
            // 
            Hight_increase_timer.Interval = 10;
            Hight_increase_timer.Tick += Hight_increase_timer_Tick;
            // 
            // Hight_decrease_timer
            // 
            Hight_decrease_timer.Interval = 10;
            Hight_decrease_timer.Tick += Hight_decrease_timer_Tick;
            // 
            // Width_decrease_timer
            // 
            Width_decrease_timer.Interval = 10;
            Width_decrease_timer.Tick += Width_decrease_timer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 540);
            Controls.Add(label1);
            Controls.Add(Save_Qr);
            Controls.Add(pictureBox1);
            Controls.Add(Input_Box);
            Controls.Add(Generate_Button);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "QR Code";
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
        private System.Windows.Forms.Timer Width_increase_timer;
        private System.Windows.Forms.Timer Hight_increase_timer;
        private System.Windows.Forms.Timer Hight_decrease_timer;
        private System.Windows.Forms.Timer Width_decrease_timer;
    }
}