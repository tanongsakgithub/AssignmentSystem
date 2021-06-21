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
    public partial class ToDoTeamEditor : Form
    {
        private bool edit = false;
        private ToDoTeam ToDoTeamForm;
        private int projectid;
        private int todoteamid;
        public ToDoTeamEditor()
        {
            InitializeComponent();
        }

        private void ToDoTeamEditor_Load(object sender, EventArgs e)
        {

            this.tblteammemcbbTableAdapter.Fill(this.dataSetAssignDB.tblteammemcbb, projectid);

        }
        public void SetForm(ToDoTeam ToDoTeamForm)
        {
            this.ToDoTeamForm = ToDoTeamForm;
        }
        public void SetTeamProject(int projectid)
        {
            this.projectid = projectid;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String detail = txtdetail.Text;
            int userid = (int)cbbmembers.SelectedValue;
            tbltaskteamTableAdapter adapter = new tbltaskteamTableAdapter();
            DateTime thisDay = DateTime.Today;

            if (txtdetail.Text == "")
            {
                String message = "ระบุชื่อ";
                MessageBox.Show(message);
            }
            else
            {
                if (edit)
                {
                    adapter.UpdateTaskteamid(detail,userid, todoteamid);
                }
                else
                {
                    adapter.InsertTaskTeam(projectid, detail, userid, thisDay.ToString(), "NO");
                }
                
            }
            ToDoTeamForm.RfDataToDoTeam();
            this.Close();

        }
        public void SetToDoTeam(int todoteamid)
        {
            this.todoteamid = todoteamid;
            this.edit = true;
            tbltaskteamTableAdapter adapter = new tbltaskteamTableAdapter();
            DataTable dtable = adapter.GetDataByTaskteamid(todoteamid);
            DataRow drow = dtable.Rows[0];
            txtdetail.Text = drow["detail"].ToString();
            cbbmembers.SelectedValue = int.Parse(drow["userid"].ToString());

        }
    }
}
