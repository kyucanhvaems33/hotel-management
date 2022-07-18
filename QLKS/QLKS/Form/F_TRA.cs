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
    public partial class F_TRA : Form
    {
        public static int matra;
        //public static PhieuTra ptra;
        private DateTime date;
        private long dongia;
        private int day;
        private bool testtangmatra = false;
        public F_TRA()
        {
            InitializeComponent();
            getdataview();
        }

        private void getdataview()
        {
            getdatathue();
            getdataphong();
            //getdatatra();
        }

        private void getdataphong()
        {
            string query = "SELECT DISTINCT Loai, DonGia FROM Phong";
            //GetData.com = new SqlCommand(query)
            //GetData.com.Parameters.Add("@tt", "BẬN");
            F_TRA_P_V.DataSource = GetData.getdata(query, true, false);
            F_TRA_P_V.Columns[0].HeaderText = "Loại phòng";
            F_TRA_P_V.Columns[1].HeaderText = "Đơn giá";
            F_TRA_P_V.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            F_TRA_P_V.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void getdatathue()
        {
            string query = "select * from Thue where not exists(select * from Tra where Thue.SoPhieuThue = Tra.SoPhieuThue)";
            F_TRA_THUE_V.DataSource = GetData.getdata(query, false, false);
            F_TRA_THUE_V.Columns[0].HeaderText = "Số phiếu thuê";
            F_TRA_THUE_V.Columns[1].HeaderText = "Ngày thuê";
            F_TRA_THUE_V.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            F_TRA_THUE_V.Columns[2].HeaderText = "Mã Phòng";
            F_TRA_THUE_V.Columns[3].HeaderText = "Mã khách hàng";
            //F_THUE_V.DataSource = GetData.getdata(query, false, false);
            F_TRA_THUE_V.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            F_TRA_THUE_V.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tb_ngaytra.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm", new CultureInfo("vi-VN"));
        }

        private void F_TRA_Load(object sender, EventArgs e)
        {

            timer1.Start();

            F_TRA_THUE_V.CurrentCell = null;
            F_TRA_P_V.CurrentCell = null;
            F_TRA_P_V.Enabled = false;

            foreach (DataGridViewColumn item in F_TRA_THUE_V.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            tb_mathue.Text = "";
            tb_makh.Text = "";
            tb_maphong.Text = "";
            tb_dongia.Text = "";
            //tb_ngayo.Text = "";
            tb_ngaythue.Text = "";
            tb_timkiem.Text = "";
            //tb_tongtien.Text = "";
            lb_ngayo.Text = "";
            lb_tongtien.Text = "";


            updatematra();


        }

        private void updatematra()
        {
            string query = "SELECT ( CASE WHEN NOT EXISTS(SELECT NULL FROM DichVu) THEN 1 ELSE (SELECT IDENT_CURRENT('Tra') + 1) END) AS cl1";
            DataTable tb = GetData.getdata(query, false, false);
            tb_matra.Text = tb.Rows[0][0].ToString();
        }
        

        private void F_TRA_THUE_V_SelectionChanged(object sender, EventArgs e)
        {
                tb_mathue.Text = F_TRA_THUE_V.CurrentRow.Cells[0].Value.ToString();
                date = (DateTime)F_TRA_THUE_V.CurrentRow.Cells[1].Value;
                tb_ngaythue.Text = date.ToString("dd/MM/yyyy HH:mm", new CultureInfo("vi-VN"));
                tb_maphong.Text = F_TRA_THUE_V.CurrentRow.Cells[2].Value.ToString();
                tb_makh.Text = F_TRA_THUE_V.CurrentRow.Cells[3].Value.ToString();

                DataTable tb;
                string query = "select DonGia from Phong where MaPhong like '" + F_TRA_THUE_V.CurrentRow.Cells[2].Value.ToString() + "%'";
                tb = GetData.getdata(query, false, false);
                dongia = Convert.ToInt64(tb.Rows[0][0]);
                tb_dongia.Text = string.Format("{0:#,##0}", double.Parse(dongia.ToString()));
                //Convert.ToInt32(tb.Rows[0][0]).ToString();
                //updatematra();
                day = (DateTime.Now - date).Days;
                if (day == 0)
                {
                    //tb_ngayo.Text = 1 +"";
                    lb_ngayo.Text = 1 + "";
                    //lb_ngayo.Visible = true;
                    day = 1;
                }
                else
                {
                    //tb_ngayo.Text = day.ToString();
                    lb_ngayo.Text = day.ToString();
                    // lb_ngayo.Visible = true;
                }
                if (lb_ngayo.Text != "")
                {
                    lb_tongtien.Text = string.Format("{0:#,##0}", double.Parse((dongia * day).ToString()));
                }
            
            if (testtangmatra)
	        {
                updatematra();
                testtangmatra = false;
            }        
        }

        private void updatephong()
        {
            string query = "update Phong set TrangThai = @tt where MaPhong = @ma";
            GetData.con.Open();
            GetData.com = new SqlCommand(query, GetData.con);
            GetData.com.Parameters.Add("@tt", "RẢNH");
            GetData.com.Parameters.Add("@ma", tb_maphong.Text);
            GetData.putdata();
        }

        private void GiuThongTinSauTra(Tra tra)
        {
            tb_mathue.Text = tra.sophieuthue + "";
            tb_makh.Text = tra.makh + "";
            tb_maphong.Text = tra.maphong;
            tb_dongia.Text = tra.dongia + "";
            lb_tongtien.Text = string.Format("{0:#,##0}", double.Parse(tra.tongtien.ToString()));
            tb_ngaythue.Text = tra.ngaythue.ToString("dd/MM/yyyy HH:mm", new CultureInfo("vi-VN"));
            lb_ngayo.Text = tra.ngayo.ToString();
            tb_matra.Text = tra.matra.ToString();
            tb_ngaytra.Text = tra.ngaytra.ToString("dd/MM/yyyy HH:mm", new CultureInfo("vi-VN"));
            timer1.Stop();
        }

        private void btn_tra_Click(object sender, EventArgs e)
        {
            if (F_TRA_THUE_V.CurrentCell == null)
            {
                MessageBox.Show("Vui lòng chọn thông tin trong bảng danh sách phiếu thuê!!!");
            }
            else
            {
                string query = "insert into Tra (Ngaytra,NgayThue,SoPhieuThue,MaKH,MaPhong) values (@ngaytra,@ngaythue,@sophieuthue,@makh,@MaPhong)";
                GetData.con.Open();
                GetData.com = new SqlCommand(query, GetData.con);
                GetData.com.Parameters.Add("@ngaytra", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss", new CultureInfo("vi-VN")));
                GetData.com.Parameters.Add("@ngaythue", date.ToString("yyyy-MM-dd HH:mm:ss", new CultureInfo("vi-VN")));
                GetData.com.Parameters.Add("@SoPhieuThue", Convert.ToInt32(tb_mathue.Text));
                GetData.com.Parameters.Add("@makh", Convert.ToInt32(tb_makh.Text));
                GetData.com.Parameters.Add("@maphong", tb_maphong.Text);      
                GetData.putdata();
                updatephong();
                Tra tra = new Tra(Convert.ToInt32(tb_mathue.Text), Convert.ToInt32(tb_makh.Text), tb_maphong.Text,dongia, dongia * day, date,DateTime.Now, Convert.ToInt32(tb_matra.Text),day);
                matra = tra.matra;
                F_TRA_THUE_V.CurrentCell = null;                
                getdatathue();
                GiuThongTinSauTra(tra);
                testtangmatra = true;
                DialogResult a = MessageBox.Show(null, "Trả phòng thành công. Bạn có muốn in hoá đơn thanh toán không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (a == DialogResult.Yes)
                {
                    this.Hide();
                    new F_Export_Tra().ShowDialog();
                    this.Show();
                }
            }
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            if (tb_timkiem.Text == "")
            {
                getdatathue();
                F_TRA_THUE_V.CurrentCell = null;
                cleardata();
            }
            else if (rdbtn_mathue.Checked)
            {
                try
                {
                    string query = "select * from Thue where not exists(select * from Tra where Thue.SoPhieuThue = Tra.SoPhieuThue) AND SoPhieuThue = @mathue";
                    GetData.com = new SqlCommand(query, GetData.con);
                    GetData.com.Parameters.Add("@mathue", Convert.ToInt32(tb_timkiem.Text));
                    F_TRA_THUE_V.DataSource = GetData.getdata(query, false, true);
                    F_TRA_THUE_V.CurrentCell = null;
                    cleardata();
                }catch (Exception)
                {
                    MessageBox.Show("Vui lòng nhập định dạng số khi tìm kiếm theo số phiếu thuê");
                    tb_timkiem.Text = "";
                }
                
            }
            else if (rdbtn_maphong.Checked)
            {
                string query = "select * from Thue where not exists(select * from Tra where Thue.SoPhieuThue = Tra.SoPhieuThue) AND MaPhong like @maphong";
                GetData.com = new SqlCommand(query, GetData.con);
                GetData.com.Parameters.Add("@maphong",tb_timkiem.Text.ToString()+"%");
                F_TRA_THUE_V.DataSource = GetData.getdata(query, false, true);
                F_TRA_THUE_V.CurrentCell = null;
                cleardata();
            }
        }

        private void cleardata()
        {
            tb_mathue.Text = "";
            tb_makh.Text = "";
            tb_maphong.Text = "";
            tb_dongia.Text = "";
            tb_ngaythue.Text = "";
            lb_ngayo.Text = "";
            lb_tongtien.Text = "";
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
