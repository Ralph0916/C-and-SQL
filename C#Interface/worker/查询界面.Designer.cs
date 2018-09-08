namespace worker
{
    partial class selec
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.员工编号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.性别DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.年龄DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.电话DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.工资DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.部门DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.职位DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.workersDataSet = new worker.workersDataSet();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listTableAdapter = new worker.workersDataSetTableAdapters.listTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(178, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "返回主界面";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.员工编号DataGridViewTextBoxColumn,
            this.姓名DataGridViewTextBoxColumn,
            this.性别DataGridViewTextBoxColumn,
            this.年龄DataGridViewTextBoxColumn,
            this.电话DataGridViewTextBoxColumn,
            this.工资DataGridViewTextBoxColumn,
            this.部门DataGridViewTextBoxColumn,
            this.职位DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.listBindingSource;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(12, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(499, 85);
            this.dataGridView1.TabIndex = 4;
            // 
            // 员工编号DataGridViewTextBoxColumn
            // 
            this.员工编号DataGridViewTextBoxColumn.DataPropertyName = "员工编号";
            this.员工编号DataGridViewTextBoxColumn.HeaderText = "员工编号";
            this.员工编号DataGridViewTextBoxColumn.Name = "员工编号DataGridViewTextBoxColumn";
            this.员工编号DataGridViewTextBoxColumn.Width = 114;
            // 
            // 姓名DataGridViewTextBoxColumn
            // 
            this.姓名DataGridViewTextBoxColumn.DataPropertyName = "姓名";
            this.姓名DataGridViewTextBoxColumn.HeaderText = "姓名";
            this.姓名DataGridViewTextBoxColumn.Name = "姓名DataGridViewTextBoxColumn";
            this.姓名DataGridViewTextBoxColumn.Width = 74;
            // 
            // 性别DataGridViewTextBoxColumn
            // 
            this.性别DataGridViewTextBoxColumn.DataPropertyName = "性别";
            this.性别DataGridViewTextBoxColumn.HeaderText = "性别";
            this.性别DataGridViewTextBoxColumn.Name = "性别DataGridViewTextBoxColumn";
            this.性别DataGridViewTextBoxColumn.Width = 74;
            // 
            // 年龄DataGridViewTextBoxColumn
            // 
            this.年龄DataGridViewTextBoxColumn.DataPropertyName = "年龄";
            this.年龄DataGridViewTextBoxColumn.HeaderText = "年龄";
            this.年龄DataGridViewTextBoxColumn.Name = "年龄DataGridViewTextBoxColumn";
            this.年龄DataGridViewTextBoxColumn.Width = 74;
            // 
            // 电话DataGridViewTextBoxColumn
            // 
            this.电话DataGridViewTextBoxColumn.DataPropertyName = "电话";
            this.电话DataGridViewTextBoxColumn.HeaderText = "电话";
            this.电话DataGridViewTextBoxColumn.Name = "电话DataGridViewTextBoxColumn";
            this.电话DataGridViewTextBoxColumn.Width = 74;
            // 
            // 工资DataGridViewTextBoxColumn
            // 
            this.工资DataGridViewTextBoxColumn.DataPropertyName = "工资";
            this.工资DataGridViewTextBoxColumn.HeaderText = "工资";
            this.工资DataGridViewTextBoxColumn.Name = "工资DataGridViewTextBoxColumn";
            this.工资DataGridViewTextBoxColumn.Width = 74;
            // 
            // 部门DataGridViewTextBoxColumn
            // 
            this.部门DataGridViewTextBoxColumn.DataPropertyName = "部门";
            this.部门DataGridViewTextBoxColumn.HeaderText = "部门";
            this.部门DataGridViewTextBoxColumn.Name = "部门DataGridViewTextBoxColumn";
            this.部门DataGridViewTextBoxColumn.Width = 74;
            // 
            // 职位DataGridViewTextBoxColumn
            // 
            this.职位DataGridViewTextBoxColumn.DataPropertyName = "职位";
            this.职位DataGridViewTextBoxColumn.HeaderText = "职位";
            this.职位DataGridViewTextBoxColumn.Name = "职位DataGridViewTextBoxColumn";
            this.职位DataGridViewTextBoxColumn.Width = 74;
            // 
            // listBindingSource
            // 
            this.listBindingSource.DataMember = "list";
            this.listBindingSource.DataSource = this.workersDataSet;
            // 
            // workersDataSet
            // 
            this.workersDataSet.DataSetName = "workersDataSet";
            this.workersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "查询";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(421, 50);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(73, 41);
            this.button2.TabIndex = 6;
            this.button2.Text = "清空";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "请输入学号：";
            // 
            // listTableAdapter
            // 
            this.listTableAdapter.ClearBeforeFill = true;
            // 
            // selec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::worker.Properties.Resources.b50c653b6d33117dd350dfc6ff063381;
            this.ClientSize = new System.Drawing.Size(523, 337);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("楷体", 14.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "selec";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "查询员工信息";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.selec_FormClosing);
            this.Load += new System.EventHandler(this.selec_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workersDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private workersDataSet workersDataSet;
        private System.Windows.Forms.BindingSource listBindingSource;
        private workersDataSetTableAdapters.listTableAdapter listTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 员工编号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 性别DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 年龄DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 电话DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 工资DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 部门DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 职位DataGridViewTextBoxColumn;
    }
}