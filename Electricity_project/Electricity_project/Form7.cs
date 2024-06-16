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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=ANUJA;Initial Catalog=Login;Integrated Security=True;");
        private void Form7_Load(object sender, EventArgs e)
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
            Form8 fom8 = new Form8();
            fom8.Show();
            this.Hide();    
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 fom6= new Form6();
            fom6.Show();
            this.Hide();



        
        }
    }
}
