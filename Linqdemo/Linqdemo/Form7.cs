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
    public partial class Form7 : Form
    {
        CompanyDBDataContext db;
        bool flag= false;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            db = new CompanyDBDataContext();
            dataGridView1.DataSource = from E in db.Emps select E;
             var tab= from E in db.Emps select new{ E.Job};
            comboBox1.DataSource = tab.Distinct();
            comboBox1.DisplayMember = "Job";
            comboBox1.SelectedIndex = -1;
            flag= true;


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {  if(flag == true)
            dataGridView1.DataSource = from E in db.Emps where E.Job == comboBox1.Text select E;

        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            dataGridView1.DataSource = from E in db.Emps where E.Job.Contains(comboBox1.Text) select E;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from E in db.Emps orderby E.Salary select E;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from E in db.Emps orderby E.Empname descending select E;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from E in db.Emps select new {E.Empno, sal=E.Salary, E.Empname,E.Job,E.Deptno};
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from E in db.Emps group E by E.Deptno into G select new { Deptno = G.Key, EmpCount = G.Count() };
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from E in db.Emps group E by E.Job into G select new { Job = G.Key, EmpCount = G.Count() };
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from E in db.Emps group E by E.Deptno into G where G.Count() > 5 select new { Deptno = G.Key, EmpCount = G.Count() };
        }

        private void button7_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from E in db.Emps group E by E.Job into G where G.Count() < 5 select new { job = G.Key, EmpCount = G.Count() };

        }

        private void button8_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from E in db.Emps where E.Job == "Developer" group E by E.Deptno into G where G.Count()>1 orderby G.Key descending select new { Deptno = G.Key, Developer = G.Count() }; 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from E in db.Emps group E by E.Deptno into G select new { Deptno = G.Key, MaxSal = G.Max(E => E.Salary) };
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = from E in db.Emps group E by E.Deptno into G select new { Deptno = G.Key, MinSal = G.Min(E => E.Salary) };

        }
    }
}
