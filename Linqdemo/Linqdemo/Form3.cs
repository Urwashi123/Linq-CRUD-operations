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
    public partial class Form3 : Form
    {
        CompanyDBDataContext db;
        public Form3()
        {
            InitializeComponent();
        }
        private void LoadData()
        {
            db = new CompanyDBDataContext();
            dgView.DataSource =  db.Employees;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            //db= new CompanyDBDataContext();
            //dgView.DataSource =  db.Employees;
            LoadData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.ShowDialog();
            LoadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(dgView.SelectedRows.Count > 0) { 
            Form4 f = new Form4();
                f.textBox1.ReadOnly= true;
                f.button2.Enabled= false;
                f.button1.Text = "Update";
           f.textBox1.Text = dgView.SelectedRows[0].Cells[0].Value.ToString();
            f.textBox2.Text = dgView.SelectedRows[0].Cells[1].Value.ToString();
            f.textBox3.Text = dgView.SelectedRows[0].Cells[2].Value.ToString();
            f.textBox4.Text = dgView.SelectedRows[0].Cells[3].Value.ToString();
            f.textBox5.Text = dgView.SelectedRows[0].Cells[4].Value.ToString();
                f.ShowDialog();
                LoadData();
            }
            else
            {
                MessageBox.Show("Please select a record for updation.", "Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(dgView.SelectedRows.Count > 0)
            {
                if(MessageBox.Show("Are you sure of deleting the selected record?","Confirmation",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    int Eno = Convert.ToInt32(dgView.SelectedRows[0].Cells[0].Value);
                    Employee obj = db.Employees.SingleOrDefault(E=>E.Eno == Eno);
                    db.Employees.DeleteOnSubmit(obj);
                    db.SubmitChanges();
                    LoadData();
                }
            }
            else
            {
                MessageBox.Show("Please select a record for deletion.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
