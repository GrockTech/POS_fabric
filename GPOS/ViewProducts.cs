using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\GidCode\Desktop\CodeMe\GPOSDB.mdf;Integrated Security=True;Connect Timeout=30");

        /// <summary>
        /// this function display product dataset/table
        /// </summary>
        private void DisplayProducts()
        {
            Con.Open();
            string Query = "select * from ProductTbl";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
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
                    SqlCommand cmd = new SqlCommand(" delete from ProductTbl where PId=@Pkey", Con);
                    cmd.Parameters.AddWithValue("@PKey", keyMain);


                    cmd.ExecuteNonQuery();
                   MBox1.Show("Product Deleted ");
                    Con.Close();
                    DisplayProducts();
                    //eset();
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
            PnameTb.Text = ProductDGV.SelectedRows[0].Cells[1].Value.ToString();
            PcatCB.SelectedItem = ProductDGV.SelectedRows[0].Cells[2].Value.ToString();
            PriceTb.Text = ProductDGV.SelectedRows[0].Cells[3].Value.ToString();
            QtyTb.Text = ProductDGV.SelectedRows[0].Cells[4].Value.ToString();


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

            if (PnameTb.Text == "" || PcatCB.SelectedIndex == -1 || PriceTb.Text == "" || QtyTb.Text == "")
            {
                MBox1.Show("Select the product ");
            }
            else
            {
                try
                {
                    // we open db connection 
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(" Update ProductTbl set PName = @PN,Pcat=@PC,Pprice = @PP, pQty = @PQ where PId = @Pkey", Con);
                    cmd.Parameters.AddWithValue("@PN", PnameTb.Text);
                    cmd.Parameters.AddWithValue("@PC", PcatCB.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PP", PriceTb.Text);
                    cmd.Parameters.AddWithValue("@PQ", QtyTb.Text); 
                    cmd.Parameters.AddWithValue("@Pkey" , keyMain);  

                    cmd.ExecuteNonQuery();
                    MBox1.Show("Product Product Updated");
                    Con.Close();
                    DisplayProducts();
                //  Reset();
                }
                catch (Exception Ex)
                {
                    MBox1.Show(Ex.Message);
                }
            }

        }
    }
}
