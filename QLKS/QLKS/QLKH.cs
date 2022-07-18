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
    public partial class F_QLKH : Form
    {
        public F_QLKH()
        {
            InitializeComponent();
            getdataview();
        }

        private void getdataview()
        {
            string query = "select * from KhachHang";
            F_QLKH_V.DataSource = GetData.getdata(query,false,false);
            F_QLKH_V.Columns[0].HeaderText = "Mã khách hàng";
            F_QLKH_V.Columns[1].HeaderText = "Họ tên";
            F_QLKH_V.Columns[2].HeaderText = "Căn cước công dân";
            F_QLKH_V.Columns[3].HeaderText = "Địa chỉ";
            F_QLKH_V.Columns[4].HeaderText = "Số điện thoại";
            F_QLKH_V.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            F_QLKH_V.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            //MessageBox.Show(GetData.getdata(query).Columns.Count+"");
            
        }

        private void F_QLKH_V_SelectionChanged(object sender, EventArgs e)
        {
            tb_makh.Text = F_QLKH_V.CurrentRow.Cells[0].Value + "";
            tb_ht.Text = F_QLKH_V.CurrentRow.Cells[1].Value + "";
            tb_cccd.Text = F_QLKH_V.CurrentRow.Cells[2].Value + "";
            tb_dc.Text = F_QLKH_V.CurrentRow.Cells[3].Value + "";
            tb_sdt.Text = F_QLKH_V.CurrentRow.Cells[4].Value + "";

        }

        private void F_QLKH_Them_Click(object sender, EventArgs e)
        {
            // test du lieu

            string query = "SELECT CAST(COUNT(1) AS BIT) AS Expr1 FROM KhachHang WHERE CCCD = @cccd AND DIENTHOAI = @sdt";
            GetData.con.Open();
            GetData.com = new SqlCommand(query, GetData.con);
            GetData.com.Parameters.Add("@cccd", tb_cccd.Text);
            GetData.com.Parameters.Add("@sdt", tb_sdt.Text);
            bool ss = GetData.testdata(false);
            if (tb_ht.Text == ""||tb_cccd.Text == ""||tb_dc.Text == ""||tb_sdt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!!!");
            }
            else if (ss)
            {
                MessageBox.Show("CCCD hoặc SDT bị trùng!!!");
            }
            else
            {
                long cccd, sdt;
                if (long.TryParse(tb_cccd.Text,out cccd) || long.TryParse(tb_sdt.Text,out sdt))
                {
                    query = "insert into KhachHang (HoTen,CCCD,DiaChi,DienThoai) values (@ht,@cccd,@dc,@sdt)";
                    GetData.con.Open();
                    GetData.com = new SqlCommand(query, GetData.con);
                    GetData.com.Parameters.Add("@ht", tb_ht.Text);
                    GetData.com.Parameters.Add("@cccd", tb_cccd.Text);
                    GetData.com.Parameters.Add("@dc", tb_dc.Text);
                    GetData.com.Parameters.Add("@sdt", tb_sdt.Text);
                    GetData.putdata();
                    getdataview();
                    F_QLKH_V.CurrentCell = F_QLKH_V.Rows[F_QLKH_V.RowCount - 1].Cells[0];
                    selectAfterDo();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng số cho CCCD hoặc SDT!!");
                }
                
            }
        }

        private void F_QLKH_Load(object sender, EventArgs e)
        {
            //F_QLKH_V.ClearSelection();
            F_QLKH_V.CurrentCell = null;
            tb_makh.Text ="";
            tb_ht.Text="";
            tb_cccd.Text="";
            tb_dc.Text ="";
            tb_sdt.Text ="";
            //MessageBox.Show(F_QLKH_V.CurrentRow.Index + "");
            foreach (DataGridViewColumn item in F_QLKH_V.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
        private void selectAfterDo()
        {
            tb_makh.Text = F_QLKH_V.CurrentRow.Cells[0].Value + "";
            tb_ht.Text = F_QLKH_V.CurrentRow.Cells[1].Value + "";
            tb_cccd.Text = F_QLKH_V.CurrentRow.Cells[2].Value + "";
            tb_dc.Text = F_QLKH_V.CurrentRow.Cells[3].Value + "";
            tb_sdt.Text = F_QLKH_V.CurrentRow.Cells[4].Value + "";
        }

        private void F_QLKH_Sua_Click(object sender, EventArgs e)
        {
            string query = "SELECT CAST(COUNT(1) AS BIT) AS Expr1 FROM KhachHang WHERE CCCD = @cccd AND DIENTHOAI = @sdt AND MaKH != @ma";
            GetData.con.Open();
            GetData.com = new SqlCommand(query, GetData.con);
            GetData.com.Parameters.Add("@cccd", tb_cccd.Text);
            GetData.com.Parameters.Add("@sdt", tb_sdt.Text);
            GetData.com.Parameters.Add("@ma", tb_makh.Text);
            bool ss = GetData.testdata(false);
            if (F_QLKH_V.CurrentCell == null)
            {
                MessageBox.Show("Vui lòng chọn một hàng dưới bảng thông tin để sửa!!");
            }
            else if (tb_ht.Text == "" || tb_cccd.Text == "" || tb_dc.Text == "" || tb_sdt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!!!");
            }
            else if (ss)
            {
                MessageBox.Show("CCCD hoặc SDT bị trùng!!!");
            }
            else
            {
                long cccd, sdt;
                if (long.TryParse(tb_cccd.Text, out cccd) || long.TryParse(tb_sdt.Text, out sdt))
                {
                    query = "update KhachHang set HoTen = @ht, CCCD = @cccd, DiaChi = @dc, DienThoai = @sdt where MaKH = @ma";
                    GetData.con.Open();
                    GetData.com = new SqlCommand(query, GetData.con);
                    GetData.com.Parameters.Add("@ht", tb_ht.Text);
                    GetData.com.Parameters.Add("@cccd", tb_cccd.Text);
                    GetData.com.Parameters.Add("@dc", tb_dc.Text);
                    GetData.com.Parameters.Add("@sdt", tb_sdt.Text);
                    GetData.com.Parameters.Add("@ma", tb_makh.Text);
                    GetData.putdata();
                    int id = F_QLKH_V.CurrentRow.Index;
                    getdataview();
                    F_QLKH_V.CurrentCell = F_QLKH_V.Rows[id].Cells[0];
                    selectAfterDo();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng số cho CCCD hoặc SDT!!");
                }

            }
          
        }

        private void F_QLKH_Xoa_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM KhachHang WHERE MaKH = @ma";
            GetData.con.Open();
            GetData.com = new SqlCommand(query, GetData.con);
            GetData.com.Parameters.Add("@ma", tb_makh.Text);
            if (F_QLKH_V.CurrentCell == null)
            {
                MessageBox.Show("Vui lòng chọn một hàng dưới bảng thông tin để xoá!!");
                GetData.con.Close();
                GetData.com.Dispose();
            }
            else if (GetData.putdata() == 1)
            {
                MessageBox.Show("Xoá Khách hàng thành công!!");
                getdataview();
            }
            //getdataview();
        }

        private void F_QLKH_Thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
