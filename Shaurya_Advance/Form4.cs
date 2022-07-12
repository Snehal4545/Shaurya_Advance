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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnBinaryWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                emp.Id=Convert.ToInt32(txtId.Text);
                emp.Name=txtName.Text;
                emp.Salary=Convert.ToInt32(txtSalary.Text);
                FileStream fs = new FileStream(@"f:\Employee", FileMode.Create, FileAccess.Write);
                BinaryFormatter bf =  new BinaryFormatter();
                bf.Serialize(fs, emp);
                MessageBox.Show("Binary File Created");
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
                Employee emp = new Employee();
                FileStream fs = new FileStream(@"f:\Employee", FileMode.Open, FileAccess.Read);
                BinaryFormatter bf = new BinaryFormatter();
               emp=(Employee) bf.Deserialize(fs);
                txtId.Text = emp.Id.ToString();
                txtName.Text = emp.Name;
                txtSalary.Text = emp.Salary.ToString();
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
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(txtId.Text);
                emp.Name = txtName.Text;
                emp.Salary = Convert.ToInt32(txtSalary.Text);
                FileStream fs = new FileStream(@"f:\Employee", FileMode.Create, FileAccess.Write);
                XmlSerializer xs = new XmlSerializer(typeof(Employee));
                xs.Serialize(fs, emp);
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
                Employee emp = new Employee();
                FileStream fs = new FileStream(@"f:\EmployeeXml", FileMode.Open, FileAccess.Read);
                XmlSerializer xs = new XmlSerializer(typeof(Employee));
                emp = (Employee)xs.Deserialize(fs);
                txtId.Text = emp.Id.ToString();
                txtName.Text = emp.Name;
                txtSalary.Text = emp.Salary.ToString();
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
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(txtId.Text);
                emp.Name = txtName.Text;
                emp.Salary = Convert.ToInt32(txtSalary.Text);
                FileStream fs = new FileStream(@"f:\EmployeeSoap", FileMode.Create, FileAccess.Write);
                SoapFormatter sf = new SoapFormatter();
                sf.Serialize(fs, emp);
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
                Employee emp = new Employee();
                FileStream fs = new FileStream(@"f:\EmployeeSoap", FileMode.Open, FileAccess.Read);
                SoapFormatter sf = new SoapFormatter();
                emp = (Employee)sf.Deserialize(fs);
                txtId.Text = emp.Id.ToString();
                txtName.Text = emp.Name;
                txtSalary.Text = emp.Salary.ToString();
                fs.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btnJsonWrite_Click(object sender, EventArgs e)
        {
            try
            {
                Employee emp = new Employee();
                emp.Id = Convert.ToInt32(txtId.Text);
                emp.Name = txtName.Text;
                emp.Salary = Convert.ToInt32(txtSalary.Text);
                FileStream fs = new FileStream(@"f:\EmployeeJson", FileMode.Create, FileAccess.Write);
             
                JsonSerializer.Serialize(fs, emp);
                MessageBox.Show("JSON File Created");
                fs.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void btnJsonRead_Click(object sender, EventArgs e)
        {

            try
            {
                Employee emp = new Employee();
                FileStream fs = new FileStream(@"f:\EmployeeJson", FileMode.Open, FileAccess.Read);
                
               emp= JsonSerializer.Deserialize<Employee>(fs);
                txtId.Text = emp.Id.ToString();
                txtName.Text = emp.Name;
                txtSalary.Text = emp.Salary.ToString();
                fs.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
