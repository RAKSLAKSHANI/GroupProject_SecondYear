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

namespace CarRadProject
{
    public partial class Users : Form
    {
        public Users()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\dilshan\Documents\CarRentaldb.mdf;Integrated Security = True; Connect Timeout = 30");

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void populate()
        {

            Con.Open();
            string query = "select * from UserTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            UserDGV.DataSource = ds.Tables[0];



            Con.Close();
        }

        private void Users_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Uid.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from UserTbl where Id=" + Uid.Text + ";";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Deleted Successfully");
                    Con.Close();
                    populate();


                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }


           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Uid.Text == "" || Uname.Text == "" || Upass.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into UserTbl values('" + Uid.Text + "','" + Uname.Text + "','" + Upass.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Succcessfully Added");
                    Con.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }
        private void UserDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Uid.Text = UserDGV.SelectedRows[0].Cells[0].Value.ToString();
            Uname.Text = UserDGV.SelectedRows[0].Cells[1].Value.ToString();
            Upass.Text = UserDGV.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Uid.Text == "" || Uname.Text == "" || Upass.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update UserTbl set Uname='" + Uname.Text + "',Upass='" + Upass.Text + "' where Id=" + Uid.Text + ";";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Succcessfully Updated");
                    Con.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main =new MainForm ();
            main.Show();
        }
    }
}
