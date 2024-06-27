using GPOS.Properties;
using Microsoft.VisualBasic;

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
            //   Addsuppliers Obj new AddSuppliers();
            // Obj.Show();




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
    }
}
