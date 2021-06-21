using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.DataSetAssignDBTableAdapters;

namespace WindowsFormsApp1
{
    public partial class ProjectEditor : Form
    {
        private bool edit = false;
        private Home HomeForm;
        private int projectid;
        public ProjectEditor()
        {
            InitializeComponent();
        }
        public void SetForm(Home HomeForm)
        {
            this.HomeForm = HomeForm;
        }
        private void ProjectEditor_Load(object sender, EventArgs e)
        {
            String userid = Login_check.getUsersession().ToString();
            this.tblteamTableAdapter.FillBy(this.dataSetAssignDB.tblteam, int.Parse(userid));
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String projectname = txtprojectname.Text;
            int teamid = (int)cbbTeam.SelectedValue;
            if (txtprojectname.Text == "")
            {
                String message = "ระบุชื่อโปรเจค";
                MessageBox.Show(message);
            }
            else
            {
                String userid = Login_check.getUsersession().ToString();
                tblprojectTableAdapter adapter = new tblprojectTableAdapter();
                if (edit)
                {
                    adapter.UpdateProject(teamid,projectname,this.projectid);
                }
                else
                {
                    adapter.InsertProject(int.Parse(userid), teamid, projectname);
                }
                

                String message = "สำเร็จ";
                MessageBox.Show(message);
                HomeForm.RfDataProject();
                this.Close();
            }
        }
        public void SetProject(int projectid)
        {
            this.edit = true;
            this.projectid = projectid;
            tblprojectTableAdapter adapter = new tblprojectTableAdapter();
            DataTable dtable = adapter.GetDataByprojectid(this.projectid);
            DataRow drow = dtable.Rows[0];
            txtprojectname.Text = drow["projectname"].ToString();
            cbbTeam.SelectedValue = int.Parse(drow["teamid"].ToString());

        }
    }
}
