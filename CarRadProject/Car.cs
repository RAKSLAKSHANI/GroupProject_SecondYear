﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CarRadProject
{
    public partial class Car : Form
    {
        public Car()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\dilshan\Documents\CarRentaldb.mdf;Integrated Security = True; Connect Timeout = 30");

        private void populate()
        {

            Con.Open();
            string query = "select * from CarTbl";
            SqlDataAdapter da = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            CarsDGV.DataSource = ds.Tables[0];



            Con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (RegNumTb.Text == "" || BrandTb.Text == "" || ModelTb.Text == "" || PriceTb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into CarTbl values('" + RegNumTb.Text + "','" + BrandTb.Text + "','" + ModelTb.Text + "','" + AvailableCb.SelectedItem.ToString() + "','" + PriceTb.Text + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Succcessfully Added");
                    Con.Close();
                    populate();
                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }
        }
        private void fillAvailable()
        {
            Con.Open();
            string query = "select   RegNum from CarTbl where Available ='" + "yes" + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("RegNum", typeof(string));
            dt.Load(rdr);
           Search.ValueMember = "RegNum";
           Search.DataSource = dt;
            Con.Close();
        }

        private void Car_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (RegNumTb.Text == "")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from CarTbl where RegNum='" + RegNumTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car  Deleted Successfully");
                    Con.Close();
                    populate();


                }
                catch (Exception Myex)
                {
                    MessageBox.Show(Myex.Message);
                }
            }



        }

        private void CarsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            RegNumTb.Text = CarsDGV.SelectedRows[0].Cells[0].Value.ToString();
            BrandTb.Text = CarsDGV.SelectedRows[0].Cells[1].Value.ToString();
            ModelTb.Text = CarsDGV.SelectedRows[0].Cells[2].Value.ToString();
            AvailableCb.SelectedItem = CarsDGV.SelectedRows[0].Cells[3].Value.ToString();
            PriceTb.Text = CarsDGV.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (RegNumTb.Text == "" || BrandTb.Text == "" || ModelTb.Text == "" || PriceTb.Text == "")
            {
                MessageBox.Show("Missing information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update CarTbl set Brand='" + BrandTb.Text + "',Model='" + ModelTb.Text + "', Available ='" + AvailableCb.SelectedItem.ToString() + "',Price=" + PriceTb.Text + " where RegNum='" + RegNumTb.Text + "';";

                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Car Succcessfully Updated");
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
            MainForm main = new MainForm();
            main.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

