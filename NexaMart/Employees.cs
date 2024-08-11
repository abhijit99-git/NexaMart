using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NexaMart
{
    public partial class Employees : Form
    {

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\C# programs\VS PROGRAMS\\NexaMart\NexaMart\NexaMartDB.accdb");
        public Employees()
        {
            InitializeComponent();
        }

        void fill()
        {
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select *from Employees", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            EmployeesGrid.DataSource = dt;
            con.Close();
            EmployeesGrid.Columns[0].HeaderText = "ID";
            EmployeesGrid.Columns[1].HeaderText = "Name";
            EmployeesGrid.Columns[2].HeaderText = "Contact";
            EmployeesGrid.Columns[3].HeaderText = "Hire Date";
            EmployeesGrid.Columns[4].HeaderText = "Salary";
            EmployeesGrid.Columns[5].HeaderText = "Role";

        }


        private void clickbtn_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            empID.Focus();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            fill();
        }
    }
}
