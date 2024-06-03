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
    public partial class Form6 : Form
    {
        CompanyDBDataContext db;

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
             db = new CompanyDBDataContext();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int? Eno = null;
            db.Employee_Insert(textBox2.Text, textBox3.Text,decimal.Parse(textBox4.Text), textBox5.Text, ref Eno);
            textBox1.Text= Eno.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control crtl in this.Controls)
            {
                if (crtl is TextBox)
                {
                    TextBox tb = crtl as TextBox;
                    tb.Clear();
                }

            }textBox2.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
