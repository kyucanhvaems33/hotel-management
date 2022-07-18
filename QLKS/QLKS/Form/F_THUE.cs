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
    public partial class F_THUE : Form
    {
        //public static PhieuThue pt;
        public static int sophieu; 
        private DateTime now = DateTime.Now;
        private string notemaphong,notegia,notemakh;
        private static bool testtangmathue = false;
        public F_THUE()
        {
            InitializeComponent();
            getdataview();
        }

        private void getdataview()
        {
            getdataviewkhachhang();
            getdataviewphong();
        }

        private void getdataviewkhachhang()
        {
            string query = "select * from KhachHang";
            F_THUE_KH_V.DataSource = GetData.getdata(query, false, false);
            F_THUE_KH_V.Columns[0].HeaderText = "Mã khách hàng";
            F_THUE_KH_V.Columns[1].HeaderText = "Họ tên";
            F_THUE_KH_V.Columns[2].HeaderText = "Căn cước công dân";
            F_THUE_KH_V.Columns[3].HeaderText = "Địa chỉ";
            F_THUE_KH_V.Columns[4].HeaderText = "Số điện thoại";
            F_THUE_KH_V.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            F_THUE_KH_V.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }


        private void getdataviewphong()
        {
            string query = "select * from Phong where TrangThai = @trangthai";
            GetData.com = new SqlCommand(query, GetData.con);
            GetData.com.Parameters.Add("@trangthai", "RẢNH");
            F_THUE_P_V.DataSource = GetData.getdata(query, true, true);
            F_THUE_P_V.Columns[0].HeaderText = "Mã phòng";
            F_THUE_P_V.Columns[1].HeaderText = "Loại phòng";
            F_THUE_P_V.Columns[2].HeaderText = "Đơn giá";
            F_THUE_P_V.Columns[3].HeaderText = "Trạng thái";
            F_THUE_P_V.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            F_THUE_P_V.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void F_THUE_Load(object sender, EventArgs e)
        {
            F_THUE_KH_V.CurrentCell = null;
            F_THUE_P_V.CurrentCell = null;

            foreach (DataGridViewColumn item in F_THUE_KH_V.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            foreach (DataGridViewColumn item in F_THUE_P_V.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            tb_gia.Text = "";
            tb_makh.Text = "";
            tb_maphong.Text = "";
            tb_mathue.Text = "";
            tb_ngay.Text = "";
           
            updatemathue();

            timer1.Start();

        }

        private void updatemathue()
        {
            string query = "SELECT ( CASE WHEN NOT EXISTS(SELECT NULL FROM DichVu) THEN 1 ELSE (SELECT IDENT_CURRENT('Thue') + 1) END) AS cl1";
            DataTable tb = GetData.getdata(query, false, false);
            tb_mathue.Text = tb.Rows[0][0].ToString();
        }


        private void tb_tenkh_TextChanged(object sender, EventArgs e)
        {
            if (tb_tenkh.Text == "")
            {
                getdataviewkhachhang();
                //F_THUE_KH_V.CurrentCell = null;
            }
            else
            {
                string query = "select * from KhachHang where HoTen like @ten";
                GetData.com = new SqlCommand(query, GetData.con);
                GetData.com.Parameters.Add("@ten", SqlDbType.NVarChar).Value = tb_tenkh.Text + "%";
                F_THUE_KH_V.DataSource = GetData.getdata(query, false, true);
            }
        }

        private void tb_loaiphong_TextChanged(object sender, EventArgs e)
        {
            if (tb_loaiphong.Text == "")
            {
                getdataviewphong();
               // F_THUE_P_V.CurrentCell = null;
            }
            else
            {
                string query = "select * from Phong where Loai like @loai";
                GetData.com = new SqlCommand(query, GetData.con);
                GetData.com.Parameters.Add("@loai", SqlDbType.NVarChar).Value = tb_loaiphong.Text + "%";
                F_THUE_P_V.DataSource = GetData.getdata(query, true, true);
            }
        }

        private void F_THUE_KH_V_SelectionChanged(object sender, EventArgs e)
        {
            tb_makh.Text = F_THUE_KH_V.CurrentRow.Cells[0].Value.ToString();
            if (testtangmathue)
            {
                tb_maphong.Text = "";
                tb_gia.Text = "";
                updatemathue();
                testtangmathue = false;
                timer1.Start();
            }
        }

        private void F_THUE_P_V_SelectionChanged(object sender, EventArgs e)
        {
            tb_maphong.Text = F_THUE_P_V.CurrentRow.Cells[0].Value.ToString();
            //decimal gia = Convert.ToDecimal(F_THUE_P_V.CurrentRow.Cells[2].Value);
            tb_gia.Text = Convert.ToInt64(F_THUE_P_V.CurrentRow.Cells[2].Value).ToString();
            if (testtangmathue)
            {
                tb_makh.Text = "";
                updatemathue();
                testtangmathue = false;
                timer1.Start();
            }

        }

        private void btn_thue_Click(object sender, EventArgs e)
        {
            if (F_THUE_KH_V.CurrentCell == null || F_THUE_P_V.CurrentCell == null)
            {
                MessageBox.Show("Vui lòng chọn thông tin trên hai bảng thông tin khách hàng và thông tin phòng!!!");
            }
            else
            {
                string query = "if ((select COUNT(MaKH) from Thue where MaKH = @makh) != (select COUNT(MaKH) from Tra where MaKH = @makh)) SELECT CAST(1 AS BIT) AS Expr1; else SELECT CAST(0 AS BIT) AS Expr1; ";
                GetData.con.Open();
                GetData.com = new SqlCommand(query, GetData.con);
                GetData.com.Parameters.Add("@makh", F_THUE_KH_V.CurrentRow.Cells[0].Value.ToString());
                if (GetData.testdata(false))
                {
                    MessageBox.Show("Khách hàng được chọn đang thuê phòng\nVui lòng trả phòng để tiếp tục thuê phòng!!!");
                }
                else
                {
                    query = "insert into Thue (NgayThue,MaPhong,MaKH) values (@ngay,@maphong,@makh)";
                    GetData.con.Open();
                    GetData.com = new SqlCommand(query, GetData.con);
                    GetData.com.Parameters.Add("@ngay", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", new CultureInfo("vi-VN")));
                    GetData.com.Parameters.Add("@maphong", tb_maphong.Text);
                    GetData.com.Parameters.Add("@makh", Convert.ToInt32(tb_makh.Text));
                    GetData.putdata();
                    sophieu = Convert.ToInt32(tb_mathue.Text);
                    notemaphong = tb_maphong.Text;
                    notegia = tb_gia.Text;
                    notemakh = tb_makh.Text;
                    //getdatareport();                  
                    //tb_mathue.Text = Convert.ToInt32(F_THUE_V.Rows[F_THUE_V.RowCount - 1].Cells[0].Value) + 1 + "";
                    //testtangmathue = true;     
                    cleardata();
                    tb_maphong.Text = notemaphong;
                    tb_gia.Text = notegia;
                    tb_makh.Text = notemakh;
                    testtangmathue = true;
                    timer1.Stop();
                    //selectAfterDo();
                    DialogResult a = MessageBox.Show(null, "Thêm phiếu thuê thành công. Bạn có muốn in hoặc xuất phiếu thuê không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (a == DialogResult.Yes)
                    {
                        this.Hide();
                        new F_Export_Thue().ShowDialog();
                        this.Show();
                    }
                    updatephong();
                    getdataviewphong();
                }
            }
            
        }

        private void cleardata()
        {
            //if (testtangmathue)
            //{
            //    tb_maphong.Text = "";
            //    tb_makh.Text = "";
            //    tb_gia.Text = "";
            //    testtangmathue = false;
            //}
            //else
            //{
                F_THUE_KH_V.CurrentCell = null;
                F_THUE_P_V.CurrentCell = null;
            //}
        }

        private void updatephong()
        {
            string query = "update Phong set TrangThai = @tt where MaPhong = @ma";
            GetData.con.Open();
            GetData.com = new SqlCommand(query, GetData.con);
            GetData.com.Parameters.Add("@tt", "BẬN");
            GetData.com.Parameters.Add("@ma", tb_maphong.Text);
            GetData.putdata();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tb_ngay.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm", new CultureInfo("vi-VN"));
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            this.Hide();
            new F_QLKH().ShowDialog();
            this.Show();
            getdataviewkhachhang();
        }

        //private void selectAfterDo()
        //{
        //    tb_mathue.Text = F_THUE_V.CurrentRow.Cells[0].Value.ToString();
        //    tb_gia.Text = notegia;
        //    tb_maphong.Text = notemaphong;
        //}
    
    }
}
