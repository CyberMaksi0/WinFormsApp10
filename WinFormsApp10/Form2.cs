using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp10
{
    public partial class Form2 : Form
    {
        public string nazwa = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = nazwa;
        }

        private void BntOk_Click(object sender, EventArgs e)
        {
            nazwa = textBox1.Text;
        }
    }
}
