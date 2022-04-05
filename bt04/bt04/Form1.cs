using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }
        public void OnClick(object o,EventArgs e)
        {
            textBox1.Text += ((Button)o).Text;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            char[] arr = new char[] { '+', '-', '*', '/' };
            string str = textBox1.Text;
            int i = 0, vt = - 1;
            while (i < arr.Length)
            {
                if (str.IndexOf(arr[i]) != -1)
                {
                    vt = str.IndexOf(arr[i]);
                    break;
                }
                i++;
            }
            if (vt != -1)
            {
                double a, b, res = 0;
                a = Convert.ToDouble(str.Substring(0, vt));
                b = Convert.ToDouble(str.Substring(vt + 1, str.Length - (vt + 1)));
                if (str[vt] == '+') res = a + b;
                else if (str[vt] == '-') res = a - b;
                else if (str[vt] == '*') res = a * b;
                else if (str[vt] == '/') res = a / b;
                this.textBox1.Text = res + "";
            }
            else MessageBox.Show("Error!!");
        }
    }
}
