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
    public partial class F_HoaDonThanhToan : Form
    {
        public F_HoaDonThanhToan()
        {
            InitializeComponent();
            getviewtra();
        }

        private void getviewtra()
        {
            string query = "select * from Tra";
            V_HoaDon.DataSource = GetData.getdata(query, false, false);
            V_HoaDon.Columns[0].HeaderText = "Số hoá đơn";
            V_HoaDon.Columns[1].HeaderText = "Ngày trả";
            V_HoaDon.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            V_HoaDon.Columns[2].HeaderText = "Ngày thuê";
            V_HoaDon.Columns[2].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            V_HoaDon.Columns[3].HeaderText = "Số phiếu thuê";
            V_HoaDon.Columns[4].HeaderText = "Mã khách hàng";
            V_HoaDon.Columns[5].HeaderText = "Mã phòng";
            //F_THUE_V.DataSource = GetData.getdata(query, false, false);
            V_HoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            V_HoaDon.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void F_HoaDonThanhToan_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn item in V_HoaDon.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            tb_timkiem.Text = "";
            V_HoaDon.CurrentCell = null;
        }

        private void V_HoaDon_SelectionChanged(object sender, EventArgs e)
        {
            btn_in.Enabled = true;
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            if (V_HoaDon.CurrentCell != null)
            {
                DialogResult a = MessageBox.Show(null, "Bạn có muốn in hoá đơn thanh toán không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (a == DialogResult.Yes)
                {
                    F_TRA.matra = Convert.ToInt32(V_HoaDon.CurrentRow.Cells[0].Value);
                    this.Hide();
                    new F_Export_Tra().ShowDialog();
                    V_HoaDon.CurrentCell = null;
                    btn_in.Enabled = false;
                }
            }
            else MessageBox.Show("Vui lòng chọn một phiếu trên danh sách hoá đơn thanh toán để in!");
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            if (tb_timkiem.Text == "")
            {
                getviewtra();
                V_HoaDon.CurrentCell = null;
            }
            else
            {
                foreach (RadioButton item in panel1.Controls)
                {
                    if (item.Checked && item.Text == "Số hoá đơn")
                    {
                        string query = "select * from Tra where SoHoaDon like @sohd";
                        GetData.com = new SqlCommand(query, GetData.con);
                        GetData.com.Parameters.Add("@sohd", tb_timkiem.Text + "%");
                        V_HoaDon.DataSource = GetData.getdata(query, false, true);
                    }

                    if (item.Checked && item.Text == "Họ tên khách hàng")
                    {
                        string query = "select SoHoaDon,NgayTra,NgayThue,SoPhieuThue,Tra.MaKH,MaPhong from Tra, KhachHang where Tra.MaKH = KhachHang.MaKH AND KhachHang.HoTen like @hoten";
                        GetData.com = new SqlCommand(query, GetData.con);
                        GetData.com.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = tb_timkiem.Text + "%";
                        V_HoaDon.DataSource = GetData.getdata(query, false, true);
                    }

                    if (item.Checked && item.Text == "Mã phòng")
                    {
                        string query = "select * from tra where MaPhong like @mp";
                        GetData.com = new SqlCommand(query, GetData.con);
                        GetData.com.Parameters.Add("@mp", tb_timkiem.Text + "%");
                        V_HoaDon.DataSource = GetData.getdata(query, false, true);
                    }

                    if (item.Checked && item.Text == "CCCD")
                    {
                        string query = "select SoHoaDon,NgayTra,NgayThue,SoPhieuThue,Tra.MaKH,MaPhong from Tra, KhachHang where Tra.MaKH = KhachHang.MaKH AND KhachHang.CCCD like @cccd";
                        GetData.com = new SqlCommand(query, GetData.con);
                        GetData.com.Parameters.Add("@cccd", tb_timkiem.Text + "%");
                        V_HoaDon.DataSource = GetData.getdata(query, false, true);
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
