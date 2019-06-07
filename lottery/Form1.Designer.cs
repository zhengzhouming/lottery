namespace lottery
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtno = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.butcheck = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.abut0 = new System.Windows.Forms.RadioButton();
            this.abut1 = new System.Windows.Forms.RadioButton();
            this.abut2 = new System.Windows.Forms.RadioButton();
            this.abut3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnsubmit = new System.Windows.Forms.Button();
            this.labno = new System.Windows.Forms.Label();
            this.abut4 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.uName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uDept = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.note = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lotteryno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtno
            // 
            this.txtno.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.txtno.ForeColor = System.Drawing.Color.Red;
            this.txtno.Location = new System.Drawing.Point(10, 54);
            this.txtno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtno.Name = "txtno";
            this.txtno.Size = new System.Drawing.Size(235, 38);
            this.txtno.TabIndex = 0;
            this.txtno.Text = "0";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 80);
            this.button1.TabIndex = 1;
            this.button1.Text = "显示抽奖";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(210, 3);
            this.button2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 80);
            this.button2.TabIndex = 2;
            this.button2.Text = "隐藏抽奖";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // butcheck
            // 
            this.butcheck.Font = new System.Drawing.Font("宋体", 20F);
            this.butcheck.Location = new System.Drawing.Point(269, 23);
            this.butcheck.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.butcheck.Name = "butcheck";
            this.butcheck.Size = new System.Drawing.Size(119, 69);
            this.butcheck.TabIndex = 4;
            this.butcheck.Text = "check";
            this.butcheck.UseVisualStyleBackColor = true;
            this.butcheck.Click += new System.EventHandler(this.butcheck_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(106, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(106, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "IDno";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(106, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "dept";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeight = 30;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.uName,
            this.uDept,
            this.uNo,
            this.note,
            this.lotteryno});
            this.dataGridView1.Location = new System.Drawing.Point(405, 3);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(401, 536);
            this.dataGridView1.TabIndex = 8;
            // 
            // abut0
            // 
            this.abut0.AutoSize = true;
            this.abut0.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.abut0.ForeColor = System.Drawing.Color.Red;
            this.abut0.Location = new System.Drawing.Point(278, 75);
            this.abut0.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.abut0.Name = "abut0";
            this.abut0.Size = new System.Drawing.Size(114, 31);
            this.abut0.TabIndex = 9;
            this.abut0.TabStop = true;
            this.abut0.Text = "特等奖";
            this.abut0.UseVisualStyleBackColor = true;
            this.abut0.CheckedChanged += new System.EventHandler(this.abut0_CheckedChanged);
            this.abut0.Click += new System.EventHandler(this.butcheck_Click_1);
            // 
            // abut1
            // 
            this.abut1.AutoSize = true;
            this.abut1.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.abut1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.abut1.Location = new System.Drawing.Point(138, 75);
            this.abut1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.abut1.Name = "abut1";
            this.abut1.Size = new System.Drawing.Size(114, 31);
            this.abut1.TabIndex = 10;
            this.abut1.TabStop = true;
            this.abut1.Text = "一等奖";
            this.abut1.UseVisualStyleBackColor = true;
            this.abut1.CheckedChanged += new System.EventHandler(this.abut1_CheckedChanged);
            this.abut1.Click += new System.EventHandler(this.butcheck_Click_1);
            // 
            // abut2
            // 
            this.abut2.AutoSize = true;
            this.abut2.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.abut2.ForeColor = System.Drawing.Color.Purple;
            this.abut2.Location = new System.Drawing.Point(9, 75);
            this.abut2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.abut2.Name = "abut2";
            this.abut2.Size = new System.Drawing.Size(114, 31);
            this.abut2.TabIndex = 11;
            this.abut2.TabStop = true;
            this.abut2.Text = "二等奖";
            this.abut2.UseVisualStyleBackColor = true;
            this.abut2.CheckedChanged += new System.EventHandler(this.abut2_CheckedChanged);
            // 
            // abut3
            // 
            this.abut3.AutoSize = true;
            this.abut3.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.abut3.ForeColor = System.Drawing.Color.Blue;
            this.abut3.Location = new System.Drawing.Point(214, 27);
            this.abut3.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.abut3.Name = "abut3";
            this.abut3.Size = new System.Drawing.Size(114, 31);
            this.abut3.TabIndex = 12;
            this.abut3.TabStop = true;
            this.abut3.Text = "三等奖";
            this.abut3.UseVisualStyleBackColor = true;
            this.abut3.CheckedChanged += new System.EventHandler(this.abut3_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.labno);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.butcheck);
            this.groupBox1.Controls.Add(this.txtno);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(3, 199);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox1.Size = new System.Drawing.Size(400, 276);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "详细信息";
            // 
            // btnsubmit
            // 
            this.btnsubmit.Font = new System.Drawing.Font("宋体", 15F);
            this.btnsubmit.Location = new System.Drawing.Point(2, 477);
            this.btnsubmit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(400, 63);
            this.btnsubmit.TabIndex = 9;
            this.btnsubmit.Text = "submit";
            this.btnsubmit.UseVisualStyleBackColor = true;
            this.btnsubmit.Click += new System.EventHandler(this.btnsubmit_Click);
            // 
            // labno
            // 
            this.labno.AutoSize = true;
            this.labno.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.labno.ForeColor = System.Drawing.Color.Red;
            this.labno.Location = new System.Drawing.Point(7, 23);
            this.labno.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.labno.Name = "labno";
            this.labno.Size = new System.Drawing.Size(152, 27);
            this.labno.TabIndex = 8;
            this.labno.Text = "中奖号码：";
            // 
            // abut4
            // 
            this.abut4.AutoSize = true;
            this.abut4.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.abut4.ForeColor = System.Drawing.Color.Black;
            this.abut4.Location = new System.Drawing.Point(51, 27);
            this.abut4.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.abut4.Name = "abut4";
            this.abut4.Size = new System.Drawing.Size(114, 31);
            this.abut4.TabIndex = 14;
            this.abut4.TabStop = true;
            this.abut4.Text = "四等奖";
            this.abut4.UseVisualStyleBackColor = true;
            this.abut4.CheckedChanged += new System.EventHandler(this.abut4_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.abut4);
            this.groupBox2.Controls.Add(this.abut3);
            this.groupBox2.Controls.Add(this.abut2);
            this.groupBox2.Controls.Add(this.abut1);
            this.groupBox2.Controls.Add(this.abut0);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBox2.Location = new System.Drawing.Point(3, 87);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.groupBox2.Size = new System.Drawing.Size(400, 111);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "奖项等级";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 228);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 27);
            this.label1.TabIndex = 11;
            this.label1.Text = "dept";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(13, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 27);
            this.label5.TabIndex = 10;
            this.label5.Text = "IDno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(13, 111);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 27);
            this.label6.TabIndex = 9;
            this.label6.Text = "name";
            // 
            // uName
            // 
            this.uName.HeaderText = "姓名";
            this.uName.Name = "uName";
            this.uName.Width = 60;
            // 
            // uDept
            // 
            this.uDept.HeaderText = "部门";
            this.uDept.Name = "uDept";
            this.uDept.Width = 60;
            // 
            // uNo
            // 
            this.uNo.HeaderText = "工号";
            this.uNo.Name = "uNo";
            this.uNo.Width = 60;
            // 
            // note
            // 
            this.note.HeaderText = "中奖等级";
            this.note.Name = "note";
            this.note.Width = 88;
            // 
            // lotteryno
            // 
            this.lotteryno.HeaderText = "中奖号码";
            this.lotteryno.Name = "lotteryno";
            this.lotteryno.Width = 88;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 544);
            this.Controls.Add(this.btnsubmit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "颖昌国际颖强事业部周年庆抽奖记录系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.butcheck_Click_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button butcheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton abut0;
        private System.Windows.Forms.RadioButton abut1;
        private System.Windows.Forms.RadioButton abut2;
        private System.Windows.Forms.RadioButton abut3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labno;
        private System.Windows.Forms.Button btnsubmit;
        private System.Windows.Forms.RadioButton abut4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn uName;
        private System.Windows.Forms.DataGridViewTextBoxColumn uDept;
        private System.Windows.Forms.DataGridViewTextBoxColumn uNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn note;
        private System.Windows.Forms.DataGridViewTextBoxColumn lotteryno;
    }
}

