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
       
        public EmployeesDuty()
        {
            InitializeComponent();
        }

        //MoveForm
        private const int cGrip = 16;
        private const int cCaption = 32;
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }

                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }
        //EndMoveForm



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
            this.Close();

    
        }

        private void EmployeesGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.EmployeesGrid.Rows[e.RowIndex];

                Empaddr.Text = row.Cells["emp_addr"].Value.ToString();

            }
        }
    }
}
