using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace worker
{
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
            textBox1.TabIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ////添加按钮
            //string constr = "Data Source=.;Initial Catalog=workers;Integrated Security=True;";
            //string sql = "insert into list values('" + textBox5.Text + "','" + textBox1.Text + "','" + comboBox1.Text + "',"+textBox3.Text+ ",'" + textBox7.Text + "'," + textBox4.Text + ",'" + textBox6.Text + "','" + textBox8.Text + "')";
            //SqlConnection con = new SqlConnection(constr);
            //SqlCommand cmd = new SqlCommand(sql, con);
            //con.Open();
            //cmd.ExecuteNonQuery();
            MessageBox.Show("插入成功！", "提示");
            //con.Close();
        }

        private void add_Load(object sender, EventArgs e)
        {         
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void add_FormClosing(object sender, FormClosingEventArgs e)
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

        private void label9_Click(object sender, EventArgs e)
        {
            form2 f2 = new form2();
            f2.Show();
            this.Hide();
        }
    }
}
