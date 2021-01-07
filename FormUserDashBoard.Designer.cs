namespace SportsComplex
{
    partial class FormUserDashBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.txtTime = new MetroFramework.Controls.MetroTextBox();
            this.txtSportsType = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.txtStatusUser = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.txtReqID = new MetroFramework.Controls.MetroTextBox();
            this.lblUserID = new MetroFramework.Controls.MetroLabel();
            this.txtUserID = new MetroFramework.Controls.MetroTextBox();
            this.lblTime = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.lblStatus = new MetroFramework.Controls.MetroLabel();
            this.lblPerson = new MetroFramework.Controls.MetroLabel();
            this.lblSportsType = new MetroFramework.Controls.MetroLabel();
            this.lblSlotID = new MetroFramework.Controls.MetroLabel();
            this.btnClearSlot = new MetroFramework.Controls.MetroButton();
            this.btnSaveSlot = new MetroFramework.Controls.MetroButton();
            this.txtPerson = new MetroFramework.Controls.MetroTextBox();
            this.txtSlotID = new MetroFramework.Controls.MetroTextBox();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.dgvSlot = new MetroFramework.Controls.MetroGrid();
            this.slotid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sportstype = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.person = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.txtSearchRequest = new MetroFramework.Controls.MetroTextBox();
            this.btnRequestedSearchSlot = new System.Windows.Forms.Button();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dgvRequestUser = new MetroFramework.Controls.MetroGrid();
            this.user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reqid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLogout = new MetroFramework.Controls.MetroButton();
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.lblNotification = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlot)).BeginInit();
            this.metroTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestUser)).BeginInit();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(9, 102);
            this.metroTabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 1;
            this.metroTabControl1.Size = new System.Drawing.Size(1177, 561);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroPanel2);
            this.metroTabPage1.Controls.Add(this.metroPanel1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 12;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(1169, 519);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Slot Booking";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 13;
            // 
            // metroPanel2
            // 
            this.metroPanel2.BackColor = System.Drawing.Color.Aqua;
            this.metroPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel2.Controls.Add(this.txtTime);
            this.metroPanel2.Controls.Add(this.txtSportsType);
            this.metroPanel2.Controls.Add(this.metroLabel5);
            this.metroPanel2.Controls.Add(this.metroTextBox2);
            this.metroPanel2.Controls.Add(this.txtStatusUser);
            this.metroPanel2.Controls.Add(this.metroLabel4);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.metroTextBox1);
            this.metroPanel2.Controls.Add(this.txtReqID);
            this.metroPanel2.Controls.Add(this.lblUserID);
            this.metroPanel2.Controls.Add(this.txtUserID);
            this.metroPanel2.Controls.Add(this.lblTime);
            this.metroPanel2.Controls.Add(this.metroLabel3);
            this.metroPanel2.Controls.Add(this.lblStatus);
            this.metroPanel2.Controls.Add(this.lblPerson);
            this.metroPanel2.Controls.Add(this.lblSportsType);
            this.metroPanel2.Controls.Add(this.lblSlotID);
            this.metroPanel2.Controls.Add(this.btnClearSlot);
            this.metroPanel2.Controls.Add(this.btnSaveSlot);
            this.metroPanel2.Controls.Add(this.txtPerson);
            this.metroPanel2.Controls.Add(this.txtSlotID);
            this.metroPanel2.Controls.Add(this.btnSearch);
            this.metroPanel2.Controls.Add(this.txtSearch);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(1169, 312);
            this.metroPanel2.TabIndex = 47;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 11;
            // 
            // txtTime
            // 
            // 
            // 
            // 
            this.txtTime.CustomButton.Image = null;
            this.txtTime.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtTime.CustomButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtTime.CustomButton.Name = "";
            this.txtTime.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTime.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTime.CustomButton.TabIndex = 1;
            this.txtTime.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTime.CustomButton.UseSelectable = true;
            this.txtTime.CustomButton.Visible = false;
            this.txtTime.Lines = new string[0];
            this.txtTime.Location = new System.Drawing.Point(535, 17);
            this.txtTime.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTime.MaxLength = 32767;
            this.txtTime.Name = "txtTime";
            this.txtTime.PasswordChar = '\0';
            this.txtTime.ReadOnly = true;
            this.txtTime.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTime.SelectedText = "";
            this.txtTime.SelectionLength = 0;
            this.txtTime.SelectionStart = 0;
            this.txtTime.ShortcutsEnabled = true;
            this.txtTime.Size = new System.Drawing.Size(193, 23);
            this.txtTime.TabIndex = 52;
            this.txtTime.UseSelectable = true;
            this.txtTime.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTime.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSportsType
            // 
            // 
            // 
            // 
            this.txtSportsType.CustomButton.Image = null;
            this.txtSportsType.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtSportsType.CustomButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSportsType.CustomButton.Name = "";
            this.txtSportsType.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSportsType.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSportsType.CustomButton.TabIndex = 1;
            this.txtSportsType.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSportsType.CustomButton.UseSelectable = true;
            this.txtSportsType.CustomButton.Visible = false;
            this.txtSportsType.Lines = new string[0];
            this.txtSportsType.Location = new System.Drawing.Point(205, 66);
            this.txtSportsType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSportsType.MaxLength = 32767;
            this.txtSportsType.Name = "txtSportsType";
            this.txtSportsType.PasswordChar = '\0';
            this.txtSportsType.ReadOnly = true;
            this.txtSportsType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSportsType.SelectedText = "";
            this.txtSportsType.SelectionLength = 0;
            this.txtSportsType.SelectionStart = 0;
            this.txtSportsType.ShortcutsEnabled = true;
            this.txtSportsType.Size = new System.Drawing.Size(193, 23);
            this.txtSportsType.TabIndex = 51;
            this.txtSportsType.UseSelectable = true;
            this.txtSportsType.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSportsType.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(885, 14);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(203, 100);
            this.metroLabel5.TabIndex = 50;
            this.metroLabel5.Text = "Instructions :\r\n\r\n Double Click The Row To Save.\r\n\r\n";
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.metroTextBox2.CustomButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[] {
        "Requested"};
            this.metroTextBox2.Location = new System.Drawing.Point(535, 121);
            this.metroTextBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(193, 23);
            this.metroTextBox2.TabIndex = 36;
            this.metroTextBox2.Text = "Requested";
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.Visible = false;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtStatusUser
            // 
            // 
            // 
            // 
            this.txtStatusUser.CustomButton.Image = null;
            this.txtStatusUser.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtStatusUser.CustomButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtStatusUser.CustomButton.Name = "";
            this.txtStatusUser.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtStatusUser.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtStatusUser.CustomButton.TabIndex = 1;
            this.txtStatusUser.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtStatusUser.CustomButton.UseSelectable = true;
            this.txtStatusUser.CustomButton.Visible = false;
            this.txtStatusUser.Lines = new string[] {
        "Requested"};
            this.txtStatusUser.Location = new System.Drawing.Point(535, 121);
            this.txtStatusUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtStatusUser.MaxLength = 32767;
            this.txtStatusUser.Name = "txtStatusUser";
            this.txtStatusUser.PasswordChar = '\0';
            this.txtStatusUser.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtStatusUser.SelectedText = "";
            this.txtStatusUser.SelectionLength = 0;
            this.txtStatusUser.SelectionStart = 0;
            this.txtStatusUser.ShortcutsEnabled = true;
            this.txtStatusUser.Size = new System.Drawing.Size(193, 23);
            this.txtStatusUser.TabIndex = 36;
            this.txtStatusUser.Text = "Requested";
            this.txtStatusUser.UseSelectable = true;
            this.txtStatusUser.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtStatusUser.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(437, 162);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(76, 20);
            this.metroLabel4.TabIndex = 35;
            this.metroLabel4.Text = "Request ID";
            this.metroLabel4.Visible = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(437, 162);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 20);
            this.metroLabel2.TabIndex = 35;
            this.metroLabel2.Text = "Request ID";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.metroTextBox1.CustomButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(535, 162);
            this.metroTextBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(193, 23);
            this.metroTextBox1.TabIndex = 34;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.Visible = false;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtReqID
            // 
            // 
            // 
            // 
            this.txtReqID.CustomButton.Image = null;
            this.txtReqID.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtReqID.CustomButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtReqID.CustomButton.Name = "";
            this.txtReqID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtReqID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtReqID.CustomButton.TabIndex = 1;
            this.txtReqID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtReqID.CustomButton.UseSelectable = true;
            this.txtReqID.CustomButton.Visible = false;
            this.txtReqID.Lines = new string[0];
            this.txtReqID.Location = new System.Drawing.Point(535, 162);
            this.txtReqID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReqID.MaxLength = 32767;
            this.txtReqID.Name = "txtReqID";
            this.txtReqID.PasswordChar = '\0';
            this.txtReqID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtReqID.SelectedText = "";
            this.txtReqID.SelectionLength = 0;
            this.txtReqID.SelectionStart = 0;
            this.txtReqID.ShortcutsEnabled = true;
            this.txtReqID.Size = new System.Drawing.Size(193, 23);
            this.txtReqID.TabIndex = 34;
            this.txtReqID.UseSelectable = true;
            this.txtReqID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtReqID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Location = new System.Drawing.Point(459, 69);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(55, 20);
            this.lblUserID.TabIndex = 33;
            this.lblUserID.Text = "User ID";
            // 
            // txtUserID
            // 
            // 
            // 
            // 
            this.txtUserID.CustomButton.Image = null;
            this.txtUserID.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtUserID.CustomButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtUserID.CustomButton.Name = "";
            this.txtUserID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtUserID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtUserID.CustomButton.TabIndex = 1;
            this.txtUserID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtUserID.CustomButton.UseSelectable = true;
            this.txtUserID.CustomButton.Visible = false;
            this.txtUserID.Lines = new string[0];
            this.txtUserID.Location = new System.Drawing.Point(535, 69);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserID.MaxLength = 32767;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.PasswordChar = '\0';
            this.txtUserID.ReadOnly = true;
            this.txtUserID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUserID.SelectedText = "";
            this.txtUserID.SelectionLength = 0;
            this.txtUserID.SelectionStart = 0;
            this.txtUserID.ShortcutsEnabled = true;
            this.txtUserID.Size = new System.Drawing.Size(193, 23);
            this.txtUserID.TabIndex = 32;
            this.txtUserID.UseSelectable = true;
            this.txtUserID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtUserID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(459, 14);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(40, 20);
            this.lblTime.TabIndex = 31;
            this.lblTime.Text = "Time";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(459, 121);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(45, 20);
            this.metroLabel3.TabIndex = 30;
            this.metroLabel3.Text = "Status";
            this.metroLabel3.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(459, 121);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(45, 20);
            this.lblStatus.TabIndex = 30;
            this.lblStatus.Text = "Status";
            // 
            // lblPerson
            // 
            this.lblPerson.AutoSize = true;
            this.lblPerson.Location = new System.Drawing.Point(101, 133);
            this.lblPerson.Name = "lblPerson";
            this.lblPerson.Size = new System.Drawing.Size(51, 20);
            this.lblPerson.TabIndex = 29;
            this.lblPerson.Text = "Person";
            // 
            // lblSportsType
            // 
            this.lblSportsType.AutoSize = true;
            this.lblSportsType.Location = new System.Drawing.Point(101, 69);
            this.lblSportsType.Name = "lblSportsType";
            this.lblSportsType.Size = new System.Drawing.Size(82, 20);
            this.lblSportsType.TabIndex = 28;
            this.lblSportsType.Text = "Sports Type";
            // 
            // lblSlotID
            // 
            this.lblSlotID.AutoSize = true;
            this.lblSlotID.Location = new System.Drawing.Point(101, 17);
            this.lblSlotID.Name = "lblSlotID";
            this.lblSlotID.Size = new System.Drawing.Size(48, 20);
            this.lblSlotID.TabIndex = 27;
            this.lblSlotID.Text = "Slot ID";
            // 
            // btnClearSlot
            // 
            this.btnClearSlot.Location = new System.Drawing.Point(444, 254);
            this.btnClearSlot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClearSlot.Name = "btnClearSlot";
            this.btnClearSlot.Size = new System.Drawing.Size(107, 36);
            this.btnClearSlot.TabIndex = 21;
            this.btnClearSlot.Text = "Clear";
            this.btnClearSlot.UseSelectable = true;
            this.btnClearSlot.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSaveSlot
            // 
            this.btnSaveSlot.Location = new System.Drawing.Point(267, 254);
            this.btnSaveSlot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveSlot.Name = "btnSaveSlot";
            this.btnSaveSlot.Size = new System.Drawing.Size(107, 36);
            this.btnSaveSlot.TabIndex = 20;
            this.btnSaveSlot.Text = "Save";
            this.btnSaveSlot.UseSelectable = true;
            this.btnSaveSlot.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPerson
            // 
            // 
            // 
            // 
            this.txtPerson.CustomButton.Image = null;
            this.txtPerson.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtPerson.CustomButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtPerson.CustomButton.Name = "";
            this.txtPerson.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPerson.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPerson.CustomButton.TabIndex = 1;
            this.txtPerson.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPerson.CustomButton.UseSelectable = true;
            this.txtPerson.CustomButton.Visible = false;
            this.txtPerson.Lines = new string[0];
            this.txtPerson.Location = new System.Drawing.Point(205, 130);
            this.txtPerson.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPerson.MaxLength = 32767;
            this.txtPerson.Name = "txtPerson";
            this.txtPerson.PasswordChar = '\0';
            this.txtPerson.PromptText = "person";
            this.txtPerson.ReadOnly = true;
            this.txtPerson.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPerson.SelectedText = "";
            this.txtPerson.SelectionLength = 0;
            this.txtPerson.SelectionStart = 0;
            this.txtPerson.ShortcutsEnabled = true;
            this.txtPerson.Size = new System.Drawing.Size(193, 23);
            this.txtPerson.TabIndex = 23;
            this.txtPerson.UseSelectable = true;
            this.txtPerson.WaterMark = "person";
            this.txtPerson.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPerson.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtSlotID
            // 
            // 
            // 
            // 
            this.txtSlotID.CustomButton.Image = null;
            this.txtSlotID.CustomButton.Location = new System.Drawing.Point(171, 1);
            this.txtSlotID.CustomButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSlotID.CustomButton.Name = "";
            this.txtSlotID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSlotID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSlotID.CustomButton.TabIndex = 1;
            this.txtSlotID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSlotID.CustomButton.UseSelectable = true;
            this.txtSlotID.CustomButton.Visible = false;
            this.txtSlotID.Lines = new string[0];
            this.txtSlotID.Location = new System.Drawing.Point(205, 14);
            this.txtSlotID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSlotID.MaxLength = 32767;
            this.txtSlotID.Name = "txtSlotID";
            this.txtSlotID.PasswordChar = '\0';
            this.txtSlotID.ReadOnly = true;
            this.txtSlotID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSlotID.SelectedText = "";
            this.txtSlotID.SelectionLength = 0;
            this.txtSlotID.SelectionStart = 0;
            this.txtSlotID.ShortcutsEnabled = true;
            this.txtSlotID.Size = new System.Drawing.Size(193, 23);
            this.txtSlotID.TabIndex = 22;
            this.txtSlotID.UseSelectable = true;
            this.txtSlotID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSlotID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Aqua;
            this.btnSearch.Location = new System.Drawing.Point(15, 254);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(168, 37);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearchSlot_Click);
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(146, 1);
            this.txtSearch.CustomButton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(15, 206);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search by Sports";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(168, 23);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search by Sports";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.dgvSlot);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 326);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1169, 193);
            this.metroPanel1.TabIndex = 46;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 11;
            // 
            // dgvSlot
            // 
            this.dgvSlot.AllowUserToAddRows = false;
            this.dgvSlot.AllowUserToDeleteRows = false;
            this.dgvSlot.AllowUserToResizeRows = false;
            this.dgvSlot.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSlot.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSlot.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvSlot.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSlot.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSlot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSlot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.slotid,
            this.sportstype,
            this.person,
            this.time,
            this.availability});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSlot.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSlot.EnableHeadersVisualStyles = false;
            this.dgvSlot.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvSlot.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvSlot.Location = new System.Drawing.Point(-5, 0);
            this.dgvSlot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvSlot.Name = "dgvSlot";
            this.dgvSlot.ReadOnly = true;
            this.dgvSlot.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSlot.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSlot.RowHeadersWidth = 51;
            this.dgvSlot.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvSlot.RowTemplate.Height = 24;
            this.dgvSlot.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSlot.Size = new System.Drawing.Size(1172, 175);
            this.dgvSlot.TabIndex = 48;
            this.dgvSlot.DoubleClick += new System.EventHandler(this.dgvSlot_DoubleClick);
            // 
            // slotid
            // 
            this.slotid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.slotid.DataPropertyName = "slotid";
            this.slotid.HeaderText = "Slot ID";
            this.slotid.MinimumWidth = 6;
            this.slotid.Name = "slotid";
            this.slotid.ReadOnly = true;
            // 
            // sportstype
            // 
            this.sportstype.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.sportstype.DataPropertyName = "sportstype";
            this.sportstype.HeaderText = "Sports Type";
            this.sportstype.MinimumWidth = 6;
            this.sportstype.Name = "sportstype";
            this.sportstype.ReadOnly = true;
            // 
            // person
            // 
            this.person.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.person.DataPropertyName = "person";
            this.person.HeaderText = "Person";
            this.person.MinimumWidth = 6;
            this.person.Name = "person";
            this.person.ReadOnly = true;
            // 
            // time
            // 
            this.time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.time.DataPropertyName = "time";
            this.time.HeaderText = "Time";
            this.time.MinimumWidth = 6;
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // availability
            // 
            this.availability.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.availability.DataPropertyName = "availability";
            this.availability.HeaderText = "Availability";
            this.availability.MinimumWidth = 6;
            this.availability.Name = "availability";
            this.availability.ReadOnly = true;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.txtSearchRequest);
            this.metroTabPage2.Controls.Add(this.btnRequestedSearchSlot);
            this.metroTabPage2.Controls.Add(this.metroLabel1);
            this.metroTabPage2.Controls.Add(this.dgvRequestUser);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 12;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(1169, 519);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "View Requested Slot";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 13;
            // 
            // txtSearchRequest
            // 
            // 
            // 
            // 
            this.txtSearchRequest.CustomButton.Image = null;
            this.txtSearchRequest.CustomButton.Location = new System.Drawing.Point(104, 1);
            this.txtSearchRequest.CustomButton.Name = "";
            this.txtSearchRequest.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearchRequest.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearchRequest.CustomButton.TabIndex = 1;
            this.txtSearchRequest.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearchRequest.CustomButton.UseSelectable = true;
            this.txtSearchRequest.CustomButton.Visible = false;
            this.txtSearchRequest.Lines = new string[0];
            this.txtSearchRequest.Location = new System.Drawing.Point(340, 37);
            this.txtSearchRequest.MaxLength = 32767;
            this.txtSearchRequest.Name = "txtSearchRequest";
            this.txtSearchRequest.PasswordChar = '\0';
            this.txtSearchRequest.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearchRequest.SelectedText = "";
            this.txtSearchRequest.SelectionLength = 0;
            this.txtSearchRequest.SelectionStart = 0;
            this.txtSearchRequest.ShortcutsEnabled = true;
            this.txtSearchRequest.Size = new System.Drawing.Size(126, 23);
            this.txtSearchRequest.TabIndex = 49;
            this.txtSearchRequest.UseSelectable = true;
            this.txtSearchRequest.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearchRequest.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnRequestedSearchSlot
            // 
            this.btnRequestedSearchSlot.Location = new System.Drawing.Point(492, 37);
            this.btnRequestedSearchSlot.Name = "btnRequestedSearchSlot";
            this.btnRequestedSearchSlot.Size = new System.Drawing.Size(112, 23);
            this.btnRequestedSearchSlot.TabIndex = 48;
            this.btnRequestedSearchSlot.Text = "Search";
            this.btnRequestedSearchSlot.UseVisualStyleBackColor = true;
            this.btnRequestedSearchSlot.Click += new System.EventHandler(this.btnRequestedSearchSlot_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 14);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(177, 20);
            this.metroLabel1.TabIndex = 47;
            this.metroLabel1.Text = "Here is your requested slot";
            // 
            // dgvRequestUser
            // 
            this.dgvRequestUser.AllowUserToAddRows = false;
            this.dgvRequestUser.AllowUserToDeleteRows = false;
            this.dgvRequestUser.AllowUserToResizeRows = false;
            this.dgvRequestUser.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvRequestUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRequestUser.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvRequestUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRequestUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRequestUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequestUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user,
            this.DataGridViewTextBoxColumn,
            this.reqid,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.status});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRequestUser.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRequestUser.EnableHeadersVisualStyles = false;
            this.dgvRequestUser.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvRequestUser.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvRequestUser.Location = new System.Drawing.Point(-11, 82);
            this.dgvRequestUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvRequestUser.Name = "dgvRequestUser";
            this.dgvRequestUser.ReadOnly = true;
            this.dgvRequestUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRequestUser.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvRequestUser.RowHeadersWidth = 51;
            this.dgvRequestUser.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvRequestUser.RowTemplate.Height = 24;
            this.dgvRequestUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRequestUser.Size = new System.Drawing.Size(1203, 423);
            this.dgvRequestUser.TabIndex = 46;
            // 
            // user
            // 
            this.user.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.user.DataPropertyName = "userid";
            this.user.HeaderText = "UserID";
            this.user.MinimumWidth = 6;
            this.user.Name = "user";
            this.user.ReadOnly = true;
            // 
            // DataGridViewTextBoxColumn
            // 
            this.DataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.DataGridViewTextBoxColumn.DataPropertyName = "slotid";
            this.DataGridViewTextBoxColumn.HeaderText = "Slot ID";
            this.DataGridViewTextBoxColumn.MinimumWidth = 6;
            this.DataGridViewTextBoxColumn.Name = "DataGridViewTextBoxColumn";
            this.DataGridViewTextBoxColumn.ReadOnly = true;
            this.DataGridViewTextBoxColumn.Visible = false;
            // 
            // reqid
            // 
            this.reqid.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.reqid.DataPropertyName = "reqid";
            this.reqid.HeaderText = "Request ID";
            this.reqid.MinimumWidth = 6;
            this.reqid.Name = "reqid";
            this.reqid.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "sportstype";
            this.dataGridViewTextBoxColumn7.HeaderText = "Sports Type";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "person";
            this.dataGridViewTextBoxColumn8.HeaderText = "Person";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn9.DataPropertyName = "time";
            this.dataGridViewTextBoxColumn9.HeaderText = "Time";
            this.dataGridViewTextBoxColumn9.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.MinimumWidth = 6;
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(31, 69);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(128, 25);
            this.btnLogout.TabIndex = 1;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnLogout.UseSelectable = true;
            this.btnLogout.Click += new System.EventHandler(this.Logout_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(167, 69);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(128, 25);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.Theme = MetroFramework.MetroThemeStyle.Light;
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // lblNotification
            // 
            this.lblNotification.AutoSize = true;
            this.lblNotification.Location = new System.Drawing.Point(458, 69);
            this.lblNotification.Name = "lblNotification";
            this.lblNotification.Size = new System.Drawing.Size(79, 20);
            this.lblNotification.TabIndex = 4;
            this.lblNotification.Text = "Notification";
            this.lblNotification.TextChanged += new System.EventHandler(this.lblNotification_TextChanged);
            // 
            // FormUserDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1197, 670);
            this.Controls.Add(this.lblNotification);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.metroTabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormUserDashBoard";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 25);
            this.Text = "User DashBoard";
            this.Load += new System.EventHandler(this.FormUserDashBoard_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSlot)).EndInit();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel lblTime;
        private MetroFramework.Controls.MetroLabel lblStatus;
        private MetroFramework.Controls.MetroLabel lblPerson;
        private MetroFramework.Controls.MetroLabel lblSportsType;
        private MetroFramework.Controls.MetroLabel lblSlotID;
        private MetroFramework.Controls.MetroButton btnClearSlot;
        private MetroFramework.Controls.MetroButton btnSaveSlot;
        private MetroFramework.Controls.MetroTextBox txtPerson;
        private MetroFramework.Controls.MetroTextBox txtSlotID;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGrid dgvSlot;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn slotid;
        private System.Windows.Forms.DataGridViewTextBoxColumn sportstype;
        private System.Windows.Forms.DataGridViewTextBoxColumn person;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn availability;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroGrid dgvRequestUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn user;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reqid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private MetroFramework.Controls.MetroLabel lblUserID;
        private MetroFramework.Controls.MetroTextBox txtUserID;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtReqID;
        private MetroFramework.Controls.MetroTextBox txtStatusUser;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroButton btnLogout;
        private MetroFramework.Controls.MetroButton btnExit;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTextBox txtTime;
        private MetroFramework.Controls.MetroTextBox txtSportsType;
        private MetroFramework.Controls.MetroLabel lblNotification;
        private MetroFramework.Controls.MetroTextBox txtSearchRequest;
        private System.Windows.Forms.Button btnRequestedSearchSlot;
    }
}