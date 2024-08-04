using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Xml.Linq;

namespace NexaMart
{

    public partial class ProfileForm : Form
    {
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\C# programs\VS PROGRAMS\\NexaMart\NexaMart\NexaMartDB.accdb");

        public ProfileForm()
        {
            InitializeComponent();

        }

        public ProfileForm(string userN, string userP)
        {
            InitializeComponent();
            AdminProfileName.Text = userN;
            PasswordProfileName.Text = userP;

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void updatePic_Click(object sender, EventArgs e)
        {
            if (changeName.Text == "" || changePass.Text == "")
            {
                MessageBox.Show("Enter new username and password","", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name = changeName.Text;
                string pass = changePass.Text;
                string currName = AdminProfileName.Text;

                try
                {
                    con.Open();
                    string query = "UPDATE Admin SET ad_name = '" + name + "', ad_password = '" + pass + "' WHERE ad_name = '" + currName + "'";
                    OleDbCommand cmd = new OleDbCommand(query, con);

                    cmd.ExecuteNonQuery();

                    AdminProfileName.Text = name;
                    PasswordProfileName.Text = pass;
                    MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error " + ex);
                }
                finally
                {
                    con.Close();
                }
            }

        }
        private void updateText_Click(object sender, EventArgs e)
        {
            if (changeName.Text == "" || changePass.Text == "")
            {
                MessageBox.Show("Enter new username and password", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string name = changeName.Text;
                string pass = changePass.Text;
                string currName = AdminProfileName.Text;

                try
                {
                    con.Open();
                    string query = "UPDATE Admin SET ad_name = '" + name + "', ad_password = '" + pass + "' WHERE ad_name = '" + currName + "'";
                    OleDbCommand cmd = new OleDbCommand(query, con);

                    cmd.ExecuteNonQuery();

                    AdminProfileName.Text = name;
                    PasswordProfileName.Text = pass;
                    MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error " + ex);
                }
                finally
                {
                    con.Close();
                }
            }
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string query ="Select ReceiptName from Admin where ad_name='"+AdminProfileName.Text+"'";
                OleDbCommand cmd = new OleDbCommand(query, con);

               OleDbDataReader read= cmd.ExecuteReader();
                if (read.Read())
                {
                    ReceiptName.Text = read["ReceiptName"].ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error " + ex);
            }
            finally
            {
                con.Close();
            }
        }

        private void ReceiptApply_Click(object sender, EventArgs e)
        {
            if (ReceiptName.Text == "")
            {
                MessageBox.Show("Enter Receipt Name", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "UPDATE Admin SET ReceiptName = '" + ReceiptName.Text + "' WHERE ad_name = '" + AdminProfileName.Text + "'";
                    OleDbCommand cmd = new OleDbCommand(query, con);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Receipt Name updated ", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("error " + ex);
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
