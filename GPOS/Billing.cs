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
using MySql.Data.MySqlClient;
using Mysqlx.Resultset;

namespace GPOS
{
    public partial class Billing : Form
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public Billing()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            InitializeComponent();
            DisplayProducts();
            CheckDailySales();
            CheckMonthlySales();
            //getCustomer();
            //GetCusName();
            ProductsDVG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductsDVG.AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan;
            ProductsDVG.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
        }


        public void CheckDailySales()
        {
            decimal totalSales = 0m;
#pragma warning disable CS0219 // Variable is assigned but its value is never used
            int totalQuantity = 0;
#pragma warning restore CS0219 // Variable is assigned but its value is never used


            ////
            ///



            using (MySqlConnection con = new MySqlConnection("server=localhost; database=fabricdb; username=root; password=;"))
            {
                string query = "SELECT SUM(Amt) AS TotalSales FROM BillT WHERE DATE(BDate) =  CURDATE()";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {

                    //con.Open();
                    con.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            totalSales = reader["TotalSales"] != DBNull.Value ? Convert.ToDecimal(reader["TotalSales"]) : 0m;
                            //   textBox1.Text = totalSales.ToString("N2");
                            textBox2.Text = "GHS" + " " + totalSales.ToString("N2");
                            //   totalQuantity = reader["TotalQuantity"] != DBNull.Value ? Convert.ToInt32(reader["TotalQuantity"]) : 0;
                        }
                    }
                }
            }



        }
        private void CheckMonthlySales()
        {
            decimal totalSales = 0m;
            int totalQuantity = 0;

            using (MySqlConnection con = new MySqlConnection("server=localhost; database=fabricdb; username=root; password=;"))
            {
                string query = "SELECT SUM(Amt) AS TotalSales FROM BillT WHERE MONTH(BDate) = MONTH(NOW()) AND YEAR(BDate) = YEAR(NOW())";

                using (MySqlCommand cmd = new MySqlCommand(query, con))
                {
                    con.Open();

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            totalSales = reader["TotalSales"] != DBNull.Value ? Convert.ToDecimal(reader["TotalSales"]) : 0m;
                            // totalQuantity = reader["TotalQuantity"] != DBNull.Value ? Convert.ToInt32(reader["TotalQuantity"]) : 0;
                            // textBox1.Text  + "GHS" + totalSales.ToString("N2");
                            textBox1.Text = "GHS" + " " + totalSales.ToString("N2");
                        }
                    }
                }
            }

            //MessageBox.Show($"Total Sales for This Month: {totalSales:C}\nTotal Quantity Sold: {totalQuantity}", "Monthly Sales", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void label14_Click(object sender, EventArgs e)
        {

        }
        //string CustomerName;
        private void SupName_TextChanged(object sender, EventArgs e)
        {
            getCustomer();
        }
        string productName;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SupAdd_TextChanged(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        //search production btn

        private void button3_Click(object sender, EventArgs e)
        {
            string searchTerm = Search.Text.Trim();
            SearchProducts(searchTerm);
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
                ProductsDVG.DataSource = dt;
                //   ProductsDVG.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
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

        // Example event handler for a search button or search box text change




        private void label11_Click(object sender, EventArgs e)
        {

        }



        //SqlConnection Con = MyDBConnection.GetConnected();


        //billing view grid 
        MySqlConnection Con = new MySqlConnection("server=localhost; database=fabricdb; username=root; password=;");

        private void DisplayProducts()

        {
            Con.Open();
            string Query = "select PId, PName, Pcat, color, width, Pprice, PQty from ProductTbl";
            MySqlDataAdapter adapter = new MySqlDataAdapter(Query, Con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            // we fill data grid with the acutal data in db
            ProductsDVG.DataSource = ds.Tables[0];


            ProductsDVG.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

            Con.Close();

        }
        int keyMain = 0;
        string PnameTb;
        //PStock is tracking the remaining stock
        float Pprice;
        int PStock;
        float total;
        int n = 0;

        private void Reset()
        {
            PnameTb = "";
            Quantity.Text = "";
            keyMain = 0;


        }
        private void Del()
        {
            SubTotal.Text = "";
            VATtb.Text = "";
            discountTb.Text = "";
            //  SubTotal = 0
            // Subtotal = Convert.ToInt32(Quantity.Text) * Pprice;
        }


        private void getCustomer()
        {
            Con.Open();
            MySqlCommand cmd = new MySqlCommand("Select CusId from CustomerTbl", Con);
            MySqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("CusId", typeof(int));
            dt.Load(rdr);
            CusIDCB.ValueMember = "CusId";
            CusIDCB.DataSource = dt;


            Con.Close();
        }
        //int total = 0;
        private void AddBtn_Click(object sender, EventArgs e)
        {
            {
                // Check if no product is selected
                if (keyMain == 0)
                {
                    // Show a message box prompting the user to select a product
                    MBox1.Show("Select A Product");
                }
                else if (Quantity.Text == "")
                {
                    MBox1.Show("Enter the quantity");
                }
                else if (Convert.ToInt32(Quantity.Text) > PStock)
                {
                    MBox1.Show("No Enough Stock");
                }
                else
                {
                    // Calculate the subtotal for the selected product
                    float Subtotal = Convert.ToInt32(Quantity.Text) * Pprice;
                    total = total + Subtotal;
                    //    
                    //double Subtotal = Convert.ToInt32(Quantity.Text) * Pprice;
                    //total = total + (float)Subtotal;


                    // Create a new row for the DataGridView
                    DataGridViewRow newRow = new DataGridViewRow();

                    // Initialize the new row with the appropriate number of cells for the SupplierDGV
                    newRow.CreateCells(BillDGV);

                    // Set the value of the first cell to the variable 'n'
                    // This might be an index or counter, but its definition is not provided in this snippet
                    newRow.Cells[0].Value = n;
                    // Set the value of the second cell to the product name from the PnameTb TextBox
                    newRow.Cells[1].Value = PnameTb;

                    // Set the value of the third cell to the quantity from the Quantity TextBox
                    newRow.Cells[2].Value = Quantity.Text;

                    // Set the value of the fourth cell to the product price (Pprice)
                    newRow.Cells[3].Value = Pprice;

                    // Set the value of the fifth cell to the calculated subtotal
                    newRow.Cells[4].Value = Subtotal;
                    ResetButtonColor();
                    // Add the new row to the SupplierDGV DataGridView
                    BillDGV.Rows.Add(newRow);
                    SubTotal.Text = "" + total;
                    UpdateQuantity();
                    n++;
                    Reset();
                }
            }

        }


        private Image GetCustomerPhoto(int PId)
        {
            Image customerImage = null;
            string query = "SELECT p_image FROM producttbl WHERE PId = @id";

            using (MySqlConnection conn = new MySqlConnection("server=localhost; database=fabricdb; username=root; password=;"))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", PId);

                        // Execute the query and get the photo as a byte array
                        object result = cmd.ExecuteScalar();  // Returns the first column of the first row

                        if (result != null && result != DBNull.Value)
                        {
                            byte[] photoData = (byte[])result;

                            if (photoData.Length > 0) // Ensure there's data
                            {
                                using (MemoryStream ms = new MemoryStream(photoData))
                                {
                                    customerImage = Image.FromStream(ms);
                                }
                            }
                            else
                            {
                                MessageBox.Show("No image data found for customer ID: " + PId);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No result found for customer ID: " + PId);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("General error: " + ex.ToString());
                }
            }

            return customerImage;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // setting/getting  data in datagrid to fit text box for edit RESPECTIVELY 
            //if (customerDataGrid.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            //SelectedRows.Count > 0 && ProductsDVG.SelectedRows[0].Cells[1].Value
            int product_id;
            string color;
            ///  product_id = ProductsDVG.SelectedRows[0].Cells[1].Value.ToString();
            if (ProductsDVG.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
#pragma warning disable CS8601 // Possible null reference assignment.
                PnameTb = ProductsDVG.SelectedRows[0].Cells[1].Value.ToString();

#pragma  
#pragma warning restore CS8601 // Possible null reference assignment.
            }
            else
            {
                // Handle the case where no row is selected or the cell value is null
                MessageBox.Show("Please select a valid row with a valid product name.");
                PnameTb = string.Empty; // or some other default value
            }


            //    txtwidth.Text = ProductsDGV.SelectedRows[0].Cells[4].Value?.ToString();
            //  txtfcolour.Text = ProductsDGV.SelectedRows[0].Cells[3].Value?.ToString();


            //PnameTb = ProductsDVG.SelectedRows[0].Cells[1].Value.ToString();
            //PcatCB.SelectedItem = ProductDGV.SelectedRows[0].Cells[2].Value.ToString();
            Pprice = Convert.ToSingle(ProductsDVG.SelectedRows[0].Cells[5].Value.ToString());
            PStock = Convert.ToInt32(ProductsDVG.SelectedRows[0].Cells[6].Value.ToString());
            product_id = Convert.ToInt32(ProductsDVG.SelectedRows[0].Cells[0].Value.ToString());


            if (PnameTb == "")
            {

                keyMain = 0;
            }
            else
            {

                keyMain = Convert.ToInt32(ProductsDVG.SelectedRows[0].Cells[0].Value.ToString());
                AddBtn.BackColor = Color.ForestGreen;
            }

            Image clientphoto = GetCustomerPhoto(product_id);
            if (clientphoto != null)
            {
                pictureBox3.Image = clientphoto;
            }

        }
        private void ResetButtonColor()
        {
            AddBtn.BackColor = Color.Teal;
        }// Reset to default button color }
        private void UpdateQuantity()
        {
            int newQty = PStock - Convert.ToInt32(Quantity.Text);
            try
            {
                // we open db connection 
                Con.Open();
                MySqlCommand cmd = new MySqlCommand(" Update ProductTbl set PQty = @PQ  where PId = @Pkey", Con);

                cmd.Parameters.AddWithValue("@PQ", newQty);
                cmd.Parameters.AddWithValue("@Pkey", keyMain);

                cmd.ExecuteNonQuery();
                //MBox1.Show("Supplier Detail Updated");
                Con.Close();
                DisplayProducts();
                //  Reset();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            InsertBill();
            CheckDailySales();
            CheckMonthlySales();
            BillDGV.Rows.Clear();
            // int zero = 0;
            total = 0;
            SubTotal.Text = "";
            GrdTotal.Text = "";


            if (bflag == 1)
            {
                // Set the paper size for printing
                printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("pprnm", 285, 600);

                // Debugging statement before showing the print preview dialog
                Console.WriteLine("Showing print preview dialog...");
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                {
                    // Debugging statement before printing
                    Console.WriteLine("Print preview OK clicked, starting print...");
                    printDocument1.Print();
                    CusIDCB.SelectedIndex = -1;
                    CusNameCB.Text = "";
                    Del();


                }
            }

            pictureBox3.Image = null;
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Login Obj = new Login();
            Obj.Show();
            this.Hide();

        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            DisplayProducts();
            Search.Text = "";
        }



        private void SupplierDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CusIDCB_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void CusIDCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            //  GetCusName();
        }

        private void VATtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void VATtb_MouseLeave(object sender, EventArgs e)
        {

        }

        private void VATtb_KeyDown(object sender, KeyEventArgs e)
        {

        }
        int bflag = 0;
        string getName;


        private void InsertBill()
        {



            if (CusIDCB.SelectedIndex == -1 || PaymentCB.SelectedIndex == -1 || GrdTotal.Text == "")
            {
                MBox1.Show("All fields are required ");
            }
            else
            {
                try
                {
                    // we open db connection 
                    foreach (DataGridViewRow row in BillDGV.Rows)
                    {

                        if (row.Cells["Column2"].Value != null)
                        {
                            getName = row.Cells["Column2"].Value.ToString(); // This will take the last value
                                                                             //    Console.WriteLine($"getName: {getName}");
                        }
                    }


                    Con.Open();
                    MySqlCommand cmd = new MySqlCommand(" insert into BillT(BDate, CustId, CustName, PMethod, Amt, ProductName) values(@BD, @CI, @CN, @PM, @AM, @PN)", Con);
                    cmd.Parameters.AddWithValue("@BD", BDateCB.Value.Date);
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    cmd.Parameters.AddWithValue("@CI", CusIDCB.SelectedValue.ToString());
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                    //cmd.Parameters.AddWithValue("@CN", PriceTb.Text);
                    cmd.Parameters.AddWithValue("@CN", CusNameCB.Text);
                    cmd.Parameters.AddWithValue("@PN", getName);
                    //  cmd.Parameters.AddWithValue("@PN", productName);
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    cmd.Parameters.AddWithValue("@PM", PaymentCB.SelectedItem.ToString());
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                    cmd.Parameters.AddWithValue("@AM", Convert.ToDouble(GrdTotal.Text));

                    cmd.ExecuteNonQuery();
                    // MBox1.Show("Bill saved");


                    bflag = 1;
                    Con.Close();
                    //Reset();
                }
                catch (Exception Ex)
                {
                    MBox1.Show(Ex.Message);
                }
            }
        }




        private void VATtb_KeyUp(object sender, KeyEventArgs e)
        {

            if (VATtb.Text == "")
            {

            }
            else if (SubTotal.Text == "")
            {
                MBox1.Show("Add Products to Cart ");
                VATtb.Text = "";
            }
            else
            {
                try
                {



                    float VAT = (Convert.ToSingle(VATtb.Text) / 100) * Convert.ToSingle(SubTotal.Text);
                    // int getvat = Convert.ToInt32(VATtb.Text) = 0);
                    // float VAT = getvat * Convert.ToSingle(SubTotal.Text);

                    TotTaxTb.Text = VAT.ToString();
                    //              VAT = 0;
                    GrdTotal.Text = "" + (Convert.ToSingle(SubTotal.Text) + Convert.ToSingle(TotTaxTb.Text));

                }
                catch (Exception Ex)
                {
                    MBox1.Show(Ex.Message);

                }
            }

        }


        private void textBox5_KeyUp(object sender, KeyEventArgs e)
        {
            if (discountTb.Text == "")
            {

            }
            else if (SubTotal.Text == "")
            {
                // MBox1.Show("Add Products to Cart ");
                MessageBox.Show("Add Products to Cart ");
                discountTb.Text = "";
            }
            else
            {
                try
                {

                    float Disc = (Convert.ToSingle(discountTb.Text) / 100) * Convert.ToSingle(SubTotal.Text);
                    // TotalDiscount.Text = "" + Disc;
                    //   discountTb.Text += 0;
                    TotalDiscount.Text = Disc.ToString();

                    GrdTotal.Text = "" + (Convert.ToSingle(SubTotal.Text) + Convert.ToSingle(TotTaxTb.Text) - Convert.ToSingle(TotalDiscount.Text));



                }
                catch (Exception Ex)
                {
                    MBox1.Show(Ex.Message);
                    MessageBox.Show(Ex.ToString());

                }
            }
        }
        int prodid, prodqty, prodprice, tottal, pos = 60;
        string prodname;


        
        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int pos = 40; // Starting position
            int gap = 40; // Gap for header and spacing

            // Header
            string title = "AMATCHIWA";
            string contact = "Tel:+233 550 188 193";
            string location = "Location: 6 TANBU LANE SHIASHI, ACCRA";

            // Center header text
            int titleX = e.MarginBounds.Left + (e.MarginBounds.Width /6) -
                         (int)e.Graphics.MeasureString(title, new Font("Century Gothic", 10, FontStyle.Bold)).Width / 2;
            int contactX = e.MarginBounds.Left + (e.MarginBounds.Width / 6) -
                           (int)e.Graphics.MeasureString(contact, new Font("Century Gothic", 6, FontStyle.Bold)).Width / 2;

            e.Graphics.DrawString(title, new Font("Century Gothic", 10, FontStyle.Bold), Brushes.Black, new Point(titleX-55, pos));
            pos += 20;
            e.Graphics.DrawString(contact, new Font("Century Gothic", 6, FontStyle.Bold), Brushes.Black, new Point(contactX-55, pos));
            pos += 20;
            e.Graphics.DrawString(location, new Font("Century Gothic", 6, FontStyle.Bold), Brushes.Black, new Point(e.MarginBounds.Left-80, pos));
            pos += 20;

            e.Graphics.DrawString("___________________________________________________", new Font("Century Gothic", 6, FontStyle.Bold), Brushes.Black, new Point(e.MarginBounds.Left - 80, pos));
            pos += 20;

            // Table Header
            e.Graphics.DrawString("ID PRODUCT QUANTITY PRICE  TOTAL", new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(e.MarginBounds.Left - 80, pos));
            pos += 20;

            // Table Rows
            int grandTotal = 0; // Variable to accumulate grand total
            foreach (DataGridViewRow row in BillDGV.Rows)
            {
                if (row.IsNewRow || row.Cells["Column1"].Value == null) continue;

                int prodid = Convert.ToInt32(row.Cells["Column1"].Value);
                string prodname = row.Cells["Column2"].Value?.ToString() ?? string.Empty;
                int prodprice = Convert.ToInt32(row.Cells["Column3"].Value);
                int prodqty = Convert.ToInt32(row.Cells["Column4"].Value);
                int tottal = Convert.ToInt32(row.Cells["Column5"].Value);

                grandTotal += tottal; // Add to grand total

                e.Graphics.DrawString(prodid.ToString(), new Font("Century Gothic", 6, FontStyle.Bold), Brushes.Black, new Point(e.MarginBounds.Left - 80, pos));
                e.Graphics.DrawString(prodname, new Font("Century Gothic", 6, FontStyle.Bold), Brushes.Black, new Point(e.MarginBounds.Left - 60, pos));
                e.Graphics.DrawString(prodprice.ToString(), new Font("Century Gothic", 6, FontStyle.Bold), Brushes.Black, new Point(e.MarginBounds.Left + 15, pos));
                e.Graphics.DrawString(prodqty.ToString(), new Font("Century Gothic", 6, FontStyle.Bold), Brushes.Black, new Point(e.MarginBounds.Left + 55, pos));
                e.Graphics.DrawString(tottal.ToString(), new Font("Century Gothic", 6, FontStyle.Bold), Brushes.Black, new Point(e.MarginBounds.Left + 75 , pos));

                pos += 20;

                if (pos > e.MarginBounds.Bottom - 40) // Check for page overflow
                {
                    e.HasMorePages = true;
                    return;
                }
            }

            // Print Grand Total
            pos += 20; // Add spacing
            e.Graphics.DrawString($"Grand Total: {grandTotal}", new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(e.MarginBounds.Left - 80, pos));
            pos += 20;

            // Print Footer
            string footerText = "Thank you for shopping with us!";
            e.Graphics.DrawString(footerText, new Font("Century Gothic", 6, FontStyle.Bold), Brushes.Black, new Point(e.MarginBounds.Left-80, pos));
            pos += 20;

            string footerNote = "Visit Again!";
            e.Graphics.DrawString(footerNote, new Font("Century Gothic", 6, FontStyle.Bold), Brushes.Black, new Point(e.MarginBounds.Left-80, pos));

            // Ensure no more pages
            e.HasMorePages = false;
        }

        
        
        private void label8_Click(object sender, EventArgs e)
        {
            ViewBill obj = new ViewBill();
            obj.Show();
            // this.Close();
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void GrdTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void Billing_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BillDGV.Rows.Clear();
            // int zero = 0;
            total = 0;
            SubTotal.Text = "";

        }

        private void VATtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                // Check if the character is a digit or a decimal point
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true; // Ignore the input
                }

                // Optional: Prevent multiple decimal points
                if (e.KeyChar == '.' && VATtb.Text.Contains('.'))
                {
                    e.Handled = true; // Ignore the input
                }
            }
        }

        private void discountTb_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar))
            {
                // Check if the character is a digit or a decimal point
                if (!char.IsDigit(e.KeyChar) && e.KeyChar != '.')
                {
                    e.Handled = true; // Ignore the input
                }

                // Optional: Prevent multiple decimal points
                if (e.KeyChar == '.' && discountTb.Text.Contains('.'))
                {
                    e.Handled = true; // Ignore the input
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            VATtb.Text = "";
            discountTb.Text = "";
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Expiring exp = new Expiring();
            exp.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
