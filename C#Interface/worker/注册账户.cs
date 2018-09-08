using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace worker
{
    public partial class form3 : Form
    {
        public form3()
        {
            InitializeComponent();
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
            textBox1.TabIndex = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != textBox2.Text)
            {
                MessageBox.Show("两次输入的密码不同，请重新输入！");
                textBox2.Clear();
                textBox3.Clear();
            }
            else
            {
                string constr = "Data Source=.;Initial Catalog=workers;Integrated Security=True;";
                string sql = "insert into people values('" + textBox1.Text + "','" + textBox3.Text + "')";
                SqlConnection con = new SqlConnection(constr);
                SqlCommand cmd = new SqlCommand(sql, con);
                con.Open();
                cmd.ExecuteNonQuery();                
                MessageBox.Show("注册成功");
                con.Close();
            }
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            Font f = new Font("楷体", 14, FontStyle.Underline);
            label7.Font = f;
        }

        private void label7_MouseLeave(object sender, EventArgs e)
        {
            Font f = new Font("楷体", 14);
            label7.Font = f;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            form1 f1 = new form1();
            f1.Show();
            this.Hide();
        }

        private void form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("你确定要退出程序吗？", "提示信息", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (result == DialogResult.OK)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
