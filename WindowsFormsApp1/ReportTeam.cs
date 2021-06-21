using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ReportTeam : Form
    {
        public ReportTeam()
        {
            InitializeComponent();
        }

        private void ReportTeam_Load(object sender, EventArgs e)
        {
            String userid = Login_check.getUsersession().ToString();
            // TODO: This line of code loads data into the 'DataSetAssignDB.tblteamReport' table. You can move, or remove it, as needed.
            this.tblteamReportTableAdapter.Fill(this.DataSetAssignDB.tblteamReport,int.Parse(userid));

            this.reportViewer1.RefreshReport();
        }
    }
}
