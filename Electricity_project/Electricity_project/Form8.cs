using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Electricity_project
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("hillsendvilla@gmail.com");
                msg.To.Add(textBox1.Text);
                msg.Subject = textBox2.Text;
                msg.Body = textBox3.Text;

                SmtpClient smt = new SmtpClient();
                smt.Host = "smtp.gmail.com";
                System.Net.NetworkCredential ntcd = new NetworkCredential();
                ntcd.UserName = "hillsendvilla@gmail.com";
                ntcd.Password = "29921588";
                smt.Credentials = ntcd;
                smt.EnableSsl = true;
                smt.Port = 465;
                smt.Send(msg);

                MessageBox.Show("Your Mail is sended");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
    }
}
