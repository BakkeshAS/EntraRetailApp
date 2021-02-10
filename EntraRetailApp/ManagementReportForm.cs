/* Student Name: Bakkesh Shivakumar Aladahalli
 * Student ID: 20230557
 * Date: 11/01/2021
 * Assignment: 4
 * Assignment: Electronic Point of Sale (EPOS) Application
 * ManagementReportForm.cs */

using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EntraRetailApp
{
    public partial class ManagementReportForm : Form
    {
        // Global variable which is public and can be accessed using
        // an instance of this class, so that it can be populated 
        // and displayed in the ReportListView 
        public List<string[]> ReportData = new List<string[]>();

        public ManagementReportForm()
        {
            InitializeComponent();
        }
        // when ManagementReportForm loads for very first time, 
        // this event is triggered.
        private void ManagementReportForm_Load(object sender, EventArgs e)
        {
            const int REPORTSIZE = 5;
            // Update the date and time in the UI.
            DateLabel.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy");
            TimeLabel.Text = DateTime.Now.ToString("hh:mm tt");

            // Populate the Report ListView 
            foreach(string[] Item in ReportData)
            {
                string[] ReportItem = new string[REPORTSIZE];
                for (int ColIndex = 0; ColIndex < REPORTSIZE; ColIndex++)
                {
                    ReportItem[ColIndex] = Item[ColIndex];
                }
                ListViewItem ReportListViewItem = new ListViewItem(ReportItem);
                ReportListView.Items.Add(ReportListViewItem);
            }
        }
    }
}
