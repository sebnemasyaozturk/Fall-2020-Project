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

    public partial class MedicineForm : Form
    {
SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Serif\OneDrive\Belgeler\Pharmacenter_db.mdf;Integrated Security=True;Connect Timeout=30");
        public void populate()
        {
            Con.Open();
            string Myquery = "select * from Medicine_tbl";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Myquery, Con);
            SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            MedicineGridView.ReadOnly = true;
            MedicineGridView.DataSource = ds.Tables[0];

            Con.Close();
        }
            public MedicineForm()
        {
            InitializeComponent();
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            if (Mednametb.Text == "")
            {
                MessageBox.Show("wrong operation Click on the medicine to be Deleted");

            }
            else
            {
                Con.Open();
                string query = "delete from Medicine_tbl where MedName ='" + Mednametb.Text + "';";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine Deleted Successfully");
                Con.Close();
                populate();
            }
            
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (Mednametb.Text == "" || sptb.Text == "" || Bptb.Text == "" || qtytb.Text == "" || companycb.SelectedItem == null) 
            {
                MessageBox.Show("Missing Data . Fill All the Information");
            }
            else 
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("insert into Medicine_tbl values('" + Mednametb.Text + "'," + Bptb.Text + "," + sptb.Text + "," + qtytb.Text + ",'" + ExpireDate.Text + "','" + companycb.SelectedItem.ToString() + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Medicine Successfully Added");



                Con.Close();
                populate();
            }
        }


        private void MedicineGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Mednametb.Text = MedicineGridView.SelectedRows[0].Cells[0].Value.ToString();
            Bptb.Text = MedicineGridView.SelectedRows[0].Cells[1].Value.ToString();
            sptb.Text = MedicineGridView.SelectedRows[0].Cells[2].Value.ToString();
            qtytb.Text = MedicineGridView.SelectedRows[0].Cells[3].Value.ToString();
            ExpireDate.Text = MedicineGridView.SelectedRows[0].Cells[4].Value.ToString();
            companycb.Text = MedicineGridView.SelectedRows[0].Cells[5].Value.ToString();
        }
        public void fillcombobox() {

            Con.Open();
            SqlCommand cmd = new SqlCommand("select Compname from Company_tbl", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("Compname", typeof(string));
            dt.Load(rdr);
            companycb.ValueMember = "Compname";
            companycb.DataSource = dt;
            Con.Close();




        }
        private void MedicineForm_Load(object sender, EventArgs e)
        {
            populate();
            fillcombobox();
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Con.Open();
            String Myquery = "UPDATE Medicine_tbl SET Bprice = " + Bptb.Text + ",Sprice = " + sptb.Text + ",MedQty =" + qtytb.Text + ",ExpDate = '" + ExpireDate.Text + "',Company = '" + companycb.SelectedItem.ToString() + "' WHERE MedName= '" + Mednametb.Text + "';";
            SqlCommand cmd = new SqlCommand(Myquery, Con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Medicine Updated Successfully");
            Con.Close();
            populate();

        }

        private void Mednametb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Bptb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void sptb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void qtytb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void companycb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            HomeForm homef = new HomeForm();
            homef.Show();
            this.Hide();
        }
    }
}
