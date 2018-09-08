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
    public partial class selec : Form
    {
        public selec()
        {
            InitializeComponent();
            label1.BackColor = Color.FromArgb(0, 0, 0, 0);
            label2.BackColor = Color.FromArgb(0, 0, 0, 0);
        }

        private void selec_Load(object sender, EventArgs e)
        {
        }

        private void selec_FormClosing(object sender, FormClosingEventArgs e)
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

        private void label1_MouseHover(object sender, EventArgs e)
        {
            Font f = new Font("楷体", 14, FontStyle.Underline);
            label1.Font = f;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            Font f = new Font("楷体", 14);
            label1.Font = f;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            form2 f2 = new form2();
            f2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string constr = "Data Source=.;Initial Catalog=workers;Integrated Security=True;";
            string sql = "select * from list where 员工编号='"+textBox1.Text+"'";
            SqlConnection con = new SqlConnection(constr);
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        dataGridView1.Rows[0].Cells[i].Value = reader[i];
                    }
                }
            }
            else
                MessageBox.Show("该员工不存在","提示信息");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            for(int i=0;i<dataGridView1.ColumnCount;i++)
            { 
                dataGridView1.Rows[0].Cells[i].Value = "";
            }
        }
    }
}
