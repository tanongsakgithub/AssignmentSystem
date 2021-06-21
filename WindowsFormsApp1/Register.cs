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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String firstname = txtfirstname.Text;
            String Lastname = txtlastname.Text;
            String Nickname = txtnickname.Text;
            String Phone = txtphone.Text;
            DateTime Dataofbirth = dtpdateofbirth.Value;
            int Provinceid = (int)cbbprovince.SelectedValue;
            String Username = txtUsername.Text;
            String Password = txtPassword.Text;
            String ConPass = txtPassCon.Text;
            String Email = txtemail.Text;

            if (txtfirstname.Text == "" ||
               txtlastname.Text == "" ||
               txtnickname.Text == "" ||
               txtphone.Text == "" ||
               dtpdateofbirth.Text == "" ||
               cbbprovince.Text == "" ||
               txtUsername.Text == "" ||
               txtPassword.Text == "" ||
               txtPassCon.Text == "" ||
               txtemail.Text == ""
               )
            {
                String message = "ห้ามเว้นว่าง";
                MessageBox.Show(message);
            }
            else
            {
                tbluserTableAdapter adapter = new tbluserTableAdapter();
                DataTable dtable = adapter.GetDataByCheckusername(Username);
                DataRow drow = dtable.Rows[0];
                int row = (int)drow["Userdupli"];
                if (row == 0)
                {
                    if (ConPass == Password)
                    {
                        adapter.InsertUser(firstname, Lastname, Nickname, Phone, Dataofbirth.ToString(), Provinceid, Username, Password, Email);
                        String message = "สำเร็จ";
                        MessageBox.Show(message);
                        this.Close();
                    }
                    else
                    {
                        String message = "รหัสผ่านไม่ตรงกัน";
                        MessageBox.Show(message);
                    }

                }
                else
                {
                    String message = "ชื่อผู้ใช้งานซ้ำ!!";
                    MessageBox.Show(message);
                }
            }


        }

        private void Register_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSetAssignDB.tblprovince' table. You can move, or remove it, as needed.
            this.tblprovinceTableAdapter.Fill(this.dataSetAssignDB.tblprovince);

        }

        private void cbShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if(cbShowPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtPassCon.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
                txtPassCon.PasswordChar = '*';
            }
        }
    }
}
