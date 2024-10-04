


using GPOS.Properties;
using Microsoft.VisualBasic;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
//using GPOS.Utilities;

namespace GPOS
{
    public partial class Mainmenu : Form
    {
        public Mainmenu()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
        }

        private void label10_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
            AddProducts obj = new AddProducts();
            obj.Show();
            obj.TopMost = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            SuppliersAdd obj = new SuppliersAdd();
            obj.Show();
            obj.TopMost = true;
        }

        private void label9_Click(object sender, EventArgs e)
        {
            AddCustomer obj = new AddCustomer();
            obj.Show();
            obj.TopMost = true;
        }

        private void label5_Click(object sender, EventArgs e)
        {
            ViewProducts obj = new ViewProducts();
            obj.Show();
            obj.TopMost = true;
        }

        private void label8_Click(object sender, EventArgs e)
        {
            ViewCustomers obj = new ViewCustomers();
            obj.Show();
            obj.TopMost = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Viewsuppliers obj = new Viewsuppliers();
            obj.Show();
            //obj.TopMost = true;
            Mainmenu wantoHide = new Mainmenu();
            obj.TopMost = true;
            wantoHide.Hide();
        }


        MySqlConnection Con = new MySqlConnection("server=localhost; database=posdb; username=root; password=;");

        private decimal CalculateTotalPrices()
        {
            decimal totalPrice = 0m;

            using (MySqlConnection con = new MySqlConnection("server=localhost; database=posdb; username=root; password=;"))
            {
                string query = "SELECT PPrice, PQty FROM ProductTbl";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            decimal price = Convert.ToDecimal(reader["PPrice"]);
                            int quantity = Convert.ToInt32(reader["PQty"]);
                            totalPrice += price * quantity;
                        }
                    }
                }
            }

            return totalPrice;
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            decimal mainTotal = CalculateTotalPrices();
            MessageBox.Show($"Store Value GH¢: {mainTotal}", "Store Values");
           //Box1.Show($"Store Value GH¢: {mainTotal}", "Store Values");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Login obj = new Login();
            //obj.Show();
            this.Close();
            //this.Close();
        }


        //*************************
        public void CheckDailySales()
        {
            decimal totalSales = 0m;
#pragma warning disable CS0219 // Variable is assigned but its value is never used
            int totalQuantity = 0;
#pragma warning restore CS0219 // Variable is assigned but its value is never used

            using (MySqlConnection con = new MySqlConnection("server=localhost; database=posdb; username=root; password=;"))
            {
                string query = "SELECT SUM(Amt) AS TotalSales FROM BillT WHERE DATE(BDate) =  CURDATE()";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            totalSales = reader["TotalSales"] != DBNull.Value ? Convert.ToDecimal(reader["TotalSales"]) : 0m;
                            //   totalQuantity = reader["TotalQuantity"] != DBNull.Value ? Convert.ToInt32(reader["TotalQuantity"]) : 0;
                        }
                    }
                }
            }

            MessageBox.Show($"Total Sales for Today: GH¢ {totalSales:C}\n", "Daily Sales", MessageBoxButtons.OK, MessageBoxIcon.Information);
         // MBox1.Show("Total Sales for Today: GHS '"++"');

        }

        public void CheckMonthlySales()
        {
            decimal totalSales = 0m;
            int totalQuantity = 0;

            using (MySqlConnection con = new MySqlConnection("server=localhost; database=posdb; username=root; password=;"))
            {
                string query = "SELECT SUM(Amt) AS TotalSales,  FROM BillT WHERE MONTH(BDate) = MONTH(GETDATE()) AND YEAR(BDate) = YEAR(GETDATE())";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    Con.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            totalSales = reader["TotalSales"] != DBNull.Value ? Convert.ToDecimal(reader["TotalSales"]) : 0m;
                            totalQuantity = reader["TotalQuantity"] != DBNull.Value ? Convert.ToInt32(reader["TotalQuantity"]) : 0;
                        }
                    }
                }
            }

            MessageBox.Show($"Total Sales for This Month: {totalSales:C}\nTotal Quantity Sold: {totalQuantity}", "Monthly Sales", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckDailySales();
        }

        private void btnMonthlySales_Click(object sender, EventArgs e)
        {

        }

        private void Mainmenu_Load(object sender, EventArgs e)
        {

        }
    }
}

