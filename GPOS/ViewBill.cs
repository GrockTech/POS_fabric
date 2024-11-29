using System;
using System.Collections;
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
    public partial class ViewBill : Form
    {
        public ViewBill()
        {
            InitializeComponent();
            ViewBills();
        }




        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        MySqlConnection Con = new MySqlConnection("server=localhost; database=posdb; username=root; password=;");


        private void ExecuteQueryAndUpdateDataGridView(string query)
        {
            // Define the connection string (replace with your actual connection string)

            string connectionString = "server=localhost; database=posdb; username=root; password=;";
            using (MySqlConnection con = new MySqlConnection(connectionString))
            {
                con.Open(); // Open the database connection

                // Create a MySqlDataAdapter with the query and connection
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, con);
                MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
                var ds = new DataSet();

                // Fill the DataSet with the result of the query
                adapter.Fill(ds);

                // Bind the DataTable to the DataGridView
                SellDGV.DataSource = ds.Tables[0];
            }
        }








        private void ViewBills()
        {
            Con.Open();
            string Query = "select * from BillT";
            MySqlDataAdapter adapter = new MySqlDataAdapter(Query, Con);
            MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            // we fill data grid with the acutal data in db
            SellDGV.DataSource = ds.Tables[0];


            SellDGV.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

            Con.Close();

        }



        // Event handler for ComboBox selection change
        /*
          private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
          {
              // Get the selected option from the ComboBox
              string OptionSelected = cmbSort.SelectedItem.ToString();
              //string query;

              // Retrieve the corresponding value from the dictionary
              Con.Open();
              string querry = "SELECT FROM billt WHERE PMethod = @PMethod";
              MySqlCommand cmd = new MySqlCommand(querry, Con);
              cmd.Parameters.AddWithValue("@PMethod", OptionSelected);
              MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
           //   MySqlCommandBuilder builder = new MySqlCommandBuilder(adapter);
              var ds = new DataSet();
              adapter.Fill(ds);
              // we fill data grid with the acutal data in db
              SellDGV.DataSource = ds.Tables[0];


          }
        */
        private void cmbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                // Get the selected option from the ComboBox
                string OptionSelected = cmbSort.SelectedItem.ToString();

                // Open the database connection
                Con.Open();

                // Correct the SQL query syntax
                string query = "SELECT * FROM billt WHERE PMethod = @PMethod";

                // Create a MySqlCommand with the query and connection
                MySqlCommand cmd = new MySqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@PMethod", OptionSelected);

                // Create a MySqlDataAdapter to execute the command and fill the DataSet
                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                var ds = new DataSet();
                adapter.Fill(ds);

                // Fill the DataGridView with the data from the DataSet
                SellDGV.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                // Handle any errors that occur
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                // Ensure the database connection is closed
                if (Con.State == System.Data.ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }


        // Function to execute the query and update the DataGridView

        private void ViewBill_Load(object sender, EventArgs e)
        {

        }

    }
    }

