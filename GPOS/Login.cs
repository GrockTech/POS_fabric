using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GPOS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            //  loginButton.Click += new EventHandler(loginButton_Click);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //  private void Login_Load(object sender, EventArgs e){  }
        private void label5_Click(object sender, EventArgs e)
        {
            Billing obj = new Billing();
            obj.Show();
            this.Hide();
        }
        private void Loginclick()
        {
            if (UsernameTB.Text == "" || PasswordTB.Text == "")
            {
                MBox1.Show("Enter UserName and Password");

            }
            else if (UsernameTB.Text == "Admin" && PasswordTB.Text == "Gidcode")
            {
                Mainmenu Obj = new Mainmenu();
                Obj.Show();
                this.Hide();
            }
            else
            {
                MBox1.Show("Wrong Username or Password");
            }

        }
        //  private void button1_MouseClick(object sender, MouseEventArgs e) { }
        //   private void loginButton_Click()
        //  {

        //  }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            Loginclick();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
