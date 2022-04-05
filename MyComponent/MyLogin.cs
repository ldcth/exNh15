using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyComponent
{
    public partial class MyLogin: UserControl
    {
        public MyLogin()
        {
            InitializeComponent();
           
        }
        public string User
        {
            get { return this.textBox1.Text; }
        }
        public string Password
        {
            get { return this.textBox2.Text; }
        }

    }
}
