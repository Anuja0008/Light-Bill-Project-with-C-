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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Electricity_project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ANUJA;Initial Catalog=Login;Integrated Security=True;");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do You Want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String Username, User_password;

            Username = textBox1.Text;
            User_password = textBox2.Text;

            try
            {
                String querry = "Select * from  Login_new WHERE Username='" + textBox1.Text + "' AND password='" + textBox2.Text + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    Username = textBox1.Text;
                    User_password = textBox2.Text;

                    Form2 Fom2 = new Form2();
                    Fom2.Show();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            Form6 fom6 = new Form6();
            fom6.Show();
            this.Hide();

        }
    }
}

