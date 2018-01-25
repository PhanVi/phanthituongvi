using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace phanthituongvi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // đã thay đổi ở đây
            label1.Text = "Hiển thị ở đây!";
            

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "Click2 !";
        }
    }
}
