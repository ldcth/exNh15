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
    public partial class Form2 : Form
    {
        public delegate void MyDel(String LSH, string txt);
        public MyDel d { get; set; }
        private QLSV bll = new QLSV();
        public string MSSV { get; set; }    
        public Form2(String m)
        {
            InitializeComponent();
            MSSV = m;
            foreach (string i in bll.GetAllLSH().Distinct())
            {
                cbbLSH.Items.Add(i);
            }
            GUI();
        }
        public void GUI()
        {
            if(MSSV != "")
            {
                txtMSSV.Enabled = false;
                txtMSSV.Text = bll.GetSVByMSSV(MSSV).MSSV;
                txtName.Text = bll.GetSVByMSSV(MSSV).NameSV;
                cbbLSH.SelectedItem = bll.GetSVByMSSV(MSSV).LopSH;
                //True - Male
                if (bll.GetSVByMSSV(MSSV).Gender)
                    rbMale.Checked = true;
                else
                    rbFemale.Checked = true;
                dateTimePicker1.Value = bll.GetSVByMSSV(MSSV).NgaySinh;
                txtDTB.Text = bll.GetSVByMSSV(MSSV).DTB.ToString();
                cbAnh.Checked = bll.GetSVByMSSV(MSSV).Anh;
                cbHB.Checked = bll.GetSVByMSSV(MSSV).Hocba;
                cbCMND.Checked = bll.GetSVByMSSV(MSSV).CMND;
            }
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            SV s = new SV
            {

            };
            bll.ExecuteDB(s);
            d("All", "");
            this.Close();   
        }
    }
}
