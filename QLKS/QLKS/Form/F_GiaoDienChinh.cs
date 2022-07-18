using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.SqlClient;

namespace QLKS
{
    public partial class F_GiaoDienChinh : Form
    {
        public F_GiaoDienChinh()
        {           
            InitializeComponent();
            
        }

        private void GioiThieuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ĐăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            putlogouttime();
            this.Dispose();
            new F_LogIn().ShowDialog();
        }

        private void putlogouttime()
        {
            string query = "update listlogintime set logout = @logout where username = @user";
            GetData.con.Open();
            GetData.com = new SqlCommand(query, GetData.con);
            GetData.com.Parameters.Add("@user", F_LogIn.TK.user);
            GetData.com.Parameters.Add("@logout", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", new CultureInfo("vi-VN")));
            GetData.putdata();
        }

        private void F_GiaoDienChinh_Load(object sender, EventArgs e)
        {
            if (F_LogIn.TK.quyen == "ADMIN")
            {
                QLTKToolStripMenuItem.Enabled = true;
                QLNVToolStripMenuItem.Enabled = true;
                QLHSToolStripMenuItem.Enabled = true;
                ThongKeToolStripMenuItem.Enabled = true;
            }
            else
            {
                QLTKToolStripMenuItem.Enabled = false;
                QLNVToolStripMenuItem.Enabled = false;
                QLHSToolStripMenuItem.Enabled = false;
                ThongKeToolStripMenuItem.Enabled = false;

            }
            timer1.Start();
            toolStrip_info_lgtime.Text = "Login time: " + F_LogIn.lgtime;
            toolStripten.Text = F_LogIn.TK.htnv;
            toolStripquyen.Text = F_LogIn.TK.quyen;

            string query = "update Phong set MaNV = @manv";
            GetData.con.Open();
            GetData.com = new SqlCommand(query, GetData.con);
            GetData.com.Parameters.Add("@MaNV", F_LogIn.TK.MaNV);
            GetData.putdata();

            query = "update DichVu set MaNV = @manv";
            GetData.con.Open();
            GetData.com = new SqlCommand(query, GetData.con);
            GetData.com.Parameters.Add("@MaNV", F_LogIn.TK.MaNV);
            GetData.putdata();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            CultureInfo culture = new CultureInfo("vi-VN");
            toolStrip_lb_clock.Text = DateTime.Now.ToString(culture.DateTimeFormat.FullDateTimePattern = "dddd, dd MMMM yyyy HH:mm: ss", culture);
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new F_QLKH().ShowDialog();
            this.Show();
        }

        private void quảnLýPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new F_QLP().ShowDialog();
            this.Show();
        }

        private void quảnLýDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new F_QLDV().ShowDialog();
            this.Show();
        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new F_QLNV().ShowDialog();
            this.Show();
        }

        private void thuêPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new F_THUE().ShowDialog();
            this.Show();
        }

        private void trảPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new F_TRA().ShowDialog();
            this.Show();
        }

        private void sửDụngDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new F_SDDV().ShowDialog();
            this.Show();
        }

        private void phiếuThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new F_PhieuThue().ShowDialog();
            this.Show();
        }

        private void hoáĐơnDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new F_HoaDonSDDV().ShowDialog();
            this.Show();
        }

        private void hoáĐơnThanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new F_HoaDonThanhToan().ShowDialog();
            this.Show();
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new F_TimKiem_KH().ShowDialog();
            this.Show();
        }

        private void phòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new F_TimKiem_P().ShowDialog();
            this.Show();
        }

        private void doanhThuPhòngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new F_DoanhThu_P().ShowDialog();
            this.Show();
        }

        private void doanhThuDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new F_DoanhThu_DV().ShowDialog();
            this.Show();
        }

        private void F_GiaoDienChinh_FormClosing(object sender, FormClosingEventArgs e)
        {
            putlogouttime();
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new F_QLTK().ShowDialog();
            this.Show();
        }

        private void thờiGianInOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new F_LogInOut().ShowDialog();
            this.Show();
        }
    }
}
