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

namespace QLKS
{
    public partial class F_TimKiem_KH : Form
    {
        public F_TimKiem_KH()
        {
            InitializeComponent();
            getviewkh();
        }

        private void getviewkh()
        {
            string query = "select * from KhachHang";
            V_KH.DataSource = GetData.getdata(query, false, false);
            V_KH.Columns[0].HeaderText = "Mã khách hàng";
            V_KH.Columns[1].HeaderText = "Họ tên";
            V_KH.Columns[2].HeaderText = "Căn cước công dân";
            V_KH.Columns[3].HeaderText = "Địa chỉ";
            V_KH.Columns[4].HeaderText = "Số điện thoại";
            V_KH.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            V_KH.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void F_TimKiem_KH_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn item in V_KH.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_timkiem.Text = "";
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                string query = "select * from KhachHang where HoTen like @ten";
                GetData.com = new SqlCommand(query, GetData.con);
                GetData.com.Parameters.Add("@ten", SqlDbType.NVarChar).Value = tb_timkiem.Text + "%";
                V_KH.DataSource = GetData.getdata(query, false, true);
            }

            if (comboBox1.SelectedIndex == 1)
            {
                string query = "select * from KhachHang where CCCD like @cccd";
                GetData.com = new SqlCommand(query, GetData.con);
                GetData.com.Parameters.Add("@cccd", tb_timkiem.Text + "%");
                V_KH.DataSource = GetData.getdata(query, false, true);
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
