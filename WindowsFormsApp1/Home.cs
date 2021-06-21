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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnAddtodome_Click(object sender, EventArgs e)
        {
            TodoMeEditor form = new TodoMeEditor();
            form.SetForm(this);
            form.Show();
        }

        private void btnEdittodome_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                int rowId;
                rowId = dataGridView1.SelectedRows[0].Index;

                TodoMeEditor form = new TodoMeEditor();
                form.SetForm(this);
                form.SetToDoMe(int.Parse(dataGridView1.Rows[rowId].Cells[0].Value.ToString()));
                form.Show();
            }

        }

        private void btnAddproject_Click(object sender, EventArgs e)
        {
            ProjectEditor form = new ProjectEditor();
            form.SetForm(this);
            form.Show();
        }

        private void btnEditproject_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 0)
            {
                int rowId = dataGridView2.SelectedRows[0].Index;
                ProjectEditor form = new ProjectEditor();
                form.SetForm(this);
                form.SetProject(int.Parse(dataGridView2.Rows[rowId].Cells[0].Value.ToString()));
                form.Show();
            }
        }

        private void btnAddTeam_Click(object sender, EventArgs e)
        {
            TeamEditor form = new TeamEditor();
            form.SetForm(this);
            form.Show();
        }

        private void btnEditTeam_Click(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count == 0)
            {
                String message = "เลือกทีม";
                MessageBox.Show(message);

            }
            else
            {
                int rowId = dataGridView4.SelectedRows[0].Index;
                //this.tblteammembersTableAdapter.Fill(this.dataSetAssignDB.tblteammembers, rowId);
                TeamEditor form = new TeamEditor();
                form.SetForm(this);
                form.SetTeam(int.Parse(dataGridView4.Rows[rowId].Cells[0].Value.ToString()));
                form.Show();
            }
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login_check usersession = new Login_check();
            usersession.setUsersession("");
            Login form = new Login();
            form.Show();
            this.Close();
            
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ProfileEditor form = new ProfileEditor();
            form.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Reporttodome form = new Reporttodome();
            form.Show();
        }

        private void btnreportproject_Click(object sender, EventArgs e)
        {
            ReportProject form = new ReportProject();
            form.Show();
        }

        private void btnReportTeam_Click(object sender, EventArgs e)
        {
            ReportTeam form = new ReportTeam();
            form.Show();
        }

        private void btntodoproject_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 0)
            {
                int rowId = dataGridView2.SelectedRows[0].Index;
                ToDoTeam form = new ToDoTeam();
                form.SetToDoProject(int.Parse(dataGridView2.Rows[rowId].Cells[0].Value.ToString()));
                //form.SetForm(this);
                form.Show();
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {

            String userid = Login_check.getUsersession().ToString();
            this.tblmytaskTableAdapter.FillMytask(this.dataSetAssignDB.tblmytask, int.Parse(userid));
            this.tblteamTableAdapter.Fill(this.dataSetAssignDB.tblteam, int.Parse(userid));
            
            this.RfDataProject();
            dataGridView4.Columns[0].Visible = false;
            dataGridView2.Columns[0].Visible = false;
        }
        public void RfDataMytask()
        {
            String userid = Login_check.getUsersession().ToString();
            this.tblmytaskTableAdapter.FillMytask(this.dataSetAssignDB.tblmytask, int.Parse(userid));
        }
        public void RfDataTeam()
        {
            String userid = Login_check.getUsersession().ToString();
            this.tblteamTableAdapter.Fill(this.dataSetAssignDB.tblteam, int.Parse(userid));
        }
        public void RfDataProject()
        {
            String userid = Login_check.getUsersession().ToString();
            this.tblprojectTableAdapter.Fill(this.dataSetAssignDB.tblproject, int.Parse(userid));
        }

        private void btnDeletetodo_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                int rowId;
                rowId = dataGridView1.SelectedRows[0].Index;
                this.tblmytaskTableAdapter.DeleteMytask(int.Parse(dataGridView1.Rows[rowId].Cells[0].Value.ToString()));
                RfDataMytask();
            }
            
        }

        private void btnDeletetodome_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                int rowId;
                rowId = dataGridView1.SelectedRows[0].Index;
                this.tblmytaskTableAdapter.UpdateStatus("YES", int.Parse(dataGridView1.Rows[rowId].Cells[0].Value.ToString()));
                RfDataMytask();
            }
            
        }
        public void RefreshMembers(int rowt)
        {
            //this.tblteammembersTableAdapter.Fill(this.dataSetAssignDB.tblteammembers, rowt);
            this.tblteammembersTableAdapter.Fill(this.dataSetAssignDB.tblteammembers, rowt);
        }

        private void dataGridView4_Click(object sender, EventArgs e)
        {
            int rowId;
            if (dataGridView4.SelectedRows.Count != 0)
            {
                rowId = dataGridView4.SelectedRows[0].Index;
                //this.tblteammembersTableAdapter.Fill(this.dataSetAssignDB.tblteammembers, rowId);
                RefreshMembers(int.Parse(dataGridView4.Rows[rowId].Cells[0].Value.ToString()));
            }
            
        }

        private void btnAddmemers_Click(object sender, EventArgs e)
        {
            if(dataGridView4.SelectedRows.Count == 0 )
            {
                String message = "เลือกทีม";
                MessageBox.Show(message);

            }
            else
            {
                int rowId;
                rowId = dataGridView4.SelectedRows[0].Index;
                int teamid = int.Parse(dataGridView4.Rows[rowId].Cells[0].Value.ToString());
                TeamEditorAddmembers form = new TeamEditorAddmembers();
                form.SetForm(this);
                form.SetTeam(teamid);
                form.Show();

            }
            
        }

        private void btnDeletemembers_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count == 0)
            {
                String message = "เลือกสมาชิก";
                MessageBox.Show(message);
            }
            else
            {
                int rowId = dataGridView3.SelectedRows[0].Index;
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                String message = "ยืนยันการลบ";
                String title = "alert";
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    this.tblteammembersTableAdapter.Deletemembers(int.Parse(dataGridView3.Rows[rowId].Cells[2].Value.ToString()));
                    String success = "สำเร็จ";
                    MessageBox.Show(success);
                    rowId = dataGridView4.SelectedRows[0].Index;
                    RefreshMembers(int.Parse(dataGridView4.Rows[rowId].Cells[0].Value.ToString()));
                }
                else
                {
                    String cancel = "ยกเลิก";
                    MessageBox.Show(cancel);
                }
            }
        }

        private void btnDeleteteam_Click(object sender, EventArgs e)
        {
            if (dataGridView4.SelectedRows.Count != 0)
            {
                int rowId = dataGridView4.SelectedRows[0].Index;
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                String message = "ยืนยันการลบ";
                String title = "alert";
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    this.tblteamTableAdapter.DeleteTeam(int.Parse(dataGridView4.Rows[rowId].Cells[0].Value.ToString()));

                    String success = "สำเร็จ";
                    MessageBox.Show(success);
                    RfDataTeam();
                }
                else
                {
                    String cancel = "ยกเลิก";
                    MessageBox.Show(cancel);
                }
            }
        }

        private void btnDeleteproject_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 0)
            {
                int rowId = dataGridView2.SelectedRows[0].Index;
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                String message = "ยืนยันการลบ";
                String title = "alert";
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    this.tblprojectTableAdapter.DeleteProject(int.Parse(dataGridView2.Rows[rowId].Cells[0].Value.ToString()));
                    String success = "สำเร็จ";
                    MessageBox.Show(success);
                    RfDataProject();
                }
                else
                {
                    String cancel = "ยกเลิก";
                    MessageBox.Show(cancel);
                }
            }
        }
    }
}
