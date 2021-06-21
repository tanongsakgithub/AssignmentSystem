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
    public partial class ToDoTeam : Form
    {
        private int projectid;
        public ToDoTeam()
        {
            InitializeComponent();
        }

        private void ToDoTeam_Load(object sender, EventArgs e)
        {
            RfDataToDoTeam();
        }
        public void RfDataToDoTeam()
        {
            this.tbltaskteamTableAdapter.Fill(this.dataSetAssignDB.tbltaskteam, projectid);
            
        }
        private void btnreportproject_Click(object sender, EventArgs e)
        {
            Reporttodoteam form = new Reporttodoteam();
            form.Show();
        }

        private void btnAddtodoteam_Click(object sender, EventArgs e)
        {
            ToDoTeamEditor form = new ToDoTeamEditor();
            form.SetTeamProject(this.projectid);
            form.SetForm(this);
            form.Show();
        }

        private void btnEdittodoteam_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count !=0 )
            {
                int rowId = dataGridView1.SelectedRows[0].Index;
                ToDoTeamEditor form = new ToDoTeamEditor();
                form.SetToDoTeam(int.Parse(dataGridView1.Rows[rowId].Cells[0].Value.ToString()));
                form.SetTeamProject(this.projectid);
                form.SetForm(this);
                form.Show();
            }
        }

        private void btnDeletetodome_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                int rowId = dataGridView1.SelectedRows[0].Index;
                this.tbltaskteamTableAdapter.UpdateStatus("YES",int.Parse(dataGridView1.Rows[rowId].Cells[0].Value.ToString()));
                RfDataToDoTeam();
            }
        }
        public void SetToDoProject(int projectid)
        {
            this.projectid = projectid;
        }

        private void btnDeletetodoteam_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                int rowId = dataGridView1.SelectedRows[0].Index;
                this.tbltaskteamTableAdapter.DeleteTaskteam(int.Parse(dataGridView1.Rows[rowId].Cells[0].Value.ToString()));
                RfDataToDoTeam();
            }
        }
    }
}
