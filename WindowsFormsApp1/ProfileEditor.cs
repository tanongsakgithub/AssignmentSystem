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
    public partial class ProfileEditor : Form
    {
        public ProfileEditor()
        {
            InitializeComponent();
        }

        private void ProfileEditor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetAssignDB.tblprovince' table. You can move, or remove it, as needed.
            this.tblprovinceTableAdapter.Fill(this.dataSetAssignDB.tblprovince);
            String userid = Login_check.getUsersession().ToString();
            tbluserTableAdapter adapter = new tbluserTableAdapter();
            DataTable dtable = adapter.GetDataByUserinfo(int.Parse(userid));
            DataRow drow = dtable.Rows[0];

            txtfirstname.Text = drow["firstname"].ToString();
            txtlastname.Text = drow["lastname"].ToString();
            txtnickname.Text = drow["nickname"].ToString();
            txtphone.Text = drow["phone"].ToString();
            dtpdateofbirth.Value = DateTime.Parse(drow["dateofbirth"].ToString());
            cbbprovince.SelectedValue = int.Parse(drow["provinceid"].ToString());
            txtemail.Text = drow["email"].ToString();
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String userid = Login_check.getUsersession().ToString();
            String firstname = txtfirstname.Text;
            String Lastname = txtlastname.Text;
            String Nickname = txtnickname.Text;
            String Phone = txtphone.Text;
            DateTime Dataofbirth = dtpdateofbirth.Value;
            int Provinceid = (int)cbbprovince.SelectedValue;
            String Email = txtemail.Text;
            if (txtfirstname.Text == "" ||
               txtlastname.Text == "" ||
               txtnickname.Text == "" ||
               txtphone.Text == "" ||
               dtpdateofbirth.Text == "" ||
               cbbprovince.Text == "" ||
               txtemail.Text == ""
               )
            {
                String message = "ห้ามเว้นว่าง";
                MessageBox.Show(message);
            }
            else
            {
                tbluserTableAdapter adapter = new tbluserTableAdapter();
                adapter.UpdateUserinfo(firstname, Lastname, Nickname, Phone, Dataofbirth.ToString(), Provinceid, Email, int.Parse(userid));
                String message = "สำเร็จ";
                MessageBox.Show(message);
                this.Close();
            }

        }
    }
}
