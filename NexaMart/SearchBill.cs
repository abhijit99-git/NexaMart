using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NexaMart
{
    public partial class SearchBill : Form
    {
        public SearchBill()
        {
            InitializeComponent();
        }

        private void closeDash_Click(object sender, EventArgs e)
        {
            this.Hide();
            BillNameSearch.Text = "";
        }

        private void dashMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void SearchBill_Load(object sender, EventArgs e)
        {
            BillNameSearch.Focus();
        }

        private void viewbillclick_Click(object sender, EventArgs e)
        {
            if (BillNameSearch.Text == "")
            {
                MessageBox.Show("No PDF files found matching the specified term.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {

                    string mainNexaMartDirectory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName).FullName;
                    string directoryPath = Path.Combine(mainNexaMartDirectory, "Bills");

                    string searchPattern = $"*{BillNameSearch.Text}*.pdf";

                    string[] pdfFiles = Directory.GetFiles(directoryPath, searchPattern, SearchOption.AllDirectories);

                    if (pdfFiles.Length > 0)
                    {
                        foreach (string pdfFile in pdfFiles)
                        {
                            Process.Start(pdfFile);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No PDF files found matching the specified term.", "Search Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
