using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shaurya_Advance
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {

            try
            {
                Product p = new Product();
                p.Id = Convert.ToInt32(txtId.Text);
                p.Name = txtName.Text;
                p.Price = Convert.ToInt32(txtPrice.Text);
                FileStream fs = new FileStream(@"E:\Product", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, p);
                MessageBox.Show("Created");
                fs.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                FileStream fs = new FileStream(@"E:\Product", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                p = (Product)bf.Deserialize(fs);
                txtId.Text = p.Id.ToString();
                txtName.Text = p.Name;
                txtPrice.Text = p.Price.ToString();
                fs.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
