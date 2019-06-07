using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lottery
{
    public partial class lotteryall : Form
    {
        static lotteryall frm;

        public string ID //将外部不可访问的textBox2.Text封装成属性TextBox1Value
        {
            set { labuID.Text = value; }
           // get { return textBox2.Text; }
        }
        public string name //将外部不可访问的textBox2.Text封装成属性TextBox1Value
        {
            set { labuname.Text = value; }
            // get { return textBox2.Text; }
        }
        public string no //将外部不可访问的textBox2.Text封装成属性TextBox1Value
        {
            set { labuno.Text = value; }
            // get { return textBox2.Text; }
        }
        public string dept //将外部不可访问的textBox2.Text封装成属性TextBox1Value
        {
            set { labudept.Text = value; }
            // get { return textBox2.Text; }
        }

         

        public delegate void ChangeTextHandler(string str);  //定义委托
        public lotteryall()
        {
            InitializeComponent();
        }
        public static lotteryall GetSingleton()
        {
            if (frm == null || frm.IsDisposed)
            {                               
                //frm.ID = uID;
                //frm.name = uname;
                //frm.no = uno;
                //frm.dept = udept;
                frm = new lotteryall();
            }
            return frm;
        }


        public event ChangeTextHandler ChangeText;  //定义事件

        private void button2_Click(object sender, EventArgs e)
        {
            if (ChangeText != null)//判断事件是否为空
            {
                ChangeText(labuID.Text);//执行委托实例  
                this.Close();
            }
        }



        private void lotteryall_Load(object sender, EventArgs e)
        {
            if (Screen.AllScreens.Length == 1)
            {
                MessageBox.Show("只检测到1个屏幕");
                this.Top = Screen.AllScreens[0].Bounds.Y;
                this.Left = Screen.AllScreens[0].Bounds.X;

                //最大化  修正显示比例
                this.WindowState = FormWindowState.Maximized;
                
                //UID
                labuID.Top = this.Top;
                labuID.Left = this.Left;
                labuID.Width = this.Width;
                labuID.Height = this.Height - Convert.ToInt32( (this.Height * 0.20));
                labuID.ForeColor = Color.Red;
                this.labuID.Font = new Font("宋体",250,FontStyle.Bold);

                //uname
                labuname.Top = this.Top + labuID.Height;
                labuname.Left = this.Left;
                labuname.Width = Convert.ToInt32( this.Width * 0.30);
                labuname.Height = Convert.ToInt32((this.Height * 0.20));
                labuname.ForeColor = Color.Blue;
                this.labuname.Font = new Font("宋体", 70, FontStyle.Bold);


                //uno
                labuno.Top = labuname.Top;
                labuno.Left = this.Left + labuname.Width;
                labuno.Width = Convert.ToInt32(this.Width * 0.40);
                labuno.Height = labuname.Height;
                labuno.ForeColor = Color.Blue;
                this.labuno.Font = new Font("宋体", 70, FontStyle.Bold);

                //udept
                labudept.Top = labuname.Top;
                labudept.Left = this.Left + labuname.Width+ labuno.Width;
                labudept.Width = Convert.ToInt32(this.Width * 0.30);
                labudept.Height = labuname.Height;
                labudept.ForeColor = Color.Blue;
                this.labudept.Font = new Font("宋体", 70, FontStyle.Bold);

            }

                if (Screen.AllScreens.Length == 2)
            {
                //此显示器是否为主屏
                if (Screen.AllScreens[0].Primary)
                {
                    this.Top = Screen.AllScreens[1].Bounds.Y;
                    this.Left = Screen.AllScreens[1].Bounds.X;
                }
                else
                {
                    this.Top = Screen.AllScreens[0].Bounds.Y;
                    this.Left = Screen.AllScreens[0].Bounds.X;
                }
            }
            else if (Screen.AllScreens.Length == 3)
            {
                this.Top = Screen.AllScreens[2].Bounds.Y;
                this.Left = Screen.AllScreens[2].Bounds.X;
            }
        }

    }
}
