using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Text.Json;

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

        private void btnXmlWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                p.Id = Convert.ToInt32(txtId.Text);
                p.Name = txtName.Text;
                p.Price = Convert.ToInt32(txtPrice.Text);
                FileStream fs = new FileStream(@"E:\ProductXml", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(Product));
                xs.Serialize(fs, p);
                MessageBox.Show("Xml File Created");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnXmlRead_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                FileStream fs = new FileStream(@"E:\ProductXml", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(Product));
                p = (Product)xs.Deserialize(fs);
                txtId.Text = p.Id.ToString();
                txtName.Text = p.Name;
                txtPrice.Text = p.Price.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSOAPWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                p.Id = Convert.ToInt32(txtId.Text);
                p.Name = txtName.Text;
                p.Price = Convert.ToInt32(txtPrice.Text);
                FileStream fs = new FileStream(@"E:\ProductSoap", FileMode.Create, FileAccess.Write);
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, p);
                MessageBox.Show("Soap File Created");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnSOAPRead_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                FileStream fs = new FileStream(@"E:\ProductSoap", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                p = (Product)sf.Deserialize(fs);
                txtId.Text = p.Id.ToString();
                txtName.Text = p.Name;
                txtPrice.Text = p.Price.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnJSONWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Product p = new Product();
                p.Id = Convert.ToInt32(txtId.Text);
                p.Name = txtName.Text;
                p.Price = Convert.ToInt32(txtPrice.Text);
                FileStream fs = new FileStream(@"E:\ProductJson", FileMode.Create, FileAccess.Write);
                JsonSerializer.Serialize(fs, p);
                MessageBox.Show("Json File Created");
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnJSONRead_Click(object sender, EventArgs e)
        {

            try
            {
                Product p = new Product();
                FileStream fs = new FileStream(@"E:\ProductJson", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                p = JsonSerializer.Deserialize<Product>(fs);
                txtId.Text = p.Id.ToString();
                txtName.Text = p.Name;
                txtPrice.Text = p.Price.ToString();
                fs.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
