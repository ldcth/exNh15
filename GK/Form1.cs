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
            cbbLSH.SelectedIndex = 0;
            cbbSort.Items.Add("MSSV");
            cbbSort.Items.Add("LopSV");
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

        private void btDel_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow i in dataGridView1.SelectedRows)
                {
                    string MSSV = i.Cells["MSSV"].Value.ToString();
                    bll.DelSV(MSSV);
                }
            }
            cbbLSH.SelectedItem = 0;
            Reload(cbbLSH.SelectedItem.ToString());
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2("");
            f.d = new Form2.MyDel(Reload);
            f.Show();
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 1)
            {
                string MSSV = dataGridView1.SelectedRows[0].Cells["MSSV"].Value.ToString();
                Form2 f = new Form2(MSSV);
                f.d = new Form2.MyDel(Reload);
                f.Show();
            }
        }

        private void btSort_Click(object sender, EventArgs e)
        {
            switch (cbbSort.SelectedItem.ToString())
            {
                case "MSSV":
                    bool compareMSSV(SV em1, SV em2)
                    {
                        if (Convert.ToInt32(em1.MSSV) > Convert.ToInt32(em2.MSSV)) return false;
                        else return true;
                    }
                    dataGridView1.DataSource = bll.Sort(compareMSSV);
                    break;
                case "LopSV":
                    bool compareLop(SV em1,SV em2)
                    {
                        string lop1 = em1.LopSH;
                        string lop2= em2.LopSH;
                        int comparison = String.Compare(lop1, lop2, comparisonType: StringComparison.OrdinalIgnoreCase);
                        if (comparison < 0) return false;
                        else return true;
                    }
                    dataGridView1.DataSource = bll.Sort(compareLop);
                    break;
            }
        }
    }
}
