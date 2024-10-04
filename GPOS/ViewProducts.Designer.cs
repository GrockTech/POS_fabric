﻿namespace GPOS
{
    partial class ViewProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewProducts));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label3 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            ProductDGV = new DataGridView();
            PcatCB = new ComboBox();
            button2 = new Button();
            button1 = new Button();
            QtyTb = new TextBox();
            PriceTb = new TextBox();
            label11 = new Label();
            label12 = new Label();
            PnameTb = new TextBox();
            label13 = new Label();
            label14 = new Label();
            label10 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductDGV).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(2, 2);
            label3.Name = "label3";
            label3.Size = new Size(149, 13);
            label3.TabIndex = 5;
            label3.Text = "Point of Sale Version 16.2";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(405, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(665, 44);
            panel1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(253, 9);
            label2.Name = "label2";
            label2.Size = new Size(219, 19);
            label2.TabIndex = 4;
            label2.Text = "Point of Sale Version 16.2";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(615, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(114, 45);
            label1.Name = "label1";
            label1.Size = new Size(52, 19);
            label1.TabIndex = 9;
            label1.Text = "GPOS";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(63, 31);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 39);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Yellow;
            panel3.Controls.Add(label3);
            panel3.Location = new Point(320, 13);
            panel3.Name = "panel3";
            panel3.Size = new Size(154, 18);
            panel3.TabIndex = 8;
            // 
            // ProductDGV
            // 
            dataGridViewCellStyle1.ForeColor = Color.FromArgb(255, 255, 192);
            ProductDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            ProductDGV.BackgroundColor = SystemColors.ButtonFace;
            ProductDGV.BorderStyle = BorderStyle.Fixed3D;
            ProductDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.Yellow;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            ProductDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            ProductDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductDGV.GridColor = Color.Black;
            ProductDGV.Location = new Point(63, 109);
            ProductDGV.Name = "ProductDGV";
            ProductDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            ProductDGV.ScrollBars = ScrollBars.Vertical;
            ProductDGV.Size = new Size(520, 327);
            ProductDGV.TabIndex = 10;
            ProductDGV.CellContentClick += ProductDGV_CellContentClick;
            // 
            // PcatCB
            // 
            PcatCB.FormattingEnabled = true;
            PcatCB.Items.AddRange(new object[] { "Electronics", "Bulbs ", "Chargers", "HeadPhones", "Cylinders", "Irons", "Cables", "Sockets" });
            PcatCB.Location = new Point(646, 237);
            PcatCB.Name = "PcatCB";
            PcatCB.Size = new Size(298, 23);
            PcatCB.TabIndex = 49;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(764, 400);
            button2.Name = "button2";
            button2.Padding = new Padding(5);
            button2.Size = new Size(112, 34);
            button2.TabIndex = 46;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(646, 400);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 47;
            button1.Text = "Edit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // QtyTb
            // 
            QtyTb.Location = new Point(646, 351);
            QtyTb.Name = "QtyTb";
            QtyTb.Size = new Size(298, 23);
            QtyTb.TabIndex = 43;
            // 
            // PriceTb
            // 
            PriceTb.Location = new Point(646, 295);
            PriceTb.Name = "PriceTb";
            PriceTb.Size = new Size(298, 23);
            PriceTb.TabIndex = 44;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(646, 330);
            label11.Name = "label11";
            label11.Size = new Size(73, 18);
            label11.TabIndex = 39;
            label11.Text = "Quantity";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(649, 272);
            label12.Name = "label12";
            label12.Size = new Size(109, 18);
            label12.TabIndex = 40;
            label12.Text = "Product Price";
            // 
            // PnameTb
            // 
            PnameTb.Location = new Point(646, 165);
            PnameTb.Name = "PnameTb";
            PnameTb.Size = new Size(298, 23);
            PnameTb.TabIndex = 45;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(648, 203);
            label13.Name = "label13";
            label13.Size = new Size(147, 18);
            label13.TabIndex = 41;
            label13.Text = "Product Cateogory";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(645, 141);
            label14.Name = "label14";
            label14.Size = new Size(113, 18);
            label14.TabIndex = 42;
            label14.Text = "Product Name";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(255, 128, 0);
            label10.Location = new Point(902, 416);
            label10.Name = "label10";
            label10.Size = new Size(44, 18);
            label10.TabIndex = 50;
            label10.Text = "Back";
            label10.Click += label10_Click;
            // 
            // ViewProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1073, 560);
            Controls.Add(label10);
            Controls.Add(PcatCB);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(QtyTb);
            Controls.Add(PriceTb);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(PnameTb);
            Controls.Add(label13);
            Controls.Add(label14);
            Controls.Add(ProductDGV);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewProducts";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewProducts";
            Load += ViewProducts_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ProductDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private Panel panel1;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panel3;
        private DataGridView ProductDGV;
        private ComboBox PcatCB;
        private Button button2;
        private Button button1;
        private TextBox QtyTb;
        private TextBox PriceTb;
        private Label label11;
        private Label label12;
        private TextBox PnameTb;
        private Label label13;
        private Label label14;
        private Label label10;
    }
}