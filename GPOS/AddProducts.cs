using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace GPOS
{
    public partial class AddProducts : Form
    {
        public AddProducts()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // game changer string
      //SqlConnection Con = new SqlConnection();
     // SqlConnection Con = MyDBConnection.GetConnected();
       // string connetionString = "Data Source=.;Initial Catalog=mytocks;Integrated Security=True;MultipleActiveResultSets=True";

        //   SqlConnection Con = DatabaseHelper.GetConnection();
        //SqlConnection dbConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\GidCode\Desktop\CodeMe\actualManagement\GPOS\GPOS\mystocks.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False");
     //   SqlConnection connetionString = new SqlConnection(@"Data Source=.;Initial Catalog=mytocks;Integrated Security=True;MultipleActiveResultSets=True");

       // SqlConnection conn = new SqlConnection (@" Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\GidCode\Desktop\CodeMe\actualManagement\GPOS\GPOS\mystocks.mdf;Integrated Security = True; Connect Timeout = 30; Encrypt=True");
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-NQAIIND\SQLEXPRESS; Initial Catalog=mydb; Integrated Security = True; Connect Timeout = 30; ");
        //SqlConnection connectionString = new SqlConnection("data source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\mystocks.mdf;Integrated Security=True;Connect Timeout=30");

        private void Reset()
        {
            PnameTb.Text = "";
            QtyTb.Text = "";
            PriceTb.Text = "";
            PcatCB.SelectedIndex = -1;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (PnameTb.Text == "" || PcatCB.SelectedIndex == -1 || PriceTb.Text == "" || QtyTb.Text == "")
            {
             MBox1.Show("All fields are required ");
            }
            else
            {
                try
                {
                  
                    // we open db connection 
                    Con.Open();
                   // connetionString.Open();
                    // dbConnection.Open();
                    SqlCommand cmd = new SqlCommand(" insert into ProductTbl(PName, Pcat, Pprice, PQty) values(@PN, @PC, @PP, @PQ)", Con);
                    cmd.Parameters.AddWithValue("@PN", PnameTb.Text);
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    cmd.Parameters.AddWithValue("@PC", PcatCB.SelectedItem.ToString());
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                    cmd.Parameters.AddWithValue("@PP", PriceTb.Text);
                    cmd.Parameters.AddWithValue("@PQ", QtyTb.Text);

                    cmd.ExecuteNonQuery();
                    MBox1.Show("Product Added");
                    Con.Close();
              //      dbConnection.Close();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MBox1.Show(Ex.Message);
                }
            }
        }

        private void PcatCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
