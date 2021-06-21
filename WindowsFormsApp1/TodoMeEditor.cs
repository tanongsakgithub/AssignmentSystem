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
    public partial class TodoMeEditor : Form
    {
        private bool edit = false;
        private Home HomeForm;
        private int taskid;
        public TodoMeEditor()
        {
            InitializeComponent();
        }
        public void SetForm(Home HomeForm)
        {
            this.HomeForm = HomeForm;
        }
        private void TodoMeEditor_Load(object sender, EventArgs e)
        {

        }
        public void SetToDoMe(int taskid)
        {
            this.edit = true;
            this.taskid = taskid;
            tblmytaskTableAdapter adapter = new tblmytaskTableAdapter();
            DataTable dtable = adapter.GetDataByMytaskid(this.taskid);
            DataRow drow = dtable.Rows[0];
            txtdetail.Text = drow["detail"].ToString();


        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            String detail = txtdetail.Text;
            String userid = Login_check.getUsersession();
            DateTime thisDay = DateTime.Today;
            tblmytaskTableAdapter adapter = new tblmytaskTableAdapter();
            if (edit)
            {
                adapter.UpdateMytask(detail, this.taskid);
            }
            else
            {
                adapter.InsertMytask(detail, int.Parse(userid), thisDay.ToString(), "NO");
            }
            
            HomeForm.RfDataMytask();
            this.Close();
        }
        
    }
}
