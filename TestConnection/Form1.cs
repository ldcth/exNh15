using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TestConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string c = "server=localhost;database=dotnet;uid=root;pwd=Ductho263;";
        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection cac = new MySqlConnection(c);
        }
    }
}
