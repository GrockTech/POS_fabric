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
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-NQAIIND\SQLEXPRESS; Initial Catalog=mydb; Integrated Security = True; Connect Timeout = 30; ");

        //SqlConnection Con = new SqlConnection(@"DESKTOP-NQAIIND\SQLEXPRESS; Initial Catalog=mydb; Integrated Security = True; Connect Timeout = 30; ");
        private void ViewBills()
        {
            Con.Open();
            string Query = "select * from BillT";
            SqlDataAdapter adapter = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            var ds = new DataSet();
            adapter.Fill(ds);
            // we fill data grid with the acutal data in db
            SellDGV.DataSource = ds.Tables[0];


            SellDGV.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

            Con.Close();

        }
    }
}
