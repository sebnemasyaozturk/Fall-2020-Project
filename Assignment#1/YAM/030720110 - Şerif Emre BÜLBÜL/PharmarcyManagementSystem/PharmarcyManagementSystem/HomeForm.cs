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
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        MedicineForm Medform = new MedicineForm();
        Employees Empform = new Employees();
        Company Cmpform = new Company();
        Billing billform = new Billing();
        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
          
            Medform.Show();
            this.Hide();
        }
      
        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            Empform.Show();
            this.Hide();
            
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            Cmpform.Show();
            this.Hide();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            billform.Show();
            this.Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }
    }
}
