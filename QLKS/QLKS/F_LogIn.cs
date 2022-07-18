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
using System.Globalization;


namespace QLKS
{
    public partial class F_LogIn : Form
    {
        static public TaiKhoan TK = new TaiKhoan();
        static public string lgtime;

        public DataTable tb;
        static string url = "Data Source=msi;Initial Catalog=QLKS;User ID=sa;Password=djtcumay";
        //SqlConnection con = new SqlConnection(url);
        //SqlCommand com;
        //SqlDataReader read;
        public F_LogIn()
        {
            
            InitializeComponent();
            txt_User.Select();
            panel1.BackColor = Color.FromArgb(200, 255, 255, 255);
            //KhoiTao();
            Xulysukien();
            //LayDuLieu();
            
        }

        private bool SoSanhDuLieu()
        {
            bool ss = false;
            //con.Open();
            string query = "SELECT CAST(COUNT(1) AS BIT) AS Expr1 FROM TK WHERE username = @user AND pass = @pass";
            //com = new SqlCommand();
            //com.Connection = con;
            //com.CommandText = query;
            GetData.con.Open();
            GetData.com = new SqlCommand(query, GetData.con);
            GetData.com.Parameters.Add("@user", txt_User.Text);
            GetData.com.Parameters.Add("@pass", txt_Pass.Text);
            //read = com.ExecuteReader();
            //if (read.HasRows)
            //{
            //    while (read.Read())
            //    {
            //        ss = read.GetBoolean(0);
            //    }
            //}
            //con.Close();
            //com.Dispose();
            //read.Close();
            return GetData.testdata(false);
        }

        private void layTK()
        {
            string query = "SELECT * FROM TK WHERE username = @user AND pass = @pass";
            GetData.con.Open();
            GetData.com = new SqlCommand(query, GetData.con);
            GetData.com.Parameters.Add("@user", txt_User.Text);
            GetData.com.Parameters.Add("@pass", txt_Pass.Text);
            GetData.testdata(true);
        }
        private void Xulysukien()
        {
            
            btn_login.Click += Btn_login_Click;
            btn_Exit.Click += Btn_Exit_Click;
        }

        private void Btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {

            if (SoSanhDuLieu())
            {
                layTK();
                MessageBox.Show("Đăng nhập thành công!!!!");
                //TK.user = txt_User.Text;
                //TK.pass = txt_Pass.Text;
                this.Hide();
                lgtime = DateTime.Now.ToString();
                new F_GiaoDienChinh().ShowDialog();
                this.Close();
                
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu sai!!!!");
            }

        }

        private void F_LogIn_Load(object sender, EventArgs e)
        {
            lb_Clock.BackColor = Color.FromArgb(200, 255, 255, 255);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            //culture.DateTimeFormat.FullDateTimePattern = "dddd, dd MMMM yyyy HH:mm: ss";
            lb_Clock.Text = DateTime.Now.ToString(culture.DateTimeFormat.FullDateTimePattern= "dddd, dd MMMM yyyy HH:mm: ss",culture);
        }
    }
}
