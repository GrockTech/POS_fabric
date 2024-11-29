namespace GPOS
{
    partial class ViewBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewBill));
            pictureBox2 = new PictureBox();
            SellDGV = new DataGridView();
            label14 = new Label();
            label1 = new Label();
            label2 = new Label();
            cmbSort = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SellDGV).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(750, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 39);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // SellDGV
            // 
            SellDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            SellDGV.Location = new Point(14, 104);
            SellDGV.Name = "SellDGV";
            SellDGV.Size = new Size(785, 344);
            SellDGV.TabIndex = 74;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label14.Location = new Point(316, 463);
            label14.Name = "label14";
            label14.Size = new Size(153, 20);
            label14.TabIndex = 77;
            label14.Text = " Grock Tech Consult";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 34);
            label1.Name = "label1";
            label1.Size = new Size(59, 18);
            label1.TabIndex = 78;
            label1.Text = "Sales ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 65);
            label2.Name = "label2";
            label2.Size = new Size(142, 15);
            label2.TabIndex = 79;
            label2.Text = "Sort  by Payment Method";
            // 
            // cmbSort
            // 
            cmbSort.FormattingEnabled = true;
            cmbSort.Items.AddRange(new object[] { "Credit", "Cash ", "Installment" });
            cmbSort.Location = new Point(165, 57);
            cmbSort.Name = "cmbSort";
            cmbSort.Size = new Size(206, 23);
            cmbSort.TabIndex = 80;
            cmbSort.SelectedIndexChanged += cmbSort_SelectedIndexChanged;
            // 
            // ViewBill
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(811, 541);
            Controls.Add(cmbSort);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label14);
            Controls.Add(SellDGV);
            Controls.Add(pictureBox2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewBill";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewBill";
            Load += ViewBill_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)SellDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private DataGridView SellDGV;
        private Label label14;
        private Label label1;
        private Label label2;
        private ComboBox cmbSort;
    }
}