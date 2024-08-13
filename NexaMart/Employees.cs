using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace NexaMart
{
    public partial class Employees : Form
    {
        Dashboard CurrD;

        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\C# programs\VS PROGRAMS\\NexaMart\NexaMart\NexaMartDB.accdb");
        public Employees()
        {
            InitializeComponent();
           
        }

        public void setDash(Dashboard d)
        {
            CurrD = d;
        }

        void fill()
        {
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select *from Employees order by ID", con);
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

        private void EmpExit_Click(object sender, EventArgs e)
        {
            CurrD.loadform(CurrD.home);
            CurrD.isemployees = false;
            empID.Clear();
            empName.Clear();
            empContact.Clear();
            empSalary.Clear();
            empHireDate.ResetText();
            empRole.Text = "Select Role";
            
            this.Hide();
            
        }

        private void empAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(empID.Text);
                Convert.ToInt32(empSalary.Text);
            }
            catch (Exception ex){
                MessageBox.Show("Enter Correct value ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
  
            try
            {
                con.Open();
                OleDbCommand cmd = new OleDbCommand("Insert into Employees values(" + Convert.ToInt32(empID.Text) + ",'" + empName.Text + "','" + empContact.Text + "','" + empHireDate.Value.ToString("d-M-yyyy") + "'," + Convert.ToInt32(empSalary.Text) + ",'" + empRole.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Added Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Record Already Present","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            fill();
        }

        private void empUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();

                OleDbCommand cmd = new OleDbCommand("Update Employees set Ename='"+empName.Text+ "', Ephone= '" + empContact.Text + "', hire_date='"+ empHireDate.Value.ToString("d-M-yyyy") + "' ,Esalary="+ Convert.ToInt32(empSalary.Text) + " , Role='"+empRole.Text+"' where ID="+ Convert.ToInt32(empID.Text) + " ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Record Not Present", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            fill();
        }

        private void empDelete_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();

                OleDbCommand cmd = new OleDbCommand("Delete from Employees where ID="+Convert.ToInt32(empID.Text)+"",con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Record Not Present", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            fill();
        }
    }
}
