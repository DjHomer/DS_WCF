using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Klijent.MailServiceReferenceKalu;

namespace Klijent
{
    public partial class Form1 : Form, IMailServiceCallback
    {
        protected string username;
        private MailServiceClient proxy;
   
        public Form1(string name)
        {
            InitializeComponent();

            username = name;
            nameLbl.Text = name;

            proxy = new MailServiceClient(new System.ServiceModel.InstanceContext(this));
            Register(name);
        }

        public void Register(string name)
        {
            proxy.Register(name);
        }

        //callback implementation!!!
        public void Receive(Email e)
        {
            rcvMailTxtBox.Text += " New Mail arrived from " + e.From + " the topic is about " + e.Topic + " and the content is " + e.Content;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void sendMailBtn_Click(object sender, EventArgs e)
        {
            string topicTmp = topicTxtBox.Text;
            string contentTmp = sendMailTxtBox.Text;
            List<string> nicknames = usersTxtBox.Text.Split(' ').ToList();

            proxy.SendMail(new Email()
            {
                Topic = topicTmp,
                Content = contentTmp,
                From = username,
                For = nicknames
            });
        }

        private void rcvMailTxtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
