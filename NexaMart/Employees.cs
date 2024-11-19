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
using System.Security.Cryptography;

namespace NexaMart
{
    public partial class Employees : Form
    {
        Dashboard CurrD;
        Form1 formcon = new Form1();

        OleDbConnection con;
        //OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\C# programs\VS PROGRAMS\\NexaMart\NexaMart\NexaMartDB.accdb");
        public Employees()
        {
            InitializeComponent();
        
        }

        public void setDash(Dashboard d)
        {
            CurrD = d;
        }


        bool zeroRecords = false;

        void iszeroRecords()
        {

            Form1 f2 = new Form1();

            try
            {
                OleDbConnection conforZero = f2.con;

                OleDbCommand cmdforZero = new OleDbCommand("SELECT COUNT(*) FROM Employees", conforZero);
                conforZero.Open();
                if (Convert.ToInt32(cmdforZero.ExecuteScalar().ToString()) == 0)
                {
                    zeroRecords = true;
                    empID.Text = "1";
                }
                else
                {
                    zeroRecords = false;

                }

                conforZero.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something Went Wrong , TRY AGAIN");
            }
        }

        void fill()
        {
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select *from Employees where 1=0 order by ID", con);
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
            con = formcon.con;
            fill();

        }

        private void EmpExit_Click(object sender, EventArgs e)
        {
            CurrD.loadform(CurrD.home);
            CurrD.isemployees = false;
            
            empName.Clear();
            empID.Clear();
            empContact.Clear();
            empSalary.Clear();
            empHireDate.ResetText();
            empRole.Text = "Select Role";
            SearchCustomerName.Text = "";

            this.Hide();
            
        }


        bool checkValid()
        {
            if (empContact.Text.Length !=10)
            {
               
                return true;
            }
            else
            {
                return false;
            }

        }
        private void empAdd_Click(object sender, EventArgs e)
        {
            if (checkValid() == false)
            {


                try
                {
                    Convert.ToInt32(empID.Text);
                    Convert.ToInt32(empSalary.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Enter Correct value ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    con.Open();
                    OleDbCommand cmd = new OleDbCommand("Insert into Employees values(" + Convert.ToInt32(empID.Text) + ",'" + empName.Text + "','" + empContact.Text + "','" + empHireDate.Value.ToString("d-M-yyyy") + "'," + Convert.ToInt32(empSalary.Text) + ",'" + empRole.Text + "')", con);
                    cmd.ExecuteNonQuery();
                    cmd = new OleDbCommand($"Insert into EmployeesDuty values({Convert.ToInt32(empID.Text)},'{empName.Text}','Working','{Empaddr.Text}')", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Added Successfully");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Record Already Present", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
                fill();
                SearchCustomerName.Text = "";
                iszeroRecords();
            }
            else
            {
                MessageBox.Show("Contact Length Incorrect", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void empUpdate_Click(object sender, EventArgs e)
        {
            if (checkValid() == false)
            {
                try
                {
                    con.Open();

                    OleDbCommand cmd = new OleDbCommand("Update Employees set Ename='" + empName.Text + "', Ephone= '" + empContact.Text + "', hire_date='" + empHireDate.Value.ToString("d-M-yyyy") + "' ,Esalary=" + Convert.ToInt32(empSalary.Text) + " , Role='" + empRole.Text + "' where ID=" + Convert.ToInt32(empID.Text) + " ", con);
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
                SearchCustomerName.Text = "";
                iszeroRecords();
            }
            else
            {
                MessageBox.Show("Contact Length Incorrect", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            iszeroRecords();
        }

        private void EmployeesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.EmployeesGrid.Rows[e.RowIndex];

                empID.Text = row.Cells["ID"].Value.ToString();
                empName.Text = row.Cells["Ename"].Value.ToString();
                empContact.Text = row.Cells["Ephone"].Value.ToString();
                empHireDate.Text = row.Cells["hire_date"].Value.ToString();
                empSalary.Text = row.Cells["Esalary"].Value.ToString();
                empRole.Text = row.Cells["Role"].Value.ToString();
            }
        }

        private void empName_TextChanged(object sender, EventArgs e)
        {
            if (zeroRecords == false)
            {
                if (empID.Text == "")
                {
                    try
                    {
                        OleDbConnection conforID = formcon.con;

                        OleDbCommand cmdforID = new OleDbCommand("SELECT TOP 1 ID FROM Employees ORDER BY ID DESC", conforID);
                        conforID.Open();
                        empID.Text = (Convert.ToInt32(cmdforID.ExecuteScalar().ToString()) + 1).ToString();
                        conforID.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Something Went Wrong , TRY AGAIN");
                    }
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
            empName.Clear();
            empID.Clear();
            empContact.Clear();
            empSalary.Clear();
            empHireDate.ResetText();
            empRole.Text = "Select Role";
            SearchCustomerName.Text = "";

            
        }

        private void SearchCustomerName_TextChanged(object sender, EventArgs e)
        {
            if (SearchCustomerName.Text == "")
            {
                fill();
            }
            else
            {
                OleDbDataAdapter daS = new OleDbDataAdapter($"Select *from Employees where Ephone='{SearchCustomerName.Text}' ", con);
                DataTable dtS = new DataTable();
                daS.Fill(dtS);
                EmployeesGrid.DataSource = dtS;
                con.Close();
                EmployeesGrid.Columns[0].HeaderText = "ID";
                EmployeesGrid.Columns[1].HeaderText = "Name";
                EmployeesGrid.Columns[2].HeaderText = "Contact";
                EmployeesGrid.Columns[3].HeaderText = "Hire Date";
                EmployeesGrid.Columns[4].HeaderText = "Salary";
                EmployeesGrid.Columns[5].HeaderText = "Role";
            }
        }

        private void statusbtn_Click(object sender, EventArgs e)
        {

            EmployeesDuty em= new EmployeesDuty(CurrD);
            CurrD.loadform(em);
            CurrD.employeeduty = true;
            
        }
    }
}
