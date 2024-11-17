using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NexaMart
{
    public partial class ReportsMultiple : Form
    {

        string repo = "";
        public ReportsMultiple(string r)
        {
            InitializeComponent();
            repo= r;
        }

        private void crystalReportViewer2_Load(object sender, EventArgs e)
        {
            /*
            if (repo =="Employee")
            {
                EmpReport report = new EmpReport();
                crystalReportViewer2.ReportSource = report;
                crystalReportViewer2.Refresh();
                crystalReportViewer2.RefreshReport();
            }
            else if (repo == "Order")
            {

                OrdersReport report = new OrdersReport();
                crystalReportViewer2.ReportSource = report;
                crystalReportViewer2.Refresh();
                crystalReportViewer2.RefreshReport();
            
            }
            else if (repo == "Product")
            {

                ProductsReport report = new ProductsReport();
                crystalReportViewer2.ReportSource = report;
                crystalReportViewer2.Refresh();
                crystalReportViewer2.RefreshReport();
            }
            else if (repo == "Supplier")
            {

                SupplierReport report = new SupplierReport();
                crystalReportViewer2.ReportSource = report;
                crystalReportViewer2.Refresh();
                crystalReportViewer2.RefreshReport();
            }
            else if (repo == "Customer")
            {

                CustomerReport report = new CustomerReport();
                crystalReportViewer2.ReportSource = report;
                crystalReportViewer2.Refresh();
                crystalReportViewer2.RefreshReport();
            }
            */

            
            //change
            // Define the dynamic database path
            string databasePath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "NexaMartDB.accdb");

            if (repo == "Employee")
            {
                EmpReport report = new EmpReport();
                UpdateReportDatabaseConnection(report, databasePath);
                crystalReportViewer2.ReportSource = report;
                crystalReportViewer2.Refresh();
                crystalReportViewer2.RefreshReport();
            }
            else if (repo == "Order")
            {
                OrdersReport report = new OrdersReport();
                UpdateReportDatabaseConnection(report, databasePath);
                crystalReportViewer2.ReportSource = report;
                crystalReportViewer2.Refresh();
                crystalReportViewer2.RefreshReport();
            }
            else if (repo == "Product")
            {
                ProductsReport report = new ProductsReport();
                UpdateReportDatabaseConnection(report, databasePath);
                crystalReportViewer2.ReportSource = report;
                crystalReportViewer2.Refresh();
                crystalReportViewer2.RefreshReport();
            }
            else if (repo == "Supplier")
            {
                SupplierReport report = new SupplierReport();
                UpdateReportDatabaseConnection(report, databasePath);
                crystalReportViewer2.ReportSource = report;
                crystalReportViewer2.Refresh();
                crystalReportViewer2.RefreshReport();
            }
            else if (repo == "Customer")
            {
                CustomerReport report = new CustomerReport();
                UpdateReportDatabaseConnection(report, databasePath);
                crystalReportViewer2.ReportSource = report;
                crystalReportViewer2.Refresh();
                crystalReportViewer2.RefreshReport();
            }
            
        }


        //change
        private void UpdateReportDatabaseConnection(ReportDocument report, string databasePath)
        {
            foreach (Table table in report.Database.Tables)
           {
                TableLogOnInfo logOnInfo = table.LogOnInfo;
               logOnInfo.ConnectionInfo.DatabaseName = databasePath; // Set dynamic database path
              table.ApplyLogOnInfo(logOnInfo);
           }
        }
    }
}
