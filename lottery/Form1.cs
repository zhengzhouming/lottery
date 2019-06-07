using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static lottery.lotteryall;

namespace lottery
{
   

    public partial class Form1 : Form
    {


        string ID;
        string name;
        string no;
        string dept;

        

        public Form1()
        {
            InitializeComponent();
        }

       

        public void Change_Text(string str)
        {
            txtno.Text = str;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            abut4.Checked = true;
            txtno.Text = "";
          
        }

        private void abut4_CheckedChanged(object sender, EventArgs e)
        {
            
                if (abut4.Checked == true)
            {
                labno.ForeColor = abut4.ForeColor;
                txtno.ForeColor = abut4.ForeColor;
                butcheck.ForeColor = abut4.ForeColor;
                label2.ForeColor = abut4.ForeColor;
                label3.ForeColor = abut4.ForeColor;
                label4.ForeColor = abut4.ForeColor;
                label1.ForeColor = abut4.ForeColor;
                label5.ForeColor = abut4.ForeColor;
                label6.ForeColor = abut4.ForeColor;

            }
        }

        private void abut3_CheckedChanged(object sender, EventArgs e)
        {
            if (abut3.Checked == true)
            {
                labno.ForeColor = abut3.ForeColor;
                txtno.ForeColor = abut3.ForeColor;
                butcheck.ForeColor = abut3.ForeColor;
                label2.ForeColor = abut3.ForeColor;
                label3.ForeColor = abut3.ForeColor;
                label4.ForeColor = abut3.ForeColor;
                label1.ForeColor = abut3.ForeColor;
                label5.ForeColor = abut3.ForeColor;
                label6.ForeColor = abut3.ForeColor;

            }
           
        }

        private void abut2_CheckedChanged(object sender, EventArgs e)
        {
            if (abut2.Checked == true)
            {
                labno.ForeColor = abut2.ForeColor;
                txtno.ForeColor = abut2.ForeColor;
                butcheck.ForeColor = abut2.ForeColor;
                label2.ForeColor = abut2.ForeColor;
                label3.ForeColor = abut2.ForeColor;
                label4.ForeColor = abut2.ForeColor;
                label1.ForeColor = abut2.ForeColor;
                label5.ForeColor = abut2.ForeColor;
                label6.ForeColor = abut2.ForeColor;

            }
        }

        private void abut1_CheckedChanged(object sender, EventArgs e)
        {
            if (abut1.Checked == true)
            {
                labno.ForeColor = abut1.ForeColor;
                txtno.ForeColor = abut1.ForeColor;
                butcheck.ForeColor = abut1.ForeColor;
                label2.ForeColor = abut1.ForeColor;
                label3.ForeColor = abut1.ForeColor;
                label4.ForeColor = abut1.ForeColor;
                label1.ForeColor = abut1.ForeColor;
                label5.ForeColor = abut1.ForeColor;
                label6.ForeColor = abut1.ForeColor;

            }
        }

        private void abut0_CheckedChanged(object sender, EventArgs e)
        {
            if (abut0.Checked == true)
            {
                labno.ForeColor = abut0.ForeColor;
                txtno.ForeColor = abut0.ForeColor;
                butcheck.ForeColor = abut0.ForeColor;
                label2.ForeColor = abut0.ForeColor;
                label3.ForeColor = abut0.ForeColor;
                label4.ForeColor = abut0.ForeColor;
                label1.ForeColor = abut0.ForeColor;
                label5.ForeColor = abut0.ForeColor;
                label6.ForeColor = abut0.ForeColor;

            } 
        }

        private void butcheck_Click_1(object sender, EventArgs e)
        {

            string uId = txtno.Text.Trim();
            
            if (uId.Length > 0)
            {
                DataTable empdt = getEmployeeInfo(uId);
                if (empdt!= null)
                {
                    showempinfo(empdt);

                }
                else
                {
                    label2.Text = "没有此员工";
                    label3.Text = "";
                    label4.Text = "";

                    ID = "";
                    name = "";
                    no = "";
                    dept = "";
                }
            } 

           
        }
        //获取员工资料
        //uNo 中奖条号码
        
        public DataTable getEmployeeInfo(string uId)
        {
            //查找指令的TYPE
            string sql = @"SELECT * FROM dbo.T_emp WHERE uId="+ uId +";";
            DataTable dt = SqlHelper.ExcuteTable(sql);
            if (dt.Rows.Count > 0)
            {
                return dt;
            }
            else {
                return null;
            }
        }
        public void showempinfo(DataTable empdt) {

            label2.Text = empdt.Rows[0]["uName"].ToString();
            label3.Text = empdt.Rows[0]["uNo"].ToString();
            label4.Text = empdt.Rows[0]["uDept"].ToString();


             ID= txtno.Text;
             name = empdt.Rows[0]["uName"].ToString(); 
             no= empdt.Rows[0]["uNo"].ToString(); 
             dept= empdt.Rows[0]["uDept"].ToString(); 
        }

          

        private void button1_Click(object sender, EventArgs e)
        {
            lotteryall f2 = lotteryall.GetSingleton();
            //f2.ID = ID;
            //f2.ChangeText += new ChangeTextHandler(Change_Text);//将事件和处理方法绑在一起，这句话必须放在f2.ShowDialog();前面
            f2.Show();
            //frm.Show();
            f2.Activate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lotteryall f2 = lotteryall.GetSingleton();
            f2.Visible = false;
           
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            lotteryall f2 = lotteryall.GetSingleton();
            f2.ID = ID;
            f2.name = name;
            f2.no = no;
            f2.dept = dept;
            f2.ChangeText += new ChangeTextHandler(Change_Text);//将事件和处理方法绑在一起，这句话必须放在f2.ShowDialog();前面
            f2.Show();
        }
    }
}
