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
            pictureBox1 = new PictureBox();
            label3 = new Label();
            UsernameTB = new TextBox();
            PasswordTB = new TextBox();
            label4 = new Label();
            LoginBtn = new Button();
            label5 = new Label();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            pictureBox4 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
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
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-26, -61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 222);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
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
            // UsernameTB
            // 
            UsernameTB.Location = new Point(50, 222);
            UsernameTB.Name = "UsernameTB";
            UsernameTB.Size = new Size(315, 23);
            UsernameTB.TabIndex = 29;
            // 
            // PasswordTB
            // 
            PasswordTB.Location = new Point(50, 304);
            PasswordTB.Name = "PasswordTB";
            PasswordTB.Size = new Size(315, 23);
            PasswordTB.TabIndex = 31;
            PasswordTB.UseSystemPasswordChar = true;
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
            // LoginBtn
            // 
            LoginBtn.BackColor = Color.FromArgb(0, 64, 0);
            LoginBtn.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LoginBtn.ForeColor = Color.Yellow;
            LoginBtn.Location = new Point(134, 358);
            LoginBtn.Name = "LoginBtn";
            LoginBtn.Size = new Size(139, 38);
            LoginBtn.TabIndex = 32;
            LoginBtn.Text = "LOGIN";
            LoginBtn.UseVisualStyleBackColor = false;
            LoginBtn.Click += LoginBtn_Click;
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
            label5.Click += label5_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(152, 48);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(119, 138);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 34;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(158, 16);
            label1.Name = "label1";
            label1.Size = new Size(107, 18);
            label1.TabIndex = 30;
            label1.Text = "Point of Sale ";
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(181, 87);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(61, 54);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 35;
            pictureBox4.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(411, 450);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(label5);
            Controls.Add(LoginBtn);
            Controls.Add(PasswordTB);
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(UsernameTB);
            Controls.Add(label3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Label label3;
        private TextBox UsernameTB;
        private TextBox PasswordTB;
        private Label label4;
        private Button LoginBtn;
        private Label label5;
        private PictureBox pictureBox3;
        private Label label1;
        private PictureBox pictureBox4;
    }
}