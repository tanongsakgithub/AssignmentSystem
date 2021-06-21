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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void llbRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register form = new Register();
            form.Show();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String username = txtusername.Text;
            String password = txtpassword.Text;
            tbluserTableAdapter adapter = new tbluserTableAdapter();
            DataTable dtable = adapter.GetDataByChecklogin(username, password);
            int row = (int)dtable.Rows.Count;
            if (row == 0)
            {
                String message = "ชื่อผู้ใช้และรหัสผ่านไม่ถูกต้อง";
                MessageBox.Show(message);
            }
            else
            {
                DataRow drow = dtable.Rows[0];
                int id = (int)drow["userid"];
                
                Login_check userAuthen = new Login_check();
                userAuthen.setUsersession(id.ToString());
                Home form = new Home();
                form.Show();
                this.Hide();
            }


        }

        private void chPassshow_CheckedChanged(object sender, EventArgs e)
        {
            if (chPassshow.Checked)
            {
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '*';
            }
        }
    }
}
