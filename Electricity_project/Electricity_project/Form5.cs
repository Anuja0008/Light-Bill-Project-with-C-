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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
     

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            {
                try
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=ANUJA;Initial Catalog=Login;Integrated Security=True;"))
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand("INSERT INTO Login_new (Username, password) VALUES (@Username, @password)", con);

                        cmd.Parameters.AddWithValue("@Username", textBox1.Text);
                        cmd.Parameters.AddWithValue("@password", textBox2.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record Added Successfully", "Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to add record", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 fom=new Form1();
            fom.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form7 fom7=new Form7();
            fom7.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form9 form9=new Form9();        
            form9.Show();
            this.Hide();
        }
    }
}
