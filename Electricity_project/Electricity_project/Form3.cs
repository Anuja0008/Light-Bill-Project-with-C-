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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ANUJA;Initial Catalog=Login;Integrated Security=True;");

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            BindData();
        }
        void BindData()
        {
            SqlCommand cnn = new SqlCommand("select * from info_table", conn);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;




        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand cnn = new SqlCommand("select * from info_table where Total>2000 ", conn);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlCommand cnn = new SqlCommand("select * from info_table where Total<1000 ", conn);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 Fom2 = new Form2();
            Fom2.Show();
            this.Hide();
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand cnn = new SqlCommand("select * from info_table where Total>5000 ", conn);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlCommand cnn = new SqlCommand("select * from info_table where Total>10000 ", conn);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }
                private void FilterData(string filterCondition)
                {
                    SqlCommand cnn = new SqlCommand($"select * from info_table where {filterCondition}", conn);

                    SqlDataAdapter da = new SqlDataAdapter(cnn);
                    DataTable table = new DataTable();
                    da.Fill(table);
                    dataGridView1.DataSource = table;
                }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            {
                string searchTerm = textBox1.Text.Trim();
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    FilterData($"Client_ID LIKE '%{searchTerm}%'"); // Change ColumnName to the actual column name you want to search
                }
                else
                {
                    BindData();
                }
            }
        }
    }
    }


