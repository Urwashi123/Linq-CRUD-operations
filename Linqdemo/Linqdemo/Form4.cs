using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linqdemo
{
    public partial class Form4 : Form
    {
      
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CompanyDBDataContext db = new CompanyDBDataContext();
            if (textBox1.ReadOnly == false)
            {

            Employee obj = new Employee();  
            obj.Eno = int.Parse(textBox1.Text);
            obj.Ename = textBox2.Text;
            obj.Job = textBox3.Text;
            obj.Salary = decimal.Parse(textBox4.Text);
            obj.Dname = textBox5.Text;
            db.Employees.InsertOnSubmit(obj);
            db.SubmitChanges();
            MessageBox.Show("Record inserted on table");
             
            }
            else
            {
             Employee obj = db.Employees.SingleOrDefault(E => E.Eno == int.Parse(textBox1.Text));
                obj.Ename = textBox2.Text;
                obj.Job = textBox3.Text;
                obj.Salary= decimal.Parse(textBox4.Text);
                obj.Dname= textBox5.Text;
                db.SubmitChanges();
                MessageBox.Show("Record updated in table"); 
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach(Control crtl in this.Controls)
            {
                if(crtl is TextBox) 
                {
                TextBox tb = crtl as TextBox;
                    tb.Clear();
                }
            }textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
