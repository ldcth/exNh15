using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mouse_KeyBoard_Event
{
    public partial class Form1 : Form
    {
        Point p;
        public Form1()
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                p = e.Location;
            }

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            label1.Text = "X = " + e.X + ", Y = " + e.Y;

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Graphics g = this.CreateGraphics();
                Pen pe = new Pen(Color.Red, 2);
                g.DrawLine(pe, p, e.Location);
            }

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            label2.Text = "KeyChar: " + e.KeyChar.ToString();

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            label3.Text = "KeyCode: " + e.KeyCode
                + "\nKeyData: " + e.KeyData
                + "\nKeyValue: " + e.KeyValue;

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            label4.Text = "up";
        }
    }
}
