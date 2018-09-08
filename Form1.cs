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
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void button1_Click_1(object sender, EventArgs e)
        {
           WebClient wc = new WebClient();
           string answer = GetResponse("https://www.leagueofgraphs.com/ru/summoner/ru/Tulen4ik");
           richTextBox1.AppendText(answer);
        }
        public static string GetResponse(string uri)
        {
            StringBuilder sb = new StringBuilder();
            byte[] buf = new byte[8192];
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            Stream resStream = response.GetResponseStream();
            int count = 0;
            do
            {
                count = resStream.Read(buf, 0, buf.Length);
                if (count != 0)
                {
                    sb.Append(Encoding.Default.GetString(buf, 0, count));
                }
            }
            while (count > 0);
            return sb.ToString();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string code;
            code = richTextBox1.Text;
            //string[] mass = code.Split('T');
            code.IndexOf(textBox1.Text);
            label1.Text = Convert.ToString (code.IndexOf(textBox1.Text));
            if (Convert.ToInt32(label1.Text) < 0)
            {
                label1.Text = Convert.ToString(0);
            }
            code = code.Remove(0,Convert.ToInt32(label1.Text));
            richTextBox2.Text = code;
        }
    }
}

