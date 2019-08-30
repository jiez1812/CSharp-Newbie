using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Counter_App
{
    public partial class Form1 : Form
    {
        int count_num = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            count_num += 1;
            count_label.Text = Convert.ToString(count_num);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            count_label.Text = Convert.ToString(count_num);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            count_num -= 1;
            count_label.Text = Convert.ToString(count_num);
        }
    }
}
