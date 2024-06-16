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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Electricity_project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

        }
        SqlConnection con=new SqlConnection(@"Data Source=ANUJA;Initial Catalog=Login;Integrated Security=True;");

        private void Form2_Load(object sender, EventArgs e)
        {
            BindData();
            dateTimePicker1.Value = DateTime.Now;
        }
        void BindData() 
        {
            SqlCommand cnn = new SqlCommand("select * from info_table", con);

            SqlDataAdapter da= new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource=table;


 

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { 
            con.Open();
            DateTime selectedDateTime = dateTimePicker1.Value;

            SqlCommand cnn = new SqlCommand("insert into info_table values(@Client_ID,@Client_Name,@Unit,@Unit_Price,@Total,@date)",con);

            cnn.Parameters.AddWithValue("@Client_ID",int.Parse(textBox1.Text));

            cnn.Parameters.AddWithValue("@Client_Name",(textBox2.Text));

            cnn.Parameters.AddWithValue("@Unit",int.Parse(textBox3.Text));

            cnn.Parameters.AddWithValue("@Unit_Price", int.Parse(textBox4.Text));  
                
            cnn.Parameters.AddWithValue("@Total",int.Parse(textBox5.Text));

            cnn.Parameters.AddWithValue("@date", selectedDateTime);

            



            cnn.ExecuteNonQuery();

            con.Close();
            BindData();

            MessageBox.Show("Record Added Successfully","Add",MessageBoxButtons.OK,MessageBoxIcon.Information);


        }

        private void button4_Click(object sender, EventArgs e)
        {

            double d1, d2;
            d1 = double.Parse(textBox6.Text = textBox4.Text);//price
            d2 = double.Parse(textBox7.Text = textBox3.Text);//units

            if (d2 >= 100)
            {
                textBox5.Text =textBox8.Text = (20 * d2 +150).ToString();

            }
            else if (d2 >= 50)
            {
                textBox5.Text = textBox8.Text = (15 * d2 + 150+100).ToString();
            }
            else if (d2 >= 25)
            {
                textBox5.Text = textBox8.Text = (8 * d2 + 100).ToString();

            }
            else
            {
                textBox5.Text = textBox8.Text = (d1 * d2).ToString();
            }

            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=ANUJA;Initial Catalog=Login;Integrated Security=True;");

            con.Open();

            SqlCommand cnn = new SqlCommand("delete info_table where Client_ID=@Client_ID",con);

            cnn.Parameters.AddWithValue("@Client_ID", int.Parse(textBox1.Text));

            cnn.ExecuteNonQuery();

            con.Close();
            BindData();

            MessageBox.Show("Record Deleted Successfully", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form3 Fom3 = new Form3();
            Fom3.Show();
            this.Hide();

            SqlCommand cnn = new SqlCommand("select * from info_table", con);

            SqlDataAdapter da = new SqlDataAdapter(cnn);
            DataTable table = new DataTable();
            da.Fill(table);
            dataGridView1.DataSource = table;


        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                DateTime selectedDateTime = dateTimePicker1.Value;

                SqlCommand cnn = new SqlCommand("UPDATE info_table SET Client_Name = @Client_Name, Unit = @Unit, Unit_Price = @Unit_Price, Total = @Total, date = @date WHERE Client_ID = @Client_ID", con);

                cnn.Parameters.AddWithValue("@Client_ID", int.Parse(textBox1.Text));
                cnn.Parameters.AddWithValue("@Client_Name", textBox2.Text);
                cnn.Parameters.AddWithValue("@Unit", int.Parse(textBox3.Text));
                cnn.Parameters.AddWithValue("@Unit_Price", int.Parse(textBox4.Text));
                cnn.Parameters.AddWithValue("@Total", int.Parse(textBox5.Text));
                cnn.Parameters.AddWithValue("@date", selectedDateTime);

                cnn.ExecuteNonQuery();

                con.Close();

                MessageBox.Show("Message updated successfully", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // Handle exception appropriately, such as logging or displaying an error message
            }

        }
    }
}
