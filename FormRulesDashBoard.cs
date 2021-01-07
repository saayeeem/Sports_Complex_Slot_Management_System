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
    public partial class FormRulesDashBoard : MetroForm
    {
        public FormRulesDashBoard()
        {
            InitializeComponent();
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
    }

}
