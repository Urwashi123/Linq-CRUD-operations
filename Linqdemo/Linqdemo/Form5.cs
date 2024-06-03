using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq;

namespace Linqdemo
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CompanyDBDataContext db = new CompanyDBDataContext();
            ISingleResult<Employee_SelectResult>tab =  db.Employee_Select();
            dataGridView1.DataSource = tab;

        }
    }
}
