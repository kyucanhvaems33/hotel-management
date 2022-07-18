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
            this.Dispose();
            new F_LogIn().ShowDialog();
        }

        private void F_GiaoDienChinh_Load(object sender, EventArgs e)
        {
            if (F_LogIn.TK.quyen == "ADMIN")
            {
                QLTKToolStripMenuItem.Enabled = true;
                QLNVToolStripMenuItem.Enabled = true;
                QLHSToolStripMenuItem.Enabled = true;
            }
            else
            {
                QLTKToolStripMenuItem.Enabled = false;
                QLNVToolStripMenuItem.Enabled = false;
                QLHSToolStripMenuItem.Enabled = false;

            }
            timer1.Start();
            toolStrip_info_lgtime.Text = "Login time: " + F_LogIn.lgtime;
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

        private void QLTKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new F_QLTK().ShowDialog();
            this.Show();
        }
    }
}
