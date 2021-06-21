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
    public partial class ReportProject : Form
    {
        public ReportProject()
        {
            InitializeComponent();
        }

        private void ReportProject_Load(object sender, EventArgs e)
        {
            String userid = Login_check.getUsersession().ToString();
            // TODO: This line of code loads data into the 'DataSetAssignDB.tblproject' table. You can move, or remove it, as needed.
            this.tblprojectTableAdapter.Fill(this.DataSetAssignDB.tblproject, int.Parse(userid));

            this.reportViewer1.RefreshReport();
        }
    }
}
