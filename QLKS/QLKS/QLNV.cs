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
    public partial class F_QLNV : Form
    {
        public F_QLNV()
        {
            InitializeComponent();
            getdataview();
        }

        private void getdataview()
        {
            string query = "select * from NhanVien";
            F_QLNV_V.DataSource = GetData.getdata(query, false,false);
            F_QLNV_V.Columns[0].HeaderText = "Mã nhân viên";
            F_QLNV_V.Columns[1].HeaderText = "Họ tên";
            F_QLNV_V.Columns[2].HeaderText = "Căn cước công dân";
            F_QLNV_V.Columns[3].HeaderText = "Số điện thoại";
            F_QLNV_V.Columns[4].HeaderText = "Năm sinh";
            F_QLNV_V.Columns[4].HeaderText = "Giới tính";
            F_QLNV_V.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            F_QLNV_V.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            //MessageBox.Show(GetData.getdata(query).Columns.Count+"");

        }

        private void F_QLNV_Load(object sender, EventArgs e)
        {
            F_QLNV_V.CurrentCell = null;
            tb_ma.Text = "";
            tb_ht.Text = "";
            tb_cccd.Text = "";
            tb_sdt.Text = "";
            tb_ns.Text = "";
            //MessageBox.Show(F_QLKH_V.CurrentRow.Index + "");
            foreach (DataGridViewColumn item in F_QLNV_V.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void F_QLNV_V_SelectionChanged(object sender, EventArgs e)
        {
            tb_ma.Text = F_QLNV_V.CurrentRow.Cells[0].Value + "";
            tb_ht.Text = F_QLNV_V.CurrentRow.Cells[1].Value + "";
            tb_cccd.Text = F_QLNV_V.CurrentRow.Cells[2].Value + "";
            tb_sdt.Text = F_QLNV_V.CurrentRow.Cells[3].Value + "";
            tb_ns.Text = F_QLNV_V.CurrentRow.Cells[4].Value + "";
            if (F_QLNV_V.CurrentRow.Cells[5].Value.ToString() == "Nam")
            {
                rdbtn_nam.Checked = true;
            }
            else
            {
                rdbtn_nu.Checked = true;
            }
        }

        private string gioitinh()
        {
            string a = null;
            foreach (RadioButton item in panel_gioitinh.Controls)
            {
                if (item.Checked)
                {
                    a = item.Text;
                }
            }
            return a;
        }
    
        private void F_QLNV_Them_Click(object sender, EventArgs e)
        {
            string query = "SELECT CAST(COUNT(1) AS BIT) AS Expr1 FROM NhanVien WHERE CCCD = @cccd AND SDT = @sdt";
            GetData.con.Open();
            GetData.com = new SqlCommand(query, GetData.con);
            GetData.com.Parameters.Add("@cccd", tb_cccd.Text);
            GetData.com.Parameters.Add("@sdt", tb_sdt.Text);
            bool ss = GetData.testdata(false);
            if (tb_ht.Text == "" || tb_cccd.Text == "" || tb_ns.Text == "" || tb_sdt.Text == "")
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
                    query = "insert into NhanVien (HoTen,CCCD,SDT,NamSinh,GioiTinh) values (@ht,@cccd,@sdt,@ns,@gt)";
                    GetData.con.Open();
                    GetData.com = new SqlCommand(query, GetData.con);
                    GetData.com.Parameters.Add("@ht", tb_ht.Text);
                    GetData.com.Parameters.Add("@cccd", tb_cccd.Text);
                    GetData.com.Parameters.Add("@sdt", tb_sdt.Text);
                    GetData.com.Parameters.Add("@ns", Convert.ToInt32(tb_ns.Text));
                    GetData.com.Parameters.Add("@gt", gioitinh());
                    GetData.putdata();
                    getdataview();
                    F_QLNV_V.CurrentCell = F_QLNV_V.Rows[F_QLNV_V.RowCount - 1].Cells[0];
                    selectAfterDo();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng số cho CCCD hoặc SDT!!");
                }

            }
        }

        private void selectAfterDo()
        {
            tb_ma.Text = F_QLNV_V.CurrentRow.Cells[0].Value + "";
            tb_ht.Text = F_QLNV_V.CurrentRow.Cells[1].Value + "";
            tb_cccd.Text = F_QLNV_V.CurrentRow.Cells[2].Value + "";
            tb_sdt.Text = F_QLNV_V.CurrentRow.Cells[3].Value + "";
            tb_ns.Text = F_QLNV_V.CurrentRow.Cells[4].Value + "";
            if (F_QLNV_V.CurrentRow.Cells[5].Value.ToString() == "Nam")
            {
                rdbtn_nam.Checked = true;
            }
            else
            {
                rdbtn_nu.Checked = true;
            }
        }

        private void F_QLNV_Sua_Click(object sender, EventArgs e)
        {
            string query = "SELECT CAST(COUNT(1) AS BIT) AS Expr1 FROM NhanVien WHERE CCCD = @cccd AND SDT = @sdt AND MaNV != @ma";
            GetData.con.Open();
            GetData.com = new SqlCommand(query, GetData.con);
            GetData.com.Parameters.Add("@cccd", tb_cccd.Text);
            GetData.com.Parameters.Add("@sdt", tb_sdt.Text);
            GetData.com.Parameters.Add("@ma", tb_ma.Text);
            bool ss = GetData.testdata(false);
            if (F_QLNV_V.CurrentCell == null)
            {
                MessageBox.Show("Vui lòng chọn một hàng dưới bảng thông tin để sửa!!");
            }
            else if (tb_ht.Text == "" || tb_cccd.Text == "" || tb_sdt.Text == "" || tb_ns.Text == "")
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
                    query = "update NhanVien set HoTen = @ht, CCCD = @cccd, SDT = @sdt, NamSinh = @ns, GioiTinh = @gt where MaNV = @ma";
                    GetData.con.Open();
                    GetData.com = new SqlCommand(query, GetData.con);
                    GetData.com.Parameters.Add("@ht", tb_ht.Text);
                    GetData.com.Parameters.Add("@cccd", tb_cccd.Text);
                    GetData.com.Parameters.Add("@sdt", tb_sdt.Text);
                    GetData.com.Parameters.Add("@ns", tb_ns.Text);
                    GetData.com.Parameters.Add("@gt", gioitinh());
                    GetData.com.Parameters.Add("@ma", tb_ma.Text);
                    GetData.putdata();
                    int id = F_QLNV_V.CurrentRow.Index;
                    getdataview();
                    F_QLNV_V.CurrentCell = F_QLNV_V.Rows[id].Cells[0];
                    selectAfterDo();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng số cho CCCD hoặc SDT!!");
                }

            }
        }

        private void F_QLNV_Xoa_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM NhanVien WHERE MaNV = @ma";
            GetData.con.Open();
            GetData.com = new SqlCommand(query, GetData.con);
            GetData.com.Parameters.Add("@ma", tb_ma.Text);
            if (F_QLNV_V.CurrentCell == null)
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
        }

        private void F_QLNV_Thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
