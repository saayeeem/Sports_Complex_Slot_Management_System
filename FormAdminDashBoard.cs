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
    public partial class FormAdminDashBoard : MetroForm
    {
        private string b;
        internal DataAccess Da { get; set; }

        internal DataSet Ds { get; set; }


        internal string Sql { get; set; }

        public FormAdminDashBoard()
        {
            InitializeComponent();

            this.Da = new DataAccess();

            this.PopulateGridView();
            this.PopulateGridViewUser();
            this.PopulateGridViewRequest();
           

            this.AutoIdGenerteId();
            this.AutoIdGenerate();
           
        }

        private void PopulateGridView(string sql = "select * from slot_info;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);

            this.dgvSlot.AutoGenerateColumns = false;
            this.dgvSlot.DataSource = this.Ds.Tables[0];
        
        }


        private void FormDashBoard_Load(object sender, EventArgs e)
        {
            this.dgvSlot.ClearSelection();
            this.dgvSlot.Refresh();
            this.dgvUser.ClearSelection();
            this.dgvUser.Refresh();
        }

        //==========================================Slot Information================================================
            private void btnSearchSlot_Click(object sender, EventArgs e)
            {
                this.Sql = @"select * from slot_info where sportstype = '" + this.txtSearchSlot.Text + "';";
                this.PopulateGridView(this.Sql);
            }


            private bool IsValidToSave()
            {
                if (String.IsNullOrEmpty(this.txtSlotID.Text) || String.IsNullOrEmpty(this.cmbSportsType.Text) || String.IsNullOrEmpty(this.txtPerson.Text)
                    || String.IsNullOrEmpty(this.cmbTime.Text) || String.IsNullOrEmpty(this.cmbAvailability.Text))
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
                        DataTable dt = this.Da.ExecuteQueryTable(@"select * from slot_info where slotid = '" + this.txtSlotID.Text + "';");
                        if (dt.Rows.Count == 1)
                        {
                            this.Sql = @"update slot_info set slotid = '" + this.txtSlotID.Text + "', sportstype = '" + this.cmbSportsType.Text + "',person = '" +
                            this.txtPerson.Text + "',time = '" + this.cmbTime.Text + "', availability = '" +
                            this.cmbAvailability.Text + "' where slotid = '" + this.txtSlotID.Text + "';";
                            int count = this.Da.ExecuteUpdateQuery(this.Sql);

                            if (count == 1)
                                MessageBox.Show("Data updated successfully");
                            else
                                MessageBox.Show("Error while updating data");

                       
                        }
                        else if (dt.Rows.Count == 0)
                        {
                            this.Sql = @"insert into slot_info values ('" + this.txtSlotID.Text + "','" + this.cmbSportsType.Text + "','" +
                            this.txtPerson.Text + "','" + this.cmbTime.Text + "','" + this.cmbAvailability.Text + "');";
                            int count = this.Da.ExecuteUpdateQuery(this.Sql);

                            if (count == 1)
                                MessageBox.Show("Data inserted successfully");
                            else
                                MessageBox.Show("Error while inserting data");

                            
                        }
                        this.PopulateGridView();
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

            private void btnDelete_Click(object sender, EventArgs e)
            {
            try
            {
                if (this.dgvSlot.SelectedRows.Count > 0)
                {
                    var slotid = this.dgvSlot.CurrentRow.Cells["slotid"].Value.ToString();
                    string del = "Are you sure want to delete slot " + slotid + "?";
                    DialogResult result = MessageBox.Show(del, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        this.Sql = "delete from slot_info where slotid = '" + slotid + "';";
                        int count = this.Da.ExecuteUpdateQuery(this.Sql);

                        if (count == 1)
                            MessageBox.Show("Slot has been deleted");
                        else
                            MessageBox.Show("Error while deleting data");
                    }
                    else
                    {

                    }

                    this.PopulateGridView();

                }
                else
                    MessageBox.Show("Please select a row first to delete");




            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }

             private void dgvSlot_DoubleClick(object sender, EventArgs e)
            {
                this.txtSlotID.Text = this.dgvSlot.CurrentRow.Cells["slotid"].Value.ToString();
                this.cmbSportsType.Text = this.dgvSlot.CurrentRow.Cells["sportstype"].Value.ToString();
                this.txtPerson.Text = this.dgvSlot.CurrentRow.Cells["person"].Value.ToString();
                this.cmbTime.Text = this.dgvSlot.CurrentRow.Cells["time"].Value.ToString();
                this.cmbAvailability.Text = this.dgvSlot.CurrentRow.Cells["availability"].Value.ToString();

            }
            private void ClearData()
            {
                this.AutoIdGenerteId();//this.txtId.Text = "";
                this.txtSlotID.Text = "";
                this.cmbSportsType.SelectedIndex = -1;
                this.txtPerson.Text = "";
                this.cmbTime.SelectedIndex = -1;
                this.cmbAvailability.SelectedIndex = -1;

                this.dgvSlot.ClearSelection();
                this.PopulateGridView();

        }
            private void btnClear_Click(object sender, EventArgs e)
            {
                this.ClearData();
            }

            public void AutoIdGenerteId()
            {
                Ds = this.Da.ExecuteQuery(@"select slotid from slot_info order by slotid desc;");
                string previousId = this.Ds.Tables[0].Rows[0][0].ToString();
                string[] temp = previousId.Split('-');
                int serialNo = Convert.ToInt32(temp[1]);
                string newId = "S-" + (++serialNo).ToString("000"); // 3 ta digit

                this.txtSlotID.Text = newId;

            }
        //==========================================Slot Information================================================

        private void PopulateGridViewUser(string sql = "select * from user_info;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);

            this.dgvUser.AutoGenerateColumns = false;
            this.dgvUser.DataSource = this.Ds.Tables[0];
        }

        private void btnSearchUser_Click(object sender, EventArgs e)
        {
            this.Sql = @"select * from user_info where username = '" + this.txtSearchUser.Text + "';";
            this.PopulateGridViewUser(this.Sql);
        }
        private bool IsValidToSaveUser()
        {
            if (String.IsNullOrEmpty(this.txtUserID.Text) || String.IsNullOrEmpty(this.txtName.Text) || String.IsNullOrEmpty(this.txtPassword.Text)
                || String.IsNullOrEmpty(this.cmbGender.Text) || String.IsNullOrEmpty(this.txtAge.Text) 
                || String.IsNullOrEmpty(this.cmbType.Text))
            {
                return false;
            }
            else
                return true;

        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            try
            {

                if (this.IsValidToSaveUser())
                {
                    DataTable dt = this.Da.ExecuteQueryTable(@"select * from user_info where userid = '" + this.txtUserID.Text + "';");
                    if (dt.Rows.Count == 1)
                    {
                        this.Sql = @"update slot_info set userid = '" + this.txtUserID.Text + "', username = '" + this.txtName.Text + "', password = '" +
                        this.txtPassword.Text + "', gender = '" + this.cmbGender.Text + "', age = '" +
                        this.txtAge.Text + "', Type = '" + this.cmbType.Text + "' where userid = '" + this.txtUserID.Text + "';";
                        int count = this.Da.ExecuteUpdateQuery(this.Sql);

                        if (count == 1)
                            MessageBox.Show("Data updated successfully");
                        else
                            MessageBox.Show("Error while updating data");


                    }
                    else if (dt.Rows.Count == 0)
                    {
                        this.Sql = @"insert into user_info values ('" + this.txtUserID.Text + "','" + this.txtName.Text + "','" +
                        this.txtPassword.Text + "','" + this.cmbGender.Text + "','" + this.txtAge.Text + "','" + this.cmbType.Text + "');";
                        int count = this.Da.ExecuteUpdateQuery(this.Sql);

                        if (count == 1)
                            MessageBox.Show("Data inserted successfully");
                        else
                            MessageBox.Show("Error while inserting data");


                    }
                    this.PopulateGridViewUser();
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

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvUser.SelectedRows.Count > 0)
                {
                    var userid = this.dgvUser.CurrentRow.Cells["userid"].Value.ToString();
                    string msg = "Are you sure want to delete this UserInfo " + userid + "?";
                    DialogResult result = MessageBox.Show(msg, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        this.Sql = "delete from user_info where userid = '" + userid + "';";
                        int count = this.Da.ExecuteUpdateQuery(this.Sql);

                        if (count == 1)
                            MessageBox.Show("UserInfo has been deleted");
                        else
                            MessageBox.Show("Error while deleting data");
                    }
                    else
                    {

                    }

                    this.PopulateGridViewUser();

                }
                else
                    MessageBox.Show("Please select a row first to delete");




            }
            catch (Exception exc)
            {
                MessageBox.Show("Error: " + exc.Message);
            }
        }
     

        private void ClearUserData()
        {
      
            this.AutoIdGenerate();//this.txtId.Text = "";
            this.txtUserID.Text = "";
            this.txtName.Text = "";
            this.txtPassword.Text = "";
            this.cmbGender.Text = "";
            this.txtAge.Text = "";
            this.cmbType.Text = "";

            this.dgvUser.ClearSelection();
            this.PopulateGridViewUser();

        }
        private void btnClearUser_Click(object sender, EventArgs e)
        {
            this.ClearUserData();
        }

        private void dgvUser_DoubleClick(object sender, EventArgs e)
        {
            this.txtUserID.Text = this.dgvUser.CurrentRow.Cells["userid"].Value.ToString();
            this.txtName.Text = this.dgvUser.CurrentRow.Cells["username"].Value.ToString();
            this.txtPassword.Text = this.dgvUser.CurrentRow.Cells["password"].Value.ToString();
            this.cmbGender.Text = this.dgvUser.CurrentRow.Cells["gender"].Value.ToString();
            this.txtAge.Text = this.dgvUser.CurrentRow.Cells["age"].Value.ToString();
            this.cmbType.Text = this.dgvUser.CurrentRow.Cells["type"].Value.ToString();
        }

        //auto id generate////
        private void AutoIdGenerate()
        {
            if (this.cmbType.SelectedIndex == 0)
            {

                Ds = this.Da.ExecuteQuery(@"select userid from user_info where type = 'Admin' order by userid desc;");
              
                string previousId = this.Ds.Tables[0].Rows[0][0].ToString();
                
                string[] temp = previousId.Split('-');
                int serialNo = Convert.ToInt32(temp[1]);
                string newId = "A-" + (++serialNo).ToString("000");
                this.txtUserID.Text = newId;
            }

            else if (this.cmbType.SelectedIndex == 1)
            {
                this.Sql = @"select userid from user_info where type = 'user' order by userid desc;";
                DataTable dt = this.Da.ExecuteQueryTable(this.Sql);
                string previousId = dt.Rows[0][0].ToString();

                string[] temp = previousId.Split('-');
                int serialNo = Convert.ToInt32(temp[1]);
                string newId = "U-" + (++serialNo).ToString("000");
                this.txtUserID.Text = newId;

            }


    }
        




            //===================================Requested Slot====================================

            private void PopulateGridViewRequest(string sql = "select * from user_info u,request_info r where u.userid = r.userid;")
        {
            this.Ds = this.Da.ExecuteQuery(sql);

            this.dgvRequestAdmin.AutoGenerateColumns = false;
            this.dgvRequestAdmin.DataSource = this.Ds.Tables[0];
        }

        private void dgvRequest_DoubleClick(object sender, EventArgs e)
        {
            this.txtReqID.Text = this.dgvRequestAdmin.CurrentRow.Cells["reqid"].Value.ToString();
            this.cmbStatusRequest.Text = this.dgvRequestAdmin.CurrentRow.Cells["status"].Value.ToString();
        }

   
        private void btnEditRequest_Click(object sender, EventArgs e)
        {

            DataTable dt = this.Da.ExecuteQueryTable(@"select * from request_info where reqid = '" + this.txtReqID.Text + "';");
            if (dt.Rows.Count == 1)
            {
                this.Sql = @"update request_info set status = '" + this.cmbStatusRequest.Text + "' where reqid = '" + this.txtReqID.Text + "';";
                int count = this.Da.ExecuteUpdateQuery(this.Sql);

                if (count == 1)
                    MessageBox.Show("Status updated successfully");
                else
                    MessageBox.Show("Error while updating Status");

              
                FormUserDashBoard f = new FormUserDashBoard();
                Notifications n = new Notifications(f.Notify);
                n("you have 1 new notifaction");
                 this.PopulateGridViewRequest();

            }
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

        private void optionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormRulesDashBoard rules = new FormRulesDashBoard();
            this.Hide();
            rules.Show();
          
        }
        private void dataToolStripMenuItem_Click(object sender, EventArgs e)
        {

            FormAdminDashBoard admin = new FormAdminDashBoard();
            this.Hide();
            admin.Show();


        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.AutoIdGenerate();
        }

        private void btnRequestedSearchSlot_Click(object sender, EventArgs e)
        {
            this.Sql = @"select * from request_info where status = '" + this.txtSearchRequest.Text + "';";
            this.PopulateGridViewRequest(this.Sql);
        }
    }
}
