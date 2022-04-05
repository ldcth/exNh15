using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bt03
{
    public partial class Form1 : Form
    {
        #region
        DataTable dtOrder;
        #endregion
        public Form1()
        {
            InitializeComponent();
            load();
        }
        
        private void load()
        {
            dtOrder = new DataTable();
            dtOrder.Columns.Add("Mon an");
            dtOrder.Columns.Add("So luong");

            dgvOrder.DataSource = dtOrder;
        }
        private void onClick(object o,EventArgs e)
        {
            DataRow row;
            row = dtOrder.NewRow();
            bool des = true;
            
            foreach (DataRow dr in dtOrder.Rows)
            {
                if (dr[0].ToString() == ((Button)o).Text)
                {
                    des = false;
                    dr[1] = Convert.ToInt32(dr[1]) + 1;
                    break;
                }
            }

            if (des)
            {
                row[0] = ((Button)o).Text;
                row[1] = 1;
                dtOrder.Rows.Add(row); 
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            dtOrder.Rows.Clear();   
        }

        private void button17_Click(object sender, EventArgs e)
        {
            String res;
            res = comboBox1.SelectedIndex.ToString() ;
            if(res.Equals("-1"))
            {
                res = "Nhap ten ban!";
            }
            else
            {
                res = comboBox1.SelectedItem.ToString() + " order thanh cong";
            }
            MessageBox.Show(res);
        }
    }
}
