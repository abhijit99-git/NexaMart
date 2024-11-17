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
    public partial class EmployeesDuty : Form
    {
        Form1 formcon = new Form1();
        OleDbConnection con;
        Dashboard CurrD;
       
        public EmployeesDuty(Dashboard CD)
        {
            InitializeComponent();
            CurrD = CD;
        }



        private void EmployeesDuty_Load(object sender, EventArgs e)
        {
            con = formcon.con;
            con.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("Select *from EmployeesDuty where 1=0 order by emp_id", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            EmployeesGrid.DataSource = dt;
            con.Close();
            EmployeesGrid.Columns[0].HeaderText = "ID";
            EmployeesGrid.Columns[1].HeaderText = "Name";
            EmployeesGrid.Columns[2].HeaderText = "Status";
            EmployeesGrid.Columns[3].HeaderText = "Address";
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            CurrD.employeeduty = false;
            CurrD.loadHomeOption();
    
        }

        int id = 0;
        private void EmployeesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.EmployeesGrid.Rows[e.RowIndex];

                Empaddr.Text = row.Cells["emp_addr"].Value.ToString();
                comboBox1.Text = row.Cells["status"].Value.ToString();
                String idn = row.Cells["emp_id"].Value.ToString();
                id=Convert.ToInt32(idn);

            }
        }

        private void comboBox1_DropDownClosed(object sender, EventArgs e)
        {
            Empaddr.Focus();
        }

        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void Searchemp_TextChanged(object sender, EventArgs e)
        {

            if (Searchemp.Text == "")
            {
                con = formcon.con;
                con.Open();
                OleDbDataAdapter da = new OleDbDataAdapter("Select *from EmployeesDuty where 1=0 order by emp_id", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                EmployeesGrid.DataSource = dt;
                con.Close();
                EmployeesGrid.Columns[0].HeaderText = "ID";
                EmployeesGrid.Columns[1].HeaderText = "Name";
                EmployeesGrid.Columns[2].HeaderText = "Status";
                EmployeesGrid.Columns[3].HeaderText = "Address";
            }
            else
            {
                OleDbDataAdapter daS = new OleDbDataAdapter($"Select *from EmployeesDuty where emp_name='{Searchemp.Text}' ", con);
                DataTable dtS = new DataTable();
                daS.Fill(dtS);
                EmployeesGrid.DataSource = dtS;
                con.Close();
                EmployeesGrid.Columns[0].HeaderText = "ID";
                EmployeesGrid.Columns[1].HeaderText = "Name";
                EmployeesGrid.Columns[2].HeaderText = "Status";
                EmployeesGrid.Columns[3].HeaderText = "Address";
            }
        }

        private void empUpdate_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Select Record", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                try
                {
                    con.Open();

                    OleDbCommand cmd = new OleDbCommand($"Update EmployeesDuty set emp_addr='{Empaddr.Text}',status='{comboBox1.Text}'  where emp_id={id}", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully");


                    //refresh


                    OleDbDataAdapter daS = new OleDbDataAdapter($"Select *from EmployeesDuty where emp_name='{Searchemp.Text}' ", con);
                    DataTable dtS = new DataTable();
                    daS.Fill(dtS);
                    EmployeesGrid.DataSource = dtS;
                    con.Close();
                    EmployeesGrid.Columns[0].HeaderText = "ID";
                    EmployeesGrid.Columns[1].HeaderText = "Name";
                    EmployeesGrid.Columns[2].HeaderText = "Status";
                    EmployeesGrid.Columns[3].HeaderText = "Address";

                    //refresh end
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Record Not Present", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            Empaddr.Text = "";
            comboBox1.Text = "Select Status";
            Searchemp.Text = "";
        }
    }
}
