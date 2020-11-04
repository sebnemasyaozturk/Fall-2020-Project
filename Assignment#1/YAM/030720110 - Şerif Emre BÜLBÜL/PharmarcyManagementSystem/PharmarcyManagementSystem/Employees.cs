using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PharmarcyManagementSystem
{
    public partial class Employees : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Serif\OneDrive\Belgeler\Pharmacenter_db.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Employee_tbl";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            //EmployeeDataGridView.ReadOnly = true;
            EmployeeDataGridView.DataSource = ds.Tables[0];

            Con.Close();
        }
        public Employees()
        {
            InitializeComponent();
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void AddEmpbtn_Click(object sender, EventArgs e)
        {
            if (Empidtb.Text == "" || Empnametb.Text == "" || empsaltb.Text == "" || empagetb.Text == "" || empphonetb.Text == "" ||  Emppasstb.Text == "")
            {
                MessageBox.Show("wrong Input. Fill All the filled");



            }
            else
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Employee_tbl values('"+Empidtb.Text+"','"+Empnametb.Text+"',"+empsaltb.Text+","+empagetb.Text+",'"+empphonetb.Text+"','"+Emppasstb.Text+"')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Sucessfully Added");
                Con.Close();
                populate();

            
            }
                    
                    }
      

        private void EmployeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Empidtb.Text = EmployeeDataGridView.SelectedRows[0].Cells[0].Value.ToString();
            Empnametb.Text = EmployeeDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            empsaltb.Text = EmployeeDataGridView.SelectedRows[0].Cells[2].Value.ToString();
            empagetb.Text = EmployeeDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            empphonetb.Text = EmployeeDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            Emppasstb.Text = EmployeeDataGridView.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void UpdateEmpbtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            String Myquery = "UPDATE Employee_tbl SET Empname =' " + Empnametb.Text + "',Empsalary = " + empsaltb.Text + ",EmpAge =" + empagetb.Text + ",EmpPhone = '" + empphonetb.Text + "',EmpPassword = '" +Emppasstb.Text + "' WHERE Empid= '" + Empidtb.Text + "';";
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Employee Updated Successfully");
            Con.Close();
            populate();

        }

        private void DelEmpbtn_Click(object sender, EventArgs e)
        {
            if (Empidtb.Text == "")
            {
                MessageBox.Show("wrong operation Click on the Employee to be Deleted");

            }
            else
            {
                Con.Open();
                string query = "delete from Employee_tbl where Empid ='" + Empidtb.Text + "';";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Deleted Successfully");
                Con.Close();
                populate();
            }
        }

        private void Empidtb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            HomeForm homef = new HomeForm();
            homef.Show();
            this.Hide();
        }
    }
}
