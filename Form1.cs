using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databaseprojlast
{
    public partial class Form1 : Form
    {
        public Form2 Form2 { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'masterDataSet.AIRPORT' table. You can move, or remove it, as needed.
            this.aIRPORTTableAdapter.Fill(this.masterDataSet.AIRPORT);
            // TODO: This line of code loads data into the 'masterDataSet.ADMIN' table. You can move, or remove it, as needed.

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-SDS5N1K\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlConnection.Open();

                    sqlCommand.CommandText = " INSERT INTO ADMIN VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("Insertion was Successfully Completed");


                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.aDMINTableAdapter.Fill(this.masterDataSet.ADMIN);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-SDS5N1K\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlConnection.Open();

                    sqlCommand.CommandText = " UPDATE ADMIN SET USERNAME = '" + textBox1.Text + "'WHERE EMAIL = '" + textBox2.Text + "'";
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("Update was Successfully Completed");

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-SDS5N1K\\SQLEXPRESS;Initial Catalog=master;Integrated Security=True";

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                using (SqlCommand sqlCommand = new SqlCommand())
                {
                    sqlCommand.Connection = sqlConnection;
                    sqlConnection.Open();

                    sqlCommand.CommandText = " DELETE FROM ADMIN WHERE USERNAME = '" + textBox1.Text + "'";
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("Deleteion was Successfully Completed");

                }
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void label5_Click_2(object sender, EventArgs e)
        {

        }
    }
}
