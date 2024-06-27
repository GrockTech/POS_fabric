namespace GPOS
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label4 = new Label();
            button1 = new Button();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(372, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 26;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(50, 26);
            label1.Name = "label1";
            label1.Size = new Size(111, 18);
            label1.TabIndex = 25;
            label1.Text = "Add Suppliers";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(8, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(172, 127);
            label2.Name = "label2";
            label2.Size = new Size(44, 18);
            label2.TabIndex = 27;
            label2.Text = "Logo";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(50, 191);
            label3.Name = "label3";
            label3.Size = new Size(90, 18);
            label3.TabIndex = 28;
            label3.Text = "User Name";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(50, 222);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(315, 23);
            textBox1.TabIndex = 29;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(50, 304);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(315, 23);
            textBox2.TabIndex = 31;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(50, 273);
            label4.Name = "label4";
            label4.Size = new Size(81, 18);
            label4.TabIndex = 30;
            label4.Text = "Password";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 64, 0);
            button1.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Yellow;
            button1.Location = new Point(134, 358);
            button1.Name = "button1";
            button1.Size = new Size(139, 38);
            button1.TabIndex = 32;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(138, 412);
            label5.Name = "label5";
            label5.Size = new Size(134, 18);
            label5.TabIndex = 33;
            label5.Text = "Continue as User";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(411, 450);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label4;
        private Button button1;
        private Label label5;
    }
}