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

namespace Electricity_project
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ANUJA;Initial Catalog=Login;Integrated Security=True;");
        private void button1_Click(object sender, EventArgs e)
        {
            String Username, User_password;

            Username = textBox1.Text;
            User_password = textBox2.Text;

            try
            {
                String querry  = "SELECT * FROM Admin_table WHERE Adminname='" + textBox1.Text + "' AND Adminpassword='" + textBox2.Text + "'";

                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    Username = textBox1.Text;
                    User_password = textBox2.Text;

                    Form5 Fom5 = new Form5();
                    Fom5.Show();
                    this.Hide();




                }
                else
                {
                    MessageBox.Show("Invalid Login Details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();
                    textBox1.Focus();
                }


            }
            catch
            {
                MessageBox.Show("Error");

            }
            finally
            {
                conn.Close();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Form1 Fom1 = new Form1();
            Fom1.Show();
            this.Hide();

        }
    }
}

