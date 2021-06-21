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
    public partial class TeamEditor : Form
    {
        private bool edit = false;
        private Home HomeForm;
        private int teamid;
        public TeamEditor()
        {
            InitializeComponent();
        }
        public void SetForm(Home HomeForm)
        {
            this.HomeForm = HomeForm;
        }
        private void btnAddmember_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String teamname = txtteamname.Text;
            String userid = Login_check.getUsersession();
            if (txtteamname.Text == "")
            {
                String message = "รุะบชื่อทีม";
                MessageBox.Show(message);
            }

            else
            {

                tblteamTableAdapter adapter = new tblteamTableAdapter();
                if (edit)
                {
                    adapter.UpdateTeam(teamname, this.teamid);
                }
                else
                {
                    adapter.InsertTeam2(int.Parse(userid), teamname);
                }
                

                HomeForm.RfDataTeam();
                this.Close();
            }
        }

        private void btnAddmembers_Click(object sender, EventArgs e)
        {
            TeamEditorAddmembers form = new TeamEditorAddmembers();
            form.Show();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

        }

        private void TeamEditor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetAssignDB.tbluser' table. You can move, or remove it, as needed.
            //this.tbluserTableAdapter.FillUser(this.dataSetAssignDB.tbluser);

        }

        private void btnAddlist_Click(object sender, EventArgs e)
        {

        }
        public void SetTeam(int teamid)
        {
            this.teamid = teamid;
            this.edit = true;
            tblteamTableAdapter adapter = new tblteamTableAdapter();
            DataTable dtable = adapter.GetDataByTeamid(teamid);
            DataRow drow = dtable.Rows[0];
            txtteamname.Text = drow["teamname"].ToString();

        }
    }
}
