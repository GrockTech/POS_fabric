


using GPOS.Properties;
using Microsoft.VisualBasic;
using System.Data.SqlClient;
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

        //     string connection = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\GidCode\Desktop\CodeMe\GPOSDB.mdf;Integrated Security=True;Connect Timeout=30";


        // SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\GidCode\Desktop\CodeMe\actualManagement\GPOS\GPOS\GidPosDB.mdf;Integrated Security=True;Connect Timeout=30");
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-NQAIIND\SQLEXPRESS; Initial Catalog=mydb; Integrated Security = True; Connect Timeout = 30; ");


        //   //  SqlConnection Con = GetDBConnection.GetConnect();


        // SqlConnection Con = DatabaseHelper.GetConnection();
        private decimal CalculateTotalPrices()
        {
            decimal totalPrice = 0m;

            using (SqlConnection con = DatabaseHelper.GetConnection())
            {
                string query = "SELECT PPrice, PQty FROM ProductTbl";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
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
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
            this.Close();
        }


        //*************************
        public void CheckDailySales()
        {
            decimal totalSales = 0m;
#pragma warning disable CS0219 // Variable is assigned but its value is never used
            int totalQuantity = 0;
#pragma warning restore CS0219 // Variable is assigned but its value is never used
 
            using (SqlConnection con = new SqlConnection())
            {
                string query = "SELECT SUM(Amt) AS TotalSales FROM BillT WHERE CONVERT(date, BDate) = CONVERT(date, GETDATE())";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
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
        }

        public void CheckMonthlySales()
        {
            decimal totalSales = 0m;
            int totalQuantity = 0;

            using (SqlConnection con = new SqlConnection())
            {
                string query = "SELECT SUM(Amt) AS TotalSales,  FROM BillT WHERE MONTH(BDate) = MONTH(GETDATE()) AND YEAR(BDate) = YEAR(GETDATE())";

                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    Con.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
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
    }
}

