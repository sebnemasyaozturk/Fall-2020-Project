using ns1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmarcyManagementSystem
{
    public partial class Form1 : Form
    {
        int startpoint = 0;

        public Form1()
        {
            InitializeComponent();
            this.IsMdiContainer = true; 
        }

        private void bunifuProgressBar1_progressChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            

        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            startpoint += 1;
            bunifuCircleProgressbar1.Value = startpoint;
            if(bunifuCircleProgressbar1.Value == 100)
            {
                bunifuCircleProgressbar1.Value = 0;
                timer1.Stop();
                Login Mylogin = new Login();
                this.Hide();
                
                Mylogin.Show();

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        
    }
}
