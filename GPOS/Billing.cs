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
            //getCustomer();
            //GetCusName();
            ProductsDVG.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            ProductsDVG.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            ProductsDVG.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;
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
                ProductsDVG.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
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
        MySqlConnection Con = new MySqlConnection("server=localhost; database=posdb; username=root; password=;");

        private void DisplayProducts()

        {
            Con.Open();
            string Query = "select * from ProductTbl";
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
        int Pprice, PStock;
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
        int total = 0;
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
                    // Convert the quantity from the Quantity TextBox to an integer and multiply by the product price
                    int Subtotal = Convert.ToInt32(Quantity.Text) * Pprice;
                    total = total + Subtotal;
                    // Create a new row for the DataGridView
                    DataGridViewRow newRow = new DataGridViewRow();

                    // Initialize the new row with the appropriate number of cells for the SupplierDGV
                    newRow.CreateCells(BillDGV);

                    // Set the value of the first cell to the variable 'n'
                    // This might be an index or counter, but its definition is not provided in this snippet
                    newRow.Cells[0].Value = n;

                    //rodname  = PnameTb.Text;
                    //  productName = "" + newRow.Cells["Column2"].Value;

                    //abel4 = newRow.Cells[1].Value = PnameTb;
                    // Set the value of the second cell to the product name from the PnameTb TextBox
                    newRow.Cells[1].Value = PnameTb;

                    // Set the value of the third cell to the quantity from the Quantity TextBox
                    newRow.Cells[2].Value = Quantity.Text;

                    // Set the value of the fourth cell to the product price (Pprice)
                    newRow.Cells[3].Value = Pprice;

                    // Set the value of the fifth cell to the calculated subtotal
                    newRow.Cells[4].Value = Subtotal;

                    // Add the new row to the SupplierDGV DataGridView
                    BillDGV.Rows.Add(newRow);
                    SubTotal.Text = "" + total;
                    UpdateQuantity();
                    n++;
                    Reset();
                }
            }

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // setting/getting  data in datagrid to fit text box for edit RESPECTIVELY 
            if (ProductsDVG.SelectedRows.Count > 0 && ProductsDVG.SelectedRows[0].Cells[1].Value != null)
            {
#pragma warning disable CS8601 // Possible null reference assignment.
                PnameTb = ProductsDVG.SelectedRows[0].Cells[1].Value.ToString();
#pragma warning restore CS8601 // Possible null reference assignment.
            }
            else
            {
                // Handle the case where no row is selected or the cell value is null
                MessageBox.Show("Please select a valid row with a valid product name.");
                PnameTb = string.Empty; // or some other default value
            }




            //PnameTb = ProductsDVG.SelectedRows[0].Cells[1].Value.ToString();
            //PcatCB.SelectedItem = ProductDGV.SelectedRows[0].Cells[2].Value.ToString();
            Pprice = Convert.ToInt32(ProductsDVG.SelectedRows[0].Cells[3].Value.ToString());
            PStock = Convert.ToInt32(ProductsDVG.SelectedRows[0].Cells[4].Value.ToString());


            if (PnameTb == "")
            {

                keyMain = 0;
            }
            else
            {

                keyMain = Convert.ToInt32(ProductsDVG.SelectedRows[0].Cells[0].Value.ToString());

            }


        }
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



                    double VAT = (Convert.ToDouble(VATtb.Text) / 100) * Convert.ToInt32(SubTotal.Text);
                    TotTaxTb.Text = "" + VAT;
                    GrdTotal.Text = "" + (Convert.ToInt32(SubTotal.Text) + Convert.ToDouble(TotTaxTb.Text));

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
                MBox1.Show("Add Products to Cart ");
                discountTb.Text = "";
            }
            else
            {
                try
                {
                    double Disc = (Convert.ToDouble(discountTb.Text) / 100) * Convert.ToInt32(SubTotal.Text);
                    //  TotalDiscount.Text = "" + Disc;
                    TotalDiscount.Text = Disc.ToString();
                    GrdTotal.Text = "" + (Convert.ToInt32(SubTotal.Text) + Convert.ToDouble(TotTaxTb.Text) - Convert.ToDouble(TotalDiscount.Text));


                }
                catch (Exception Ex)
                {
                    MBox1.Show(Ex.Message);

                }
            }
        }
        int prodid, prodqty, prodprice, tottal, pos = 60;
        string prodname;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
#pragma warning disable CS8602 //1   Dereference of a possibly null reference.
            e.Graphics.DrawString("AHAVAH ODO ENTERPRISE", new Font("Centry Gothic", 12, FontStyle.Bold), Brushes.Black, new Point(70, 10));
#pragma warning restore CS8602 // Dereference of a possibly null reference.
            e.Graphics.DrawString("ID PRODUCT PRICE QUANTITY TOTAL", new Font("Centry Gothic", 8, FontStyle.Bold), Brushes.Black, new Point(26, 40));
            foreach (DataGridViewRow row in BillDGV.Rows)
            {
                prodid = Convert.ToInt32(row.Cells["Column1"].Value);
                prodname = "" + row.Cells["Column2"].Value;
                prodprice = Convert.ToInt32(row.Cells["Column3"].Value);
                prodqty = Convert.ToInt32(row.Cells["Column4"].Value);
                tottal = Convert.ToInt32(row.Cells["Column5"].Value);



                e.Graphics.DrawString("" + prodid, new Font("Centry Gothic", 6, FontStyle.Bold), Brushes.Blue, new Point(26, pos));
                e.Graphics.DrawString("" + prodname, new Font("Centry Gothic", 6, FontStyle.Bold), Brushes.Blue, new Point(45, pos));
                e.Graphics.DrawString(" " + prodprice, new Font("Centry Gothic", 6, FontStyle.Bold), Brushes.Blue, new Point(120, pos));
                e.Graphics.DrawString("" + prodqty, new Font("Centry Gothic", 6, FontStyle.Bold), Brushes.Blue, new Point(170, pos));
                e.Graphics.DrawString("" + tottal, new Font("Centry Gothic", 8, FontStyle.Bold), Brushes.Blue, new Point(235, pos));

                pos = pos + 20;


            }
#pragma warning disable CS0219 // Variable is assigned but its value is never used
            int lineSpacing = 20;
#pragma warning restore CS0219 // Variable is assigned but its value is never used

            e.Graphics.DrawString("**********Powered by: GrockTech Consult************", new Font("Century Gothic", 8, FontStyle.Bold), Brushes.Crimson, new Point(35, pos + 70));


            e.Graphics.DrawString("Grand Total: GH¢" + GrdTotal.Text, new Font("Centry Gothic", 8, FontStyle.Bold), Brushes.Crimson, new Point(50, pos + 30));
            //e.Graphics.DrawString("***************************GrockTech Consult**********************" , new Font("Centry Gothic", 8, FontStyle.Bold), Brushes.Crimson, new Point(50, pos + 50 + lineSpacing));
            e.Graphics.DrawLine(Pens.Black, new Point(50, pos + 70), new Point(250, pos + 70));

            // Draw the footer text

            BillDGV.Rows.Clear();
            BillDGV.Refresh();
            //Del();
            pos = 100;
            GrdTotal.Text = "";
            //  tot n  = 0;
            total = 0;
            SubTotal.Text = "";

            n = 0;


            //    Subtotal = Convert.ToInt32(Quantity.Text) * Pprice;



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
    }
}
