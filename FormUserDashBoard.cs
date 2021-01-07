using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace SportsComplex
{
    internal delegate void Notifications(string c);
    public partial class FormUserDashBoard : MetroForm
    {
        private string a;
        internal DataAccess Da { get; set; }

        internal DataSet Ds { get; set; }






        internal string Sql { get; set; }
        public FormUserDashBoard()
        {
            InitializeComponent();

            this.Da = new DataAccess();

            this.PopulateGridView();
            this.PopulateGridViewRequest();

            this.AutoIdGenerteId();
           

        }



        private void FormUserDashBoard_Load(object sender, EventArgs e)
        {
            this.dgvSlot.ClearSelection();
            this.dgvSlot.Refresh();

            this.txtUserID.Text = CommonClass.UserID;
        }
        private void PopulateGridView(string sql = "select * from slot_info;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);

            this.dgvSlot.AutoGenerateColumns = false;
            this.dgvSlot.DataSource = this.Ds.Tables[0];

        }
        private void btnSearchSlot_Click(object sender, EventArgs e)
        {
            this.Sql = @"select * from slot_info where sportstype = '" + this.txtSearch.Text + "'";
            this.PopulateGridView(this.Sql);
        }


        private bool IsValidToSave()
        {
            if (String.IsNullOrEmpty(this.txtSlotID.Text) || String.IsNullOrEmpty(this.txtSportsType.Text) || String.IsNullOrEmpty(this.txtPerson.Text)
                || String.IsNullOrEmpty(this.txtTime.Text) || String.IsNullOrEmpty(this.txtStatusUser.Text))
            {
                return false;
            }
            else
                return true;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            

            try
            {

                if (this.IsValidToSave())
                {
                    DataTable dt = this.Da.ExecuteQueryTable(@"select * from request_info where reqid = '" + this.txtReqID.Text + "';");
                   if (dt.Rows.Count == 0)
                    {
                        this.Sql = @"insert into request_info values ('" + this.txtUserID.Text + "','" + this.txtSlotID.Text + "','" +
                        this.txtPerson.Text + "','" + this.txtTime.Text + "','" + this.txtStatusUser.Text + "','" + this.txtSportsType.Text + "','" + this.txtReqID.Text + "');";
                        int count = this.Da.ExecuteUpdateQuery(this.Sql);

                        if (count == 1)
                            MessageBox.Show("Slot Requested successfully");
                        else
                            MessageBox.Show("Error while inserting Slot");


                    }
                    this.PopulateGridViewRequest();
                    this.ClearData();
                }
                else
                {
                    MessageBox.Show("Please fill all the value");
                }
            }

            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }
        
    
  
        private void dgvSlot_DoubleClick(object sender, EventArgs e)
        {
            this.txtSlotID.Text = this.dgvSlot.CurrentRow.Cells["slotid"].Value.ToString();
            this.txtSportsType.Text = this.dgvSlot.CurrentRow.Cells["sportstype"].Value.ToString();
            this.txtPerson.Text = this.dgvSlot.CurrentRow.Cells["person"].Value.ToString();
            this.txtTime.Text = this.dgvSlot.CurrentRow.Cells["time"].Value.ToString();



        }
        private void ClearData()
        {
            this.AutoIdGenerteId();//this.txtId.Text = "";
            this.txtSlotID.Text = "";
            this.txtSportsType.Text = "";
            this.txtPerson.Text = "";
            this.txtTime.Text = "";
           

            this.dgvSlot.ClearSelection();
            this.PopulateGridView();

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearData();
        }

        public void AutoIdGenerteId()
        {
            Ds = this.Da.ExecuteQuery(@"select reqid from request_info order by reqid desc;");
            string previousId = this.Ds.Tables[0].Rows[0][0].ToString();
            string[] temp = previousId.Split('-');
            int serialNo = Convert.ToInt32(temp[1]);
            string newId = "R-" + (++serialNo).ToString("000"); // 3 ta digit

            this.txtReqID.Text = newId;

        }

        private void PopulateGridViewRequest(string sql = @"select * from request_info;")
        {
            this.txtUserID.Text = CommonClass.UserID;
            this.Sql = @"select * from request_info where userid = '" + this.txtUserID.Text + "';";
            this.Ds = this.Da.ExecuteQuery(this.Sql);

            this.dgvRequestUser.AutoGenerateColumns = false;
            this.dgvRequestUser.DataSource = this.Ds.Tables[0];
        }

        public void Notify(string b)
        {
            this.lblNotification.Text = b;
        }


        private void Logout_Click(object sender, EventArgs e)
        {
            string msg = "Are you sure you want to logout?";
            DialogResult result = MessageBox.Show(msg, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                FormLogIn login = new FormLogIn();
                login.Show();
                this.Hide();
            }
            else
            {

            }


        }

        private void Exit_Click(object sender, EventArgs e)
        {

            string msg = "Are you sure you want to Exit?";
            DialogResult result = MessageBox.Show(msg, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }


        }

        private void lblNotification_TextChanged(object sender, EventArgs e)
        {
            
            this.Notify(a);
        }

        private void btnRequestedSearchSlot_Click(object sender, EventArgs e)
        {
            this.Sql = @"select * from request_info where status = '" + this.txtSearchRequest.Text + "';";
            this.Ds = this.Da.ExecuteQuery(this.Sql);

            this.dgvRequestUser.AutoGenerateColumns = false;
            this.dgvRequestUser.DataSource = this.Ds.Tables[0];
        }

    }
}
