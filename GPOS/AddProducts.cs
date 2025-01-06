using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

using System.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing.Imaging;

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
        MySqlConnection Con = new MySqlConnection("server=localhost; database=fabricdb; username=root; password=;");

        private void Reset()
        {
            PnameTb.Text = "";
            QtyTb.Text = "";
            PriceTb.Text = "";
            PcatCB.SelectedIndex = -1;
        }
        /*  private byte[] getPhoto()
          {
              if (uploadclient.Image == null)
              {
                  throw new InvalidOperationException("Image is null");
              }

              using (MemoryStream stream = new MemoryStream())
              {
                  uploadclient.Image.Save(stream, uploadclient.Image.RawFormat);
                  return stream.ToArray();
              }
          }
  */
        private byte[] getPhoto()
        {
            if (uploadclient.Image == null)
            {
                throw new InvalidOperationException("Image is null");
            }

            using (MemoryStream stream = new MemoryStream())
            {
                var imageFormat = uploadclient.Image.RawFormat;

                // Verify if the image format has an associated encoder
                ImageCodecInfo encoder = ImageCodecInfo.GetImageDecoders().FirstOrDefault(codec => codec.FormatID == imageFormat.Guid);
                if (encoder == null)
                {
                    throw new InvalidOperationException("No encoder found for the specified image format.");
                }

                // Save the image to the memory stream using the encoder
                uploadclient.Image.Save(stream, imageFormat);
                return stream.ToArray();
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
           
            string colour;
            //float width;
            colour = txtfcolour.Text;

           
            float width = (float)Convert.ToDouble(txtwidth.Text);
            if (PnameTb.Text == "" || PcatCB.SelectedIndex == -1 || PriceTb.Text == "" || QtyTb.Text == "" ||  colour == "" )
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

                    MySqlCommand cmd = new MySqlCommand(" insert into ProductTbl(PName, Pcat, color, width, Pprice, PQty, p_image) values(@PN, @PC, @FC, @FW, @PP, @PQ, @FI)", Con);
                    cmd.Parameters.AddWithValue("@PN", PnameTb.Text);
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                    cmd.Parameters.AddWithValue("@PC", PcatCB.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@FC", colour);
                    cmd.Parameters.AddWithValue("@FW", width);
#pragma warning restore CS8602 // Dereference of a possibly null reference.
                    cmd.Parameters.AddWithValue("@PP", PriceTb.Text);
                    cmd.Parameters.AddWithValue("@PQ", QtyTb.Text);
                    cmd.Parameters.AddWithValue("@FI", getPhoto());
                    //cmd.Parameters.AddWithValue("@ED", expiry);

                    cmd.ExecuteNonQuery();
                    MBox1.Show("Product Added");
                    Con.Close();
                    //      dbConnection.Close();
                    Reset();
                }
                catch (Exception Ex)
                {
                   // MBox1.Show(Ex.Message);
                    MessageBox.Show(Ex.Message.ToString());
                }
            }
        }

        private void PcatCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                uploadclient.Image = new Bitmap(openFileDialog.FileName);
            }
        }
    }
}
