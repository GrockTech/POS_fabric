namespace GPOS
{
    partial class AddProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProducts));
            pictureBox2 = new PictureBox();
            ResetBtn = new Button();
            SaveBtn = new Button();
            QtyTb = new TextBox();
            PriceTb = new TextBox();
            label5 = new Label();
            label4 = new Label();
            PnameTb = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            PcatCB = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            txtfcolour = new TextBox();
            uploadclient = new PictureBox();
            txtwidth = new TextBox();
            label6 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)uploadclient).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(382, 5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 37;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = Color.Black;
            ResetBtn.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResetBtn.ForeColor = Color.White;
            ResetBtn.Location = new Point(219, 518);
            ResetBtn.Name = "ResetBtn";
            ResetBtn.Padding = new Padding(5);
            ResetBtn.Size = new Size(112, 34);
            ResetBtn.TabIndex = 34;
            ResetBtn.Text = "Reset";
            ResetBtn.UseVisualStyleBackColor = false;
            // 
            // SaveBtn
            // 
            SaveBtn.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveBtn.Location = new Point(101, 518);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(112, 34);
            SaveBtn.TabIndex = 35;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // QtyTb
            // 
            QtyTb.Location = new Point(63, 370);
            QtyTb.Name = "QtyTb";
            QtyTb.PlaceholderText = "Qty";
            QtyTb.Size = new Size(298, 23);
            QtyTb.TabIndex = 30;
            // 
            // PriceTb
            // 
            PriceTb.Location = new Point(63, 316);
            PriceTb.Name = "PriceTb";
            PriceTb.PlaceholderText = "Price";
            PriceTb.Size = new Size(298, 23);
            PriceTb.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(63, 349);
            label5.Name = "label5";
            label5.Size = new Size(73, 18);
            label5.TabIndex = 25;
            label5.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(63, 296);
            label4.Name = "label4";
            label4.Size = new Size(129, 18);
            label4.TabIndex = 26;
            label4.Text = "Price_Per_Yard";
            // 
            // PnameTb
            // 
            PnameTb.Location = new Point(63, 103);
            PnameTb.Name = "PnameTb";
            PnameTb.PlaceholderText = "Fabric Name";
            PnameTb.Size = new Size(298, 23);
            PnameTb.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(63, 137);
            label3.Name = "label3";
            label3.Size = new Size(95, 18);
            label3.TabIndex = 27;
            label3.Text = "Fabric Type";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(63, 82);
            label2.Name = "label2";
            label2.Size = new Size(113, 18);
            label2.TabIndex = 28;
            label2.Text = "Product Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(48, 44);
            label1.Name = "label1";
            label1.Size = new Size(98, 18);
            label1.TabIndex = 29;
            label1.Text = "Add Product";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // PcatCB
            // 
            PcatCB.FormattingEnabled = true;
            PcatCB.Items.AddRange(new object[] { "Cotton", "Polyester", "Silk", "Wool" });
            PcatCB.Location = new Point(63, 160);
            PcatCB.Name = "PcatCB";
            PcatCB.Size = new Size(298, 23);
            PcatCB.TabIndex = 38;
            PcatCB.SelectedIndexChanged += PcatCB_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(63, 410);
            label7.Name = "label7";
            label7.Size = new Size(106, 18);
            label7.TabIndex = 25;
            label7.Text = "Fabric Image";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(63, 194);
            label8.Name = "label8";
            label8.Size = new Size(108, 18);
            label8.TabIndex = 27;
            label8.Text = "Fabric Colour";
            label8.Click += label3_Click;
            // 
            // txtfcolour
            // 
            txtfcolour.Location = new Point(64, 214);
            txtfcolour.Name = "txtfcolour";
            txtfcolour.PlaceholderText = "Colour";
            txtfcolour.Size = new Size(297, 23);
            txtfcolour.TabIndex = 40;
            // 
            // uploadclient
            // 
            uploadclient.BorderStyle = BorderStyle.Fixed3D;
            uploadclient.Location = new Point(178, 410);
            uploadclient.Name = "uploadclient";
            uploadclient.Size = new Size(105, 93);
            uploadclient.SizeMode = PictureBoxSizeMode.Zoom;
            uploadclient.TabIndex = 41;
            uploadclient.TabStop = false;
            // 
            // txtwidth
            // 
            txtwidth.Location = new Point(63, 265);
            txtwidth.Name = "txtwidth";
            txtwidth.PlaceholderText = "Width";
            txtwidth.Size = new Size(298, 23);
            txtwidth.TabIndex = 42;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(64, 244);
            label6.Name = "label6";
            label6.Size = new Size(52, 18);
            label6.TabIndex = 26;
            label6.Text = "Width";
            // 
            // button1
            // 
            button1.Location = new Point(83, 447);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 43;
            button1.Text = "Browse";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // AddProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(423, 568);
            Controls.Add(button1);
            Controls.Add(txtwidth);
            Controls.Add(uploadclient);
            Controls.Add(txtfcolour);
            Controls.Add(PcatCB);
            Controls.Add(pictureBox2);
            Controls.Add(ResetBtn);
            Controls.Add(SaveBtn);
            Controls.Add(QtyTb);
            Controls.Add(PriceTb);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(PnameTb);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddProducts";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)uploadclient).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Button ResetBtn;
        private Button SaveBtn;
        private TextBox QtyTb;
        private TextBox PriceTb;
        private Label label5;
        private Label label4;
        private TextBox PnameTb;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private ComboBox PcatCB;
        private Label label7;
        private Label label8;
        private TextBox txtfcolour;
        private PictureBox uploadclient;
        private TextBox txtwidth;
        private Label label6;
        private Button button1;
    }
}