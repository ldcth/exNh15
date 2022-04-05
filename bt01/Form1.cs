using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbbTR.SelectedIndex = 0;
        }
        private double TT()
        {
            double s = 0;
            if (cbCV.Checked)
                s += 1;
            if (cbTT.Checked)
                s += 2;
            if (cbCH.Checked)
                s += 3;
            int sr = Convert.ToInt32(cbbTR.SelectedItem.ToString());
            s += sr * 4;
            return s;
        }
        private void butTT_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "")
            {
                MessageBox.Show("Nhap ten");
            }
            else
            {
                txtTotal.Text = TT().ToString(); 
            }
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.Dispose();
        }
    }
}
