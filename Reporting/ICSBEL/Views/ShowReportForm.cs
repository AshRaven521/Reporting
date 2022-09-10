using ICSBEL.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ICSBEL.Views
{
    public partial class ShowReportForm : Form
    {
        private string excelFilePath = "";

        public ShowReportForm(string path)
        {
            InitializeComponent();
            excelFilePath = path;
        }

        private void showReportForm_Load(object sender, EventArgs e)
        {
            var data = Excel.LoadReport(excelFilePath);
            reportGridView.DataSource = data;
        }
    }
}
