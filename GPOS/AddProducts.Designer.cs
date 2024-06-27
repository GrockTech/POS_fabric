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
            label6 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(178, 468);
            label6.Name = "label6";
            label6.Size = new Size(87, 18);
            label6.TabIndex = 36;
            label6.Text = "GrockTech";
            // 
            // ResetBtn
            // 
            ResetBtn.BackColor = Color.Black;
            ResetBtn.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ResetBtn.ForeColor = Color.White;
            ResetBtn.Location = new Point(223, 384);
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
            SaveBtn.Location = new Point(105, 384);
            SaveBtn.Name = "SaveBtn";
            SaveBtn.Size = new Size(112, 34);
            SaveBtn.TabIndex = 35;
            SaveBtn.Text = "Save";
            SaveBtn.UseVisualStyleBackColor = true;
            SaveBtn.Click += SaveBtn_Click;
            // 
            // QtyTb
            // 
            QtyTb.Location = new Point(70, 320);
            QtyTb.Name = "QtyTb";
            QtyTb.Size = new Size(298, 23);
            QtyTb.TabIndex = 30;
            // 
            // PriceTb
            // 
            PriceTb.Location = new Point(70, 259);
            PriceTb.Name = "PriceTb";
            PriceTb.Size = new Size(298, 23);
            PriceTb.TabIndex = 31;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(70, 299);
            label5.Name = "label5";
            label5.Size = new Size(73, 18);
            label5.TabIndex = 25;
            label5.Text = "Quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(70, 238);
            label4.Name = "label4";
            label4.Size = new Size(109, 18);
            label4.TabIndex = 26;
            label4.Text = "Product Price";
            // 
            // PnameTb
            // 
            PnameTb.Location = new Point(70, 138);
            PnameTb.Name = "PnameTb";
            PnameTb.Size = new Size(298, 23);
            PnameTb.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(70, 177);
            label3.Name = "label3";
            label3.Size = new Size(147, 18);
            label3.TabIndex = 27;
            label3.Text = "Product Cateogory";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(70, 117);
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
            PcatCB.Items.AddRange(new object[] { "Electronics", "Bulbs ", "Chargers", "HeadPhones", "Cylinders", "Irons", "Cables", "Sockets", "" });
            PcatCB.Location = new Point(70, 202);
            PcatCB.Name = "PcatCB";
            PcatCB.Size = new Size(298, 23);
            PcatCB.TabIndex = 38;
            PcatCB.SelectedIndexChanged += PcatCB_SelectedIndexChanged;
            // 
            // AddProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(423, 512);
            Controls.Add(PcatCB);
            Controls.Add(pictureBox2);
            Controls.Add(label6);
            Controls.Add(ResetBtn);
            Controls.Add(SaveBtn);
            Controls.Add(QtyTb);
            Controls.Add(PriceTb);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(PnameTb);
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
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private Label label6;
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
    }
}