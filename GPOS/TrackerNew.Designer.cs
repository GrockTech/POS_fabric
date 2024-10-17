namespace GPOS
{
    partial class TrackerNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrackerNew));
            txtSerivce = new TextBox();
            label1 = new Label();
            txtCost = new TextBox();
            label2 = new Label();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label3 = new Label();
            txtDateFrom = new DateTimePicker();
            label4 = new Label();
            txtDateTo = new DateTimePicker();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtSerivce
            // 
            txtSerivce.Location = new Point(35, 100);
            txtSerivce.Multiline = true;
            txtSerivce.Name = "txtSerivce";
            txtSerivce.Size = new Size(211, 38);
            txtSerivce.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 76);
            label1.Name = "label1";
            label1.Size = new Size(105, 21);
            label1.TabIndex = 2;
            label1.Text = "Item/Service";
            // 
            // txtCost
            // 
            txtCost.Location = new Point(285, 100);
            txtCost.Multiline = true;
            txtCost.Name = "txtCost";
            txtCost.Size = new Size(137, 38);
            txtCost.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.FlatStyle = FlatStyle.System;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(285, 76);
            label2.Name = "label2";
            label2.Size = new Size(70, 21);
            label2.TabIndex = 2;
            label2.Text = "Cost GH";
            // 
            // button1
            // 
            button1.BackColor = Color.Black;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Coral;
            button1.Location = new Point(635, 100);
            button1.Name = "button1";
            button1.Size = new Size(114, 38);
            button1.TabIndex = 4;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(443, 100);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(168, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.FlatStyle = FlatStyle.System;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(35, 172);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 2;
            label3.Text = "From:";
            // 
            // txtDateFrom
            // 
            txtDateFrom.Format = DateTimePickerFormat.Short;
            txtDateFrom.Location = new Point(108, 171);
            txtDateFrom.Name = "txtDateFrom";
            txtDateFrom.Size = new Size(168, 23);
            txtDateFrom.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.FlatStyle = FlatStyle.System;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(302, 173);
            label4.Name = "label4";
            label4.Size = new Size(31, 21);
            label4.TabIndex = 2;
            label4.Text = "To:";
            // 
            // txtDateTo
            // 
            txtDateTo.Format = DateTimePickerFormat.Short;
            txtDateTo.Location = new Point(348, 169);
            txtDateTo.Name = "txtDateTo";
            txtDateTo.Size = new Size(168, 23);
            txtDateTo.TabIndex = 5;
            // 
            // button2
            // 
            button2.BackColor = Color.Black;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Coral;
            button2.Location = new Point(635, 156);
            button2.Name = "button2";
            button2.Size = new Size(114, 38);
            button2.TabIndex = 4;
            button2.Text = "Generate";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 211);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(481, 298);
            dataGridView1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(734, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(41, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Coral;
            label5.Location = new Point(266, 12);
            label5.Name = "label5";
            label5.Size = new Size(250, 37);
            label5.TabIndex = 8;
            label5.Text = "EXPENSE TRACKER";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Green;
            label6.Location = new Point(565, 445);
            label6.Name = "label6";
            label6.Size = new Size(214, 17);
            label6.TabIndex = 9;
            label6.Text = "Total Expenses for Selected Range";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(565, 475);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 10;
            // 
            // button3
            // 
            button3.BackColor = Color.Black;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Coral;
            button3.Location = new Point(635, 338);
            button3.Name = "button3";
            button3.Size = new Size(117, 39);
            button3.TabIndex = 11;
            button3.Text = "Save";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // TrackerNew
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(790, 539);
            Controls.Add(button3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(dataGridView1);
            Controls.Add(txtDateTo);
            Controls.Add(txtDateFrom);
            Controls.Add(dateTimePicker1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtCost);
            Controls.Add(txtSerivce);
            FormBorderStyle = FormBorderStyle.None;
            Name = "TrackerNew";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrackerNew";
            Load += TrackerNew_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtSerivce;
        private Label label1;
        private TextBox txtCost;
        private Label label2;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Label label3;
        private DateTimePicker txtDateFrom;
        private Label label4;
        private DateTimePicker txtDateTo;
        private Button button2;
        private DataGridView dataGridView1;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button button3;
    }
}