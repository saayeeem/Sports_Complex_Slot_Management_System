using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using MetroFramework.Forms;

namespace SportsComplex
{
    public partial class FormLogIn : MetroForm
    {
        internal DataAccess Da { get; set; }
        internal string Sql { get; set; }
        internal DataSet Ds { get; set; }
        internal DataTable Dt { get; set; }

        
        public FormLogIn()
        {
            InitializeComponent();
            this.Da = new DataAccess();



        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            CommonClass.UserID = this.txtLoginID.Text;
            try
            {
                this.Sql = @"select *  from user_info
                      where userid = '" + this.txtLoginID.Text + "' and password = '" + this.txtPassword.Text + "';";

                Dt = this.Da.ExecuteQueryTable(this.Sql);
                string a = Dt.Rows[0][6].ToString();



                if (a == "Admin" || a == "admin")
                {
                    MessageBox.Show("Login Sccessfull Admin");
                    FormAdminDashBoard admin = new FormAdminDashBoard();
                    this.Hide();
                    admin.Show();
                }
                else if (a == "User" || a == "user")
                {
                    MessageBox.Show("Login Sccessfull User");
                    FormUserDashBoard user = new FormUserDashBoard();
                    this.Hide();
                    user.Show();
                }

            }

            catch (Exception exc)
            {
                if (String.IsNullOrEmpty(this.txtLoginID.Text) || String.IsNullOrEmpty(this.txtPassword.Text))
                {

                    MessageBox.Show("Fill all the value");

                }
                else if (Dt.Rows.Count == 0)
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
        }
            private void Clear()
            {
                this.txtLoginID.Clear();
                this.txtPassword.Clear();
            }

            private void btnClear_Click(object sender, EventArgs e)
            {
                this.Clear();
            }
        
    }
}