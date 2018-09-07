using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections;
namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            WebClient wc = new WebClient();
            string answer = wc.DownloadString("https://www.leagueofgraphs.com/ru/summoner/ru/Tulen4ik");
            richTextBox1.AppendText(answer);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            bool k = false;
            for (int i = 0; i<richTextBox1.Text.Length-name.Length; i++)
            {
                string kek = string.Empty;
                for (int j = 0; j < name.Length; j++)
                {
                    kek += richTextBox1.Text[j + i];
                    if (string.Equals(kek, name) == true)
                    {
                        textBox1.Text = "estb";
                        k = true;
                        break;
                    }

                }
                if (k==true)
                {
                    break;
                }
            }
            if (k==false)
            {
                textBox1.Text = "net";
            }
        }
    }
}
