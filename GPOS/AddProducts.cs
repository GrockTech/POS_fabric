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
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\GidCode\Desktop\CodeMe\GPOSDB.mdf;Integrated Security=True;Connect Timeout=30");
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
                    SqlCommand cmd = new SqlCommand(" insert into ProductTbl(PName, Pcat, Pprice, PQty) values(@PN, @PC, @PP, @PQ)", Con);
                    cmd.Parameters.AddWithValue("@PN", PnameTb.Text);
                    cmd.Parameters.AddWithValue("@PC", PcatCB.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@PP", PriceTb.Text);
                    cmd.Parameters.AddWithValue("@PQ", QtyTb.Text);

                    cmd.ExecuteNonQuery();
                    MBox1.Show("Product Added"); 
                    Con.Close();
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
