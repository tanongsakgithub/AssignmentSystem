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
    public partial class TeamEditorAddmembers : Form
    {
        private Home HomeForm;
        private int teamid;
        private bool edit = false;
        public TeamEditorAddmembers()
        {
            InitializeComponent();
        }
        public void SetForm(Home HomeForm)
        {
            this.HomeForm = HomeForm;
        }
        public void SetTeam(int teamid)
        {
            this.teamid = teamid;
        }
        private void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtfirstname.Text == "" || txtlastname.Text == "")
            {
                String message = "ห้ามว่าง";
                MessageBox.Show(message);
            }
            else
            {
                String firstname = txtfirstname.Text;
                String lastname = txtlastname.Text;
                this.tbluserTableAdapter.FillByAddmembers(this.dataSetAssignDB.tbluser, firstname, lastname);
            }
        }

        private void TeamEditorAddmembers_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetAssignDB.tbluser' table. You can move, or remove it, as needed.
            //this.tbluserTableAdapter.FillUser(this.dataSetAssignDB.tbluser);
            
        }

        private void btnAddlist_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                String message = "ไม่ได้เลือกรายการ";
                MessageBox.Show(message);

            }
            else
            {
                int rowId;
                rowId = dataGridView1.SelectedRows[0].Index;
                dataGridView2.Rows.Add(dataGridView1.Rows[rowId].Cells[0].Value.ToString(),
                dataGridView1.Rows[rowId].Cells[1].Value.ToString(),
                dataGridView1.Rows[rowId].Cells[2].Value.ToString(),
                dataGridView1.Rows[rowId].Cells[3].Value.ToString());
            }
           
        }

        private void btnDeletemember_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count != 0)
            {
                dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count == 0)
            {
                String message = "โปรดเพิ่มสมาชิกในทีม";
                MessageBox.Show(message);

            }
            else
            {
                for (int i = 0; i <= dataGridView2.Rows.Count; i++)
                {
                    int userid = int.Parse(dataGridView2.Rows[i].Cells[0].Value.ToString());
                    int teamid = this.teamid;
                    tblteammembersTableAdapter adapter = new tblteammembersTableAdapter();
                    adapter.Insertmembers(teamid, userid);
                    HomeForm.RefreshMembers(this.teamid);
                    this.Close();
                }
            }

            
        }
    }
}
