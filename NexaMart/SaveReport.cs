﻿using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NexaMart
{
    public partial class SaveReport : Form
    {

        string total="0.00";
        string name = "";
        string contact = "";
        string address = "";
        public int custid = 0;

        public SaveReport(int cn,string rec)
        {
            InitializeComponent();
           custid = cn;

            Form1 formtot = new Form1();
            OleDbConnection contot = formtot.con;

            if (contot != null)
            {
                try
                {
                    contot.Open();

                    // total
                    OleDbCommand cmd = new OleDbCommand("Select sum(total_amt) from Billing", contot);
                    var result = cmd.ExecuteScalar();
                    total = result != null ? result.ToString() : "0.00";

                    // name
                    cmd = new OleDbCommand($"Select cust_name from Customers where cust_id={custid}", contot);
                    result = cmd.ExecuteScalar();
                    name = result != null ? result.ToString() : "customer";

                    // contact
                    cmd = new OleDbCommand($"Select cust_number from Customers where cust_id={custid}", contot);
                    result = cmd.ExecuteScalar();
                    contact = result != null ? result.ToString() : "";

                    // address
                    cmd = new OleDbCommand($"Select cust_add from Customers where cust_id={custid}", contot);
                    result = cmd.ExecuteScalar();
                    address = result != null ? result.ToString() : "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    contot.Close();
                }
            }
            else
            {
                MessageBox.Show("Database Error");
            }

            Random random = new Random();
            string datee = DateTime.Now.ToString("d-M-yyyy");
            BillingReport report = new BillingReport();
            report.SetParameterValue(0, rec);
            report.SetParameterValue(1, "₹ "+total);
            report.SetParameterValue(2, name);
            report.SetParameterValue(3, contact);
            report.SetParameterValue(4, address);
            report.SetParameterValue(5, datee);
            report.SetParameterValue(6, random.Next(100000,999999999).ToString());

            UpdateReportDatabaseConnection(report); 



            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();


            try
            {
                string mainNexaMartDirectory = Directory.GetParent(Directory.GetParent(Directory.GetParent(Application.StartupPath).FullName).FullName).FullName;
                string outputDirectory = Path.Combine(mainNexaMartDirectory, "Bills");

                if (!Directory.Exists(outputDirectory))
                {
                    Directory.CreateDirectory(outputDirectory);
                }

                string fileN = name + " " + DateTime.Now.ToString("dddd, dd MMMM yyyy HH-mm-ss");
                string fileName = $"{fileN}.pdf";
                string fullFilePath = Path.Combine(outputDirectory, fileName);

         
                report.ExportToDisk(ExportFormatType.PortableDocFormat, fullFilePath);

                MessageBox.Show($"Report saved as PDF at: {fullFilePath}", "Export Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void UpdateReportDatabaseConnection(ReportDocument report)
        {
            // Dynamic database path
            string databasePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NexaMartDB.accdb");

            // Update connection for main report tables
            foreach (Table table in report.Database.Tables)
            {
                TableLogOnInfo logOnInfo = table.LogOnInfo;
                logOnInfo.ConnectionInfo.DatabaseName = databasePath;
                table.ApplyLogOnInfo(logOnInfo);
            }

            // Update connection for all subreports
            foreach (Section section in report.ReportDefinition.Sections)
            {
                foreach (ReportObject reportObject in section.ReportObjects)
                {
                    if (reportObject.Kind == ReportObjectKind.SubreportObject)
                    {
                        SubreportObject subreportObject = (SubreportObject)reportObject;
                        ReportDocument subReportDocument = subreportObject.OpenSubreport(subreportObject.SubreportName);

                        foreach (Table table in subReportDocument.Database.Tables)
                        {
                            TableLogOnInfo logOnInfo = table.LogOnInfo;
                            logOnInfo.ConnectionInfo.DatabaseName = databasePath;
                            table.ApplyLogOnInfo(logOnInfo);
                        }
                    }
                }
            }
        }





    }
}
