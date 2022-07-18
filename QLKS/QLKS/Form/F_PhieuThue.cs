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
    public partial class F_PhieuThue : Form
    {
        private bool print = false;

        public F_PhieuThue()
        {
            InitializeComponent();
            getviewthue();
        }

        private void getviewthue()
        {
            string query = "select * from Thue";
            V_PhieuThue.DataSource = GetData.getdata(query, false, false);
            V_PhieuThue.Columns[0].HeaderText = "Số phiếu thuê";
            V_PhieuThue.Columns[1].HeaderText = "Ngày thuê";
            V_PhieuThue.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            V_PhieuThue.Columns[2].HeaderText = "Mã Phòng";
            V_PhieuThue.Columns[3].HeaderText = "Mã khách hàng";
            //F_THUE_V.DataSource = GetData.getdata(query, false, false);
            V_PhieuThue.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            V_PhieuThue.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void F_PhieuThue_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn item in V_PhieuThue.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            tb_timkiem.Text = "";
            V_PhieuThue.CurrentCell = null;
        }

        private void V_PhieuThue_SelectionChanged(object sender, EventArgs e)
        {
            btn_in.Enabled = true;
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            if (V_PhieuThue.CurrentCell != null)
            {
                DialogResult a = MessageBox.Show(null, "Bạn có muốn in phiếu thuê không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (a == DialogResult.Yes)
                {
                    F_THUE.sophieu = Convert.ToInt32(V_PhieuThue.CurrentRow.Cells[0].Value);
                    this.Hide();
                    new F_Export_Thue().ShowDialog();
                    V_PhieuThue.CurrentCell = null;
                    btn_in.Enabled = false;
                }
            }
            else MessageBox.Show("Vui lòng chọn một phiếu trên danh sách phiếu thuê để in!");
            
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            if (tb_timkiem.Text == "")
            {
                getviewthue();
                V_PhieuThue.CurrentCell = null;
            }
            else
            {
                foreach (RadioButton item in panel1.Controls)
                {
                    if (item.Checked && item.Text == "Số phiếu thuê")
                    {
                        string query = "select * from Thue where SoPhieuThue like @sophieu";
                        GetData.com = new SqlCommand(query, GetData.con);
                        GetData.com.Parameters.Add("@sophieu", tb_timkiem.Text + "%");
                        V_PhieuThue.DataSource = GetData.getdata(query, false, true);
                    }

                    if (item.Checked && item.Text == "Họ tên khách hàng")
                    {
                        string query = "select SoPhieuThue,NgayThue,MaPhong,Thue.MaKH from Thue, KhachHang where Thue.MaKH = KhachHang.MaKH AND KhachHang.HoTen like @hoten";
                        GetData.com = new SqlCommand(query, GetData.con);
                        GetData.com.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = tb_timkiem.Text + "%";
                        V_PhieuThue.DataSource = GetData.getdata(query, false, true);
                    }

                    if (item.Checked && item.Text == "Mã phòng")
                    {
                        string query = "select * from Thue where MaPhong like @mp";
                        GetData.com = new SqlCommand(query, GetData.con);
                        GetData.com.Parameters.Add("@mp", tb_timkiem.Text + "%");
                        V_PhieuThue.DataSource = GetData.getdata(query, false, true);
                    }

                    if (item.Checked && item.Text == "CCCD")
                    {
                        string query = "select SoPhieuThue,NgayThue,MaPhong,Thue.MaKH,KhachHang.HoTen from Thue, KhachHang where Thue.MaKH = KhachHang.MaKH AND KhachHang.CCCD like @cccd";
                        GetData.com = new SqlCommand(query, GetData.con);
                        GetData.com.Parameters.Add("@cccd", tb_timkiem.Text + "%");
                        V_PhieuThue.DataSource = GetData.getdata(query, false, true);
                    }
                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
