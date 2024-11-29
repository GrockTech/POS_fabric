namespace GPOS
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            search = new TextBox();
            txtSearch = new Button();
            pictureBox3 = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ProductDGV).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            label1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(114, 45);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
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
            ProductDGV.AllowUserToAddRows = false;
            ProductDGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(255, 255, 192);
            ProductDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            ProductDGV.BackgroundColor = SystemColors.ButtonFace;
            ProductDGV.BorderStyle = BorderStyle.Fixed3D;
            ProductDGV.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Yellow;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            ProductDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            ProductDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductDGV.GridColor = Color.Black;
            ProductDGV.Location = new Point(63, 183);
            ProductDGV.Name = "ProductDGV";
            ProductDGV.ReadOnly = true;
            ProductDGV.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;
            ProductDGV.Size = new Size(520, 327);
            ProductDGV.TabIndex = 10;
            ProductDGV.CellContentClick += ProductDGV_CellContentClick;
            // 
            // PcatCB
            // 
            PcatCB.FormattingEnabled = true;
            PcatCB.Items.AddRange(new object[] { "General", "Tablet", "Syrup ", "Injection ", "Gel", "Ointment ", "Capsules", "Cream", "Herbal Mixture", "Lotion", "Balm", "Pessaries", "Antiseptic", "Condom", "Oil " });
            PcatCB.Location = new Point(646, 237);
            PcatCB.Name = "PcatCB";
            PcatCB.Size = new Size(298, 23);
            PcatCB.TabIndex = 49;
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(764, 463);
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
            button1.BackColor = Color.Green;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(646, 463);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 47;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
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
            label10.Location = new Point(902, 479);
            label10.Name = "label10";
            label10.Size = new Size(44, 18);
            label10.TabIndex = 50;
            label10.Text = "Back";
            label10.Click += label10_Click;
            // 
            // search
            // 
            search.Location = new Point(63, 135);
            search.Multiline = true;
            search.Name = "search";
            search.Size = new Size(361, 42);
            search.TabIndex = 51;
            search.TextChanged += textBox1_TextChanged;
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.Black;
            txtSearch.FlatStyle = FlatStyle.Flat;
            txtSearch.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearch.ForeColor = Color.White;
            txtSearch.Location = new Point(484, 141);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(99, 36);
            txtSearch.TabIndex = 52;
            txtSearch.Text = "Search";
            txtSearch.UseVisualStyleBackColor = false;
            txtSearch.Click += txtSearch_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(431, 138);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(43, 39);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 53;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(646, 420);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(296, 23);
            dateTimePicker1.TabIndex = 54;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(645, 399);
            label4.Name = "label4";
            label4.Size = new Size(95, 18);
            label4.TabIndex = 39;
            label4.Text = "Expiry Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.FromArgb(192, 0, 0);
            label5.Location = new Point(63, 104);
            label5.Name = "label5";
            label5.Size = new Size(160, 15);
            label5.TabIndex = 55;
            label5.Text = "Select Product before update";
            // 
            // ViewProducts
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1073, 560);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(pictureBox3);
            Controls.Add(txtSearch);
            Controls.Add(search);
            Controls.Add(label10);
            Controls.Add(PcatCB);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(QtyTb);
            Controls.Add(PriceTb);
            Controls.Add(label4);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
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
        private TextBox search;
        private Button txtSearch;
        private PictureBox pictureBox3;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private Label label5;
    }
}