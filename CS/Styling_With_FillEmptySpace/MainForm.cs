using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraReports.UI;

namespace StylingWithFillEmptySpace {
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            XtraReport1 report = new XtraReport1();
            ReportPrintTool tool = new ReportPrintTool(report);
            tool.ShowPreviewDialog();
            this.Close();
        }
    }
}