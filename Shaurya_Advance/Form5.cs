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
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Shaurya_Advance
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Course cs=new Course();
                cs.Id = Convert.ToInt32(txtId.Text);
                cs.Name = txtName.Text;
                cs.Fees = Convert.ToInt32(txtFees.Text);
                FileStream fs = new FileStream(@"f:\Course", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, cs);
                MessageBox.Show("Binary File Created");
                fs.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }


        }

        private void btnBinaryRead_Click(object sender, EventArgs e)
        {
            try
            {
                Course cs = new Course();
                FileStream fs = new FileStream(@"f:\Course", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
                cs = (Course)bf.Deserialize(fs);
                txtId.Text = cs.Id.ToString();
                txtName.Text = cs.Name;
                txtFees.Text = cs.Fees.ToString();
                fs.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnXmlWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Course cs = new Course();
                cs.Id = Convert.ToInt32(txtId.Text);
                cs.Name = txtName.Text;
                cs.Fees = Convert.ToInt32(txtFees.Text);
                FileStream fs = new FileStream(@"f:\CourseXml", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(Employee));
                xs.Serialize(fs, cs);
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
                Course cs = new Course();
                FileStream fs = new FileStream(@"f:\CourseXml", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(Course));
                cs = (Course)xs.Deserialize(fs);
                txtId.Text = cs.Id.ToString();
                txtName.Text = cs.Name;
                txtFees.Text = cs.Fees.ToString();
                fs.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btnSoapWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Course cs = new Course();
                cs.Id = Convert.ToInt32(txtId.Text);
                cs.Name = txtName.Text;
                cs.Fees = Convert.ToInt32(txtFees.Text);
                FileStream fs = new FileStream(@"f:\Coursesoap", FileMode.Create, FileAccess.Write);
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, cs);
                MessageBox.Show("Soap File Created");
                fs.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnSoapRead_Click(object sender, EventArgs e)
        {
            try
            {
                Course cs = new Course();
                FileStream fs = new FileStream(@"f:\CourseSoap", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                cs = (Course)sf.Deserialize(fs);
                txtId.Text = cs.Id.ToString();
                txtName.Text = cs.Name;
                txtFees.Text = cs.Fees.ToString();
                fs.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btnJslnWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Course cs = new Course();
                cs.Id = Convert.ToInt32(txtId.Text);
                cs.Name = txtName.Text;
                cs.Fees = Convert.ToInt32(txtFees.Text);
                FileStream fs = new FileStream(@"f:\CourseJsln", FileMode.Create, FileAccess.Write);
               
                JsonSerializer.Serialize(fs, cs);
                MessageBox.Show("JSON File Created");
                fs.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btnJslnRead_Click(object sender, EventArgs e)
        {
            try
            {
                Course cs = new Course();
                FileStream fs = new FileStream(@"f:\CourseJsln", FileMode.Open, FileAccess.Read);
               
                cs = JsonSerializer.Deserialize<Course>(fs);
                txtId.Text = cs.Id.ToString();
                txtName.Text = cs.Name;
                txtFees.Text = cs.Fees.ToString();
                fs.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }
    }
    
}
