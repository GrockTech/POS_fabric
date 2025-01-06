﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace GPOS
{
    public partial class ViewProducts : Form
    {
        public ViewProducts()
        {
            InitializeComponent();
            DisplayProducts();
            ProductDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductDGV.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            ProductDGV.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
        }

        private void ViewProducts_Load(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Mainmenu obj = new Mainmenu();
            obj.Show();
            this.Hide();
        }
        
        MySqlConnection Con = new MySqlConnection("server=localhost; database=fabricdb; username=root; password=;");

        private void DisplayProducts()
        {
            Con.Open();
            string Query = "select PId, PName, Pcat, color, width, Pprice, PQty from ProductTbl";

            //SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            MySqlCommand cmd = new MySqlCommand(Query, Con);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            var ds = new DataSet();
            adapter.Fill(ds);
            // we fill data grid with the acutal data in db
            ProductDGV.DataSource = ds.Tables[0];


            ProductDGV.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

            Con.Close();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (keyMain == 0)
            {
                MBox1.Show("select the product");
            }
            else
            {
                try
                {
                    // we open db connection 
                    Con.Open();
                    MySqlCommand cmd = new MySqlCommand(" delete from ProductTbl where PId=@Pkey", Con);
                    cmd.Parameters.AddWithValue("@PKey", keyMain);


                    cmd.ExecuteNonQuery();
                    MBox1.Show("Product Deleted!");
                    Con.Close();
                    DisplayProducts();
                    //eset();
                    PnameTb.Clear();
                    PriceTb.Clear();
                    QtyTb.Clear();


                }
                catch (Exception Ex)
                {
                    MBox1.Show(Ex.Message);
                }
            }

        }

        int keyMain = 0;
        private void ProductDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



            // setting data in datagrid to fit text box for edit RESPECTIVELY 
            PnameTb.Text = ProductDGV.SelectedRows[0].Cells[1].Value?.ToString();
            PcatCB.SelectedItem = ProductDGV.SelectedRows[0].Cells[2].Value?.ToString();
            PriceTb.Text = ProductDGV.SelectedRows[0].Cells[5].Value?.ToString();
            txtwidth.Text = ProductDGV.SelectedRows[0].Cells[4].Value?.ToString();
            txtfcolour.Text = ProductDGV.SelectedRows[0].Cells[3].Value?.ToString();

            QtyTb.Text = ProductDGV.SelectedRows[0].Cells[6].Value?.ToString();
     


            if (PnameTb.Text == "")
            {

                keyMain = 0;
            }
            else
            {

                keyMain = Convert.ToInt32(ProductDGV.SelectedRows[0].Cells[0].Value.ToString());

            }





        }

        private void button1_Click(object sender, EventArgs e)
        {
            //edit button
            string colour;
            //float width;
            colour = txtfcolour.Text;

            double width;
            width = double.Parse(txtwidth.Text); 
           // float width = (float)Convert.ToDouble(txtwidth.Text);
            if (PnameTb.Text == "" || PriceTb.Text == "" || QtyTb.Text == "")
            {
                MBox1.Show("Select the product or product category ");
            }
            else
            {
                try
                {
                    // we open db connection 
                    Con.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE ProductTbl SET PName = @PN, Pcat = @PC, color = @FC, width = @FW, Pprice = @PP, pQty = @PQ WHERE PId = @Pkey", Con);
                    cmd.Parameters.AddWithValue("@PN", PnameTb.Text);
                    cmd.Parameters.AddWithValue("@PC", PcatCB.SelectedItem?.ToString()); // Added null conditional operator
                    cmd.Parameters.AddWithValue("@FC", colour);
                    cmd.Parameters.AddWithValue("@FW", width);
                    cmd.Parameters.AddWithValue("@PP", PriceTb.Text);
                    cmd.Parameters.AddWithValue("@PQ", QtyTb.Text);
                    cmd.Parameters.AddWithValue("@Pkey", keyMain);



                    cmd.ExecuteNonQuery();
                    MBox1.Show("Product Updated");
                    Con.Close();
                    DisplayProducts();
                    //  Reset();
                    PnameTb.Clear();
                    PriceTb.Clear();
                    QtyTb.Clear();
                    //PcatCB.Items.Clear();
                }
                catch (Exception Ex)
                {
                    //   MBox1.Show(Ex.Message);
                    MessageBox.Show(Ex.Message.ToString());
                }
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {
            AddProducts obj = new AddProducts();
            obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ViewProducts Obj = new ViewProducts();
            Obj.Show();
            this.Close();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = search.Text.Trim();
            SearchProducts(searchTerm);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void SearchProducts(string searchTerm)
        {
            try
            {
                Con.Open();
                string Query = "SELECT * FROM ProductTbl WHERE PName LIKE @SearchTerm";
                MySqlDataAdapter adapter = new MySqlDataAdapter(Query, Con);
                adapter.SelectCommand.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                ProductDGV.DataSource = dt;
                ProductDGV.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            DisplayProducts();
            txtSearch.Text = "";
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }
    }
}
