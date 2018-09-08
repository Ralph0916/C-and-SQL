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
    public partial class form4 : Form
    {
        public form4()
        {
            InitializeComponent();
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);//label控件背景颜色改为透明
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
            label3.BackColor = Color.FromArgb(0, 0, 0, 0);
            textBox1.TabIndex = 0;
        }

        private void form4_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //修改按钮
            string consqlserver = "Data Source=.;Initial Catalog=workers;Integrated Security=True;";
            string sql = "select * from people where username='" + textBox1.Text + "' and password='" + textBox2.Text + "'";            
            SqlConnection con = new SqlConnection(consqlserver);
            con.Open();
            SqlCommand com = new SqlCommand(sql, con);
            SqlDataAdapter myadapter = new SqlDataAdapter(sql, con);
            DataTable usertable = new DataTable();
            myadapter.Fill(usertable);
            if (usertable.Rows.Count == 0)
            {
                MessageBox.Show("用户名或密码输入错误请重新输入");
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                con.Close();
            }
            else
            {
                string sql2 = "update people set password='" + textBox3.Text + "' where username='" + textBox1.Text + "'";
                SqlConnection con1 = new SqlConnection(consqlserver);
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("修改成功！");
                con.Close();
            }
            con.Dispose();
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            Font f = new Font("楷体", 14, FontStyle.Underline);
            label4.Font = f;
        }

        private void label4_MouseLeave(object sender, EventArgs e)
        {
            Font f = new Font("楷体", 14);
            label4.Font = f;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            form1 f1 = new form1();
            f1.Show();
            this.Hide();
        }

        private void form4_FormClosing(object sender, FormClosingEventArgs e)
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
