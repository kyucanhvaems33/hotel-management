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
    public partial class F_HoaDonSDDV : Form
    {
        public static int sohoadon;
        public F_HoaDonSDDV()
        {
            InitializeComponent();
            getviewsddv();
        }

        private void getviewsddv()
        {
            string query = "select * from SDDV";
            V_SDDV.DataSource = GetData.getdata(query, false, false);
            V_SDDV.Columns[0].HeaderText = "Số phiếu dịch vụ";
            V_SDDV.Columns[1].HeaderText = "Giờ cung cấp";
            V_SDDV.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            V_SDDV.Columns[2].HeaderText = "Mã khách hàng";
            V_SDDV.Columns[3].HeaderText = "Số phiếu thuê";
            //F_THUE_V.DataSource = GetData.getdata(query, false, false);
            V_SDDV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            V_SDDV.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void F_HoaDonSDDV_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn item in V_SDDV.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            tb_timkiem.Text = "";
            V_SDDV.CurrentCell = null;
        }

        private void V_SDDV_SelectionChanged(object sender, EventArgs e)
        {
            btn_in.Enabled = true;
        }

        private void btn_in_Click(object sender, EventArgs e)
        {
            if (V_SDDV.CurrentCell != null)
            {
                DialogResult a = MessageBox.Show(null, "Bạn có muốn in hoá đơn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (a == DialogResult.Yes)
                {
                    F_SDDV.sophieusddv = Convert.ToInt32(V_SDDV.CurrentRow.Cells[0].Value);
                    this.Hide();
                    new F_Export_SDDV().ShowDialog();
                    V_SDDV.CurrentCell = null;
                    btn_in.Enabled = false;
                }
            }
            else MessageBox.Show("Vui lòng chọn một phiếu trên danh sách hoá đơn sử dụng dịch vụ để in!");
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            if (tb_timkiem.Text == "")
            {
                getviewsddv();
                V_SDDV.CurrentCell = null;
            }
            else
            {
                foreach (RadioButton item in panel1.Controls)
                {
                    if (item.Checked && item.Text == "Số hoá đơn")
                    {
                        string query = "select * from SDDV where SoPhieuDV like @sohd";
                        GetData.com = new SqlCommand(query, GetData.con);
                        GetData.com.Parameters.Add("@sohd", tb_timkiem.Text + "%");
                        V_SDDV.DataSource = GetData.getdata(query, false, true);
                    }

                    if (item.Checked && item.Text == "Họ tên khách hàng")
                    {
                        string query = "select SoPhieuDV,GioCungCap,SDDV.MaKH,SoPhieuThue from SDDV, KhachHang where SDDV.MaKH = KhachHang.MaKH AND KhachHang.HoTen like @hoten";
                        GetData.com = new SqlCommand(query, GetData.con);
                        GetData.com.Parameters.Add("@hoten", SqlDbType.NVarChar).Value = tb_timkiem.Text + "%";
                        V_SDDV.DataSource = GetData.getdata(query, false, true);
                    }

                    if (item.Checked && item.Text == "CCCD")
                    {
                        string query = "select SoPhieuDV,GioCungCap,SDDV.MaKH,SoPhieuThue from SDDV, KhachHang where SDDV.MaKH = KhachHang.MaKH AND KhachHang.CCCD like @cccd";
                        GetData.com = new SqlCommand(query, GetData.con);
                        GetData.com.Parameters.Add("@cccd", tb_timkiem.Text + "%");
                        V_SDDV.DataSource = GetData.getdata(query, false, true);
                    }
                }
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void V_SDDV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            sohoadon = (int) V_SDDV.CurrentRow.Cells[0].Value;
            this.Hide();
            new F_ChiTietHoaDon().ShowDialog();
            this.Show();
        }
    }
}
