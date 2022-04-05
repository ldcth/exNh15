using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GK
{
    public partial class Form1 : Form
    {
        private QLSV bll = new QLSV();
        public Form1()
        {
            InitializeComponent();
            cbbLSH.Items.Add("All");
            foreach (string i in bll.GetAllLSH().Distinct())
            {
                cbbLSH.Items.Add(i);
            }
        }

        private void btShow_Click(object sender, EventArgs e)
        {
            string LSH = cbbLSH.SelectedItem.ToString();
            Reload(LSH);
        }
        public void Reload(string LSH, string txt = "")
        {
            dataGridView1.DataSource = bll.GetSVByLSH(LSH, txt);
        }

        private void btSearch_Click(object sender, EventArgs e)
        {
            string LSH=cbbLSH.SelectedItem.ToString();
            string name=tbName.Text;
            dataGridView1.DataSource = bll.GetSVByLSH(LSH,name);
            //cc
        }
    }
}
