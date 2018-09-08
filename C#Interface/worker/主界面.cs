using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace worker
{
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            add a = new add();
            a.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            selec se = new selec();
            se.Show();
            this.Hide();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            form1 f1 = new form1();
            f1.Show();
            this.Hide();
        }

        

        private void button3_Click_1(object sender, EventArgs e)
        {
            alter al = new alter();
            al.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            form7 f7 = new form7();
            f7.Show();
            this.Hide();
        }
    }
}
