﻿using System;
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
    public partial class form7 : Form
    {
        public form7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string constr = "Data Source=.;Initial Catalog=workers;Integrated Security=True;";
            //string sql = "delete from list where 员工编号='" +textBox1.Text+"'";
            //SqlConnection con = new SqlConnection(constr);
            //SqlCommand cmd = new SqlCommand(sql, con);
            //con.Open();
            //cmd.ExecuteNonQuery();
            MessageBox.Show("删除成功！", "成功提示");
            //con.Close();
        }

        private void form7_FormClosing(object sender, FormClosingEventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {
            form2 f2 = new form2();
            f2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void form7_Load(object sender, EventArgs e)
        {
        }
    }
}
