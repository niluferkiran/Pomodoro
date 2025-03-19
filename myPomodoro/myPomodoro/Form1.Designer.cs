namespace myPomodoro
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
            btnDuraklat = new Button();
            btnBaslat = new Button();
            btnSifirla = new Button();
            lblSure = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // btnDuraklat
            // 
            btnDuraklat.Location = new Point(326, 365);
            btnDuraklat.Name = "btnDuraklat";
            btnDuraklat.Size = new Size(68, 54);
            btnDuraklat.TabIndex = 0;
            btnDuraklat.Text = "Dur";
            btnDuraklat.UseVisualStyleBackColor = true;
            btnDuraklat.Click += btnDuraklat_Click;
            // 
            // btnBaslat
            // 
            btnBaslat.Location = new Point(426, 365);
            btnBaslat.Name = "btnBaslat";
            btnBaslat.Size = new Size(68, 54);
            btnBaslat.TabIndex = 1;
            btnBaslat.Text = "Başla";
            btnBaslat.UseVisualStyleBackColor = true;
            btnBaslat.Click += btnBaslat_Click;
            // 
            // btnSifirla
            // 
            btnSifirla.Location = new Point(527, 365);
            btnSifirla.Name = "btnSifirla";
            btnSifirla.Size = new Size(68, 54);
            btnSifirla.TabIndex = 2;
            btnSifirla.Text = "Sıfırla";
            btnSifirla.UseVisualStyleBackColor = true;
            btnSifirla.Click += btnSifirla_Click;
            // 
            // lblSure
            // 
            lblSure.Location = new Point(326, 93);
            lblSure.Name = "lblSure";
            lblSure.Size = new Size(269, 191);
            lblSure.TabIndex = 3;
            // 
            // timer1
            // 
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(997, 543);
            Controls.Add(lblSure);
            Controls.Add(btnSifirla);
            Controls.Add(btnBaslat);
            Controls.Add(btnDuraklat);
            Name = "Form1";
            Text = "MyPomodoro";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnDuraklat;
        private Button btnBaslat;
        private Button btnSifirla;
        private Label lblSure;
        private System.Windows.Forms.Timer timer1;
    }
}