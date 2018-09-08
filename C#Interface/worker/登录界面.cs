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
using System.Reflection;

namespace worker
{
    public partial class form1 : Form
    {        
        public form1()
        {
            InitializeComponent();
            textBox1.TabIndex = 0;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //清空按钮
            textBox1.Clear();
            textBox2.Clear();
            label6.Text = "";
            textBox1.Focus();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ////确定按钮     
            ////字符串赋值:用户名 密码  
            //string username = textBox1.Text.Trim();
            //string password = textBox2.Text.Trim();

            ////定义数据库连接语句:服务器=.(本地) 数据库名=TelephoneMS(手机管理系统)  
            //string consqlserver = "Data Source=.;Initial Catalog=workers;Integrated Security=True;";

            ////定义SQL查询语句:用户名 密码  
            //string sql = "select * from people where username='" + username + "' and password='" + password + "'";

            ////定义SQL Server连接对象 打开数据库  
            //SqlConnection con = new SqlConnection(consqlserver);
            //con.Open();

            ////定义查询命令:表示对数据库执行一个SQL语句或存储过程  
            //SqlCommand com = new SqlCommand(sql, con);
            //SqlDataAdapter myadapter = new SqlDataAdapter(sql, con);
            //DataTable usertable = new DataTable();
            //try
            //{
            //    myadapter.Fill(usertable);
            //    //如果存在用户名和密码正确数据执行进入系统操作  
            //    if (usertable.Rows.Count == 0)
            //    {
            //        label6.Text = "用户名或密码错误，请重新输入！";
            //        textBox1.Clear();
            //        textBox2.Clear();
            //    }
            //    else
            //    {
            MessageBox.Show("登陆成功！");
            form2 f2 = new form2();
            f2.Show();
            this.Hide();
            //    }
            //}
            //catch (Exception msg)
            //{
            //    throw new Exception(msg.ToString());  //处理异常信息  
            //}
            //finally
            //{
            //    con.Close();                    //关闭连接  
            //    con.Dispose();                  //释放连接  
            //}
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //注册按钮
            form3 f3 = new form3();
            f3.Show();
            this.Hide();
        }
        private void label5_Click(object sender, EventArgs e)
        {
            //修改密码
            form4 f4 = new form4();
            f4.Show();
            this.Hide();
        }

        private void form1_FormClosing(object sender, FormClosingEventArgs e)
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
