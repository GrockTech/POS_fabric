using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPOS.Properties
{
    public partial class SuppliersAdd : Form
    {
        public SuppliersAdd()
        {
            InitializeComponent();
        }

        private void SuppliersAdd_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\GidCode\Desktop\CodeMe\GPOSDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {
            if (SupName.Text == "" || SupAdd.Text == "" || SupPhone.Text == "" || SupRem.Text == "")
            {
                MessageBox.Show("All fields are required ");
            }
            else
            {
                try
                {
                    // we open db connection 
                    Con.Open();
                    SqlCommand cmd = new SqlCommand(" insert into SupplierTbl(SupName, SupAddress, SupPhone, SupRem) values(@SN, @SA, @SP, @SR)", Con);
                    cmd.Parameters.AddWithValue("@SN", SupName.Text);
                    cmd.Parameters.AddWithValue("@SA", SupAdd.Text);
                    cmd.Parameters.AddWithValue("@SP", Convert.ToInt32(SupPhone.Text).ToString());
                    cmd.Parameters.AddWithValue("@SR", SupRem.Text);

                    cmd.ExecuteNonQuery();
                    MBox1.Show("Supplier Added");
                    Con.Close();
                     Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void SupPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void SupRem_TextChanged(object sender, EventArgs e)
        {

        }
        private void Reset()
        {
            SupName.Text = "";
            SupAdd.Text = "";
            SupPhone.Text = "";
            SupRem.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
