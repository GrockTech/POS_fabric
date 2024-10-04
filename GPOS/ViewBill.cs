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
    }
}
