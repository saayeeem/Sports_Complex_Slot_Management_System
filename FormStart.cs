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
    public partial class FormStart : MetroForm
    {
        private int i = 1;
        public FormStart()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.ProgressBar1.Value += 20;

            if (this.ProgressBar1.Value >= 100)
            {
                this.ProgressBar1.Value = 0;
                this.timer1.Stop();

                FormLogIn login = new FormLogIn();
                login.Show();
                this.timer1.Stop();
                this.Hide();


            }
            else if (this.ProgressBar1.Value <= 100)
            {
                string path = "C:\\Users\\chysa\\OneDrive\\" + i + ".jpg";
                this.pictureBox1.Image = Image.FromFile(path);
                //this.timer1.Stop();

                i++;
            }

            
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }


        private void FormStart_Load(object sender, EventArgs e)
        {

            string path = "C:\\Users\\chysa\\OneDrive\\1.jpg";
            this.pictureBox1.Image = Image.FromFile(path);
        }

     
    }
}
