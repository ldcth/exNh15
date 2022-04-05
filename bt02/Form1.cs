using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt02
{
    public partial class Form1 : Form
    {
        string path = @"C:\Users\This PC\source\repos\exNh15\bt02\Login.txt";
        private string[] technicians = { "1645", "1689" };
        private string custodians = "8345";
        private string[] scientists = { "9998", "1006", "1007", "1008" };
        public Form1()
        {
            InitializeComponent();
            showLog();
        }
        private void getNumber(object o,EventArgs e)
        {
            if(txtSecurityCode.TextLength < 4)
            txtSecurityCode.Text += ((Button)o).Text;
        }
        private int check(string a)
        {          
            foreach (string s in technicians)
            {
                if (a == s) return 1;
                else
                {
                    foreach (string st in scientists)
                    {
                        if (a == st) return 3;
                        else
                        {
                            if (a == custodians) return 2;
                        }
                    }
                                         
                }
            }
            return 0;

        }
    private void butOK_Click(object sender, EventArgs e)
        {
            string res;
            if (check(txtSecurityCode.Text) == 1) res = "\t\tTechnicians";
            else if (check(txtSecurityCode.Text) == 2) res = "\t\tCustodians";
            else if (check(txtSecurityCode.Text) == 3) res = "\t\tScientists";
            else res = "\tRestricted Access!";
            using (StreamWriter sw = File.AppendText(path))
            {
                DateTime dt = DateTime.Now;
                sw.WriteLine(dt + res);
                sw.Close();
            }
            showLog();
            txtSecurityCode.Text = "";
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            txtSecurityCode.Text = "";
        }
        private void showLog()
        {
            lbAccessLog.Items.Clear();
            string [] lines = File.ReadAllLines(path);
            foreach(string line in lines)
            {
                lbAccessLog.Items.Add(line);    
            }
            lbAccessLog.SelectedIndex = lbAccessLog.Items.Count - 1;
        }
        
    }
}
