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
        private int count = 0;
        // 1 la them - 2 la sua
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
            F_QLKH_Sua.Enabled = true;
            F_QLKH_Xoa.Enabled = true;
        }

        private void F_QLKH_Them_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                F_QLKH_Thoat.Text = "Huỷ";
                cleardata();
                tb_cccd.Enabled = true;
                tb_dc.Enabled = true;
                tb_ht.Enabled = true;
                tb_sdt.Enabled = true;
                F_QLKH_Sua.Enabled = false;
                F_QLKH_Xoa.Enabled = false;
                if (F_QLKH_V.RowCount == 0)
                {
                    tb_makh.Text = 1 + "";
                }
                else tb_makh.Text = Convert.ToInt32(F_QLKH_V.Rows[F_QLKH_V.RowCount - 1].Cells[0].Value) + 1 + "";
                count = 1;
            }
            else if(count == 1)
            {
                string query = "SELECT CAST(COUNT(1) AS BIT) AS Expr1 FROM KhachHang WHERE CCCD = @cccd OR DIENTHOAI = @sdt";
                GetData.con.Open();
                GetData.com = new SqlCommand(query, GetData.con);
                GetData.com.Parameters.Add("@cccd", tb_cccd.Text);
                GetData.com.Parameters.Add("@sdt", tb_sdt.Text);
                bool ss = GetData.testdata(false);
                if (tb_ht.Text == "" || tb_cccd.Text == "" || tb_dc.Text == "" || tb_sdt.Text == "")
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
                        query = "insert into KhachHang (HoTen,CCCD,DiaChi,DienThoai) values (@ht,@cccd,@dc,@sdt)";
                        GetData.con.Open();
                        GetData.com = new SqlCommand(query, GetData.con);
                        GetData.com.Parameters.Add("@ht", tb_ht.Text);
                        GetData.com.Parameters.Add("@cccd", tb_cccd.Text);
                        GetData.com.Parameters.Add("@dc", tb_dc.Text);
                        GetData.com.Parameters.Add("@sdt", tb_sdt.Text);
                        GetData.putdata();
                        MessageBox.Show("Thêm Khách hàng thành công!!", "Thông báo");
                        getdataview();
                        F_QLKH_V.CurrentCell = F_QLKH_V.Rows[F_QLKH_V.RowCount - 1].Cells[0];
                        selectAfterDo();
                        count=0;
                        F_QLKH_Thoat.Text = "Thoát";
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập đúng định dạng số cho CCCD hoặc SDT!!");
                    }

                }
            }
        }

        private void F_QLKH_Load(object sender, EventArgs e)
        {
            //this.Focus();
            //F_QLKH_V.ClearSelection();
            F_QLKH_V.CurrentCell = null;
            tb_makh.Text ="";
            cleardata();
            //MessageBox.Show(F_QLKH_V.CurrentRow.Index + "");
            foreach (DataGridViewColumn item in F_QLKH_V.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            F_QLKH_Sua.Enabled = false;
            F_QLKH_Xoa.Enabled = false;
        }
        private void selectAfterDo()
        {
            if (F_QLKH_V.CurrentCell == null)
            {
                cleardata();
            }
            else
            {
                tb_makh.Text = F_QLKH_V.CurrentRow.Cells[0].Value + "";
                tb_ht.Text = F_QLKH_V.CurrentRow.Cells[1].Value + "";
                tb_cccd.Text = F_QLKH_V.CurrentRow.Cells[2].Value + "";
                tb_dc.Text = F_QLKH_V.CurrentRow.Cells[3].Value + "";
                tb_sdt.Text = F_QLKH_V.CurrentRow.Cells[4].Value + "";
                tb_cccd.Enabled = false;
                tb_dc.Enabled = false;
                tb_ht.Enabled = false;
                tb_sdt.Enabled = false;
            }
        }

        private void F_QLKH_Sua_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                F_QLKH_Thoat.Text = "Huỷ";
                //cleardata();
                tb_cccd.Enabled = true;
                tb_dc.Enabled = true;
                tb_ht.Enabled = true;
                tb_sdt.Enabled = true;
                F_QLKH_Xoa.Enabled = false;
                F_QLKH_Them.Enabled = false;
                //tb_makh.Text = Convert.ToInt32(F_QLKH_V.Rows[F_QLKH_V.RowCount - 1].Cells[0].Value) + 1 + "";
                count=2;
            }
            else
            {
                string query = "SELECT CAST(COUNT(1) AS BIT) AS Expr1 FROM KhachHang WHERE CCCD = @cccd AND MaKH != @ma OR DIENTHOAI = @sdt AND MaKH != @ma";
                GetData.con.Open();
                GetData.com = new SqlCommand(query, GetData.con);
                GetData.com.Parameters.Add("@cccd", tb_cccd.Text);
                GetData.com.Parameters.Add("@sdt", tb_sdt.Text);
                GetData.com.Parameters.Add("@ma", tb_makh.Text);
                bool ss = GetData.testdata(false);
                //if (F_QLKH_V.CurrentCell == null)
                //{
                //    MessageBox.Show("Vui lòng chọn một hàng dưới bảng thông tin để sửa!!");
                //}
                //else 
                if (tb_ht.Text == "" || tb_cccd.Text == "" || tb_dc.Text == "" || tb_sdt.Text == "")
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
                        MessageBox.Show("Sửa Khách hàng thành công!!", "Thông báo");
                        F_QLKH_Thoat.Text = "Thoát";
                        int id = F_QLKH_V.CurrentRow.Index;
                        getdataview();
                        F_QLKH_V.CurrentCell = F_QLKH_V.Rows[id].Cells[0];
                        count = 0;
                        F_QLKH_Them.Enabled = true;
                        selectAfterDo();
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập đúng định dạng số cho CCCD hoặc SDT!!");
                    }

                }
            }
          
        }

        private void F_QLKH_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xoá khách hàng đã chọn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM KhachHang WHERE MaKH = @ma";
                GetData.con.Open();
                GetData.com = new SqlCommand(query, GetData.con);
                GetData.com.Parameters.Add("@ma", F_QLKH_V.CurrentRow.Cells[0].Value);
                if (GetData.putdata() == 1)
                {
                    MessageBox.Show("Xoá Khách hàng thành công!!", "Thông báo");
                    getdataview();
                    F_QLKH_V.CurrentCell = null;
                    F_QLKH_Sua.Enabled = false;
                    F_QLKH_Xoa.Enabled = false;
                    tb_makh.Text = "";
                    cleardata();
                }
            }
        }

        private void cleardata()
        {
            tb_ht.Text = "";
            tb_cccd.Text = "";
            tb_dc.Text = "";
            tb_sdt.Text = "";
        }

        private void F_QLKH_Thoat_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                F_QLKH_V.CurrentCell = null;
                tb_cccd.Enabled = false;
                tb_dc.Enabled = false;
                tb_ht.Enabled = false;
                tb_sdt.Enabled = false;
                F_QLKH_Sua.Enabled = false;
                F_QLKH_Xoa.Enabled = false;
                //F_QLKH_V.CurrentCell = null;
                count=0;
                F_QLKH_Thoat.Text = "Thoát";
                tb_makh.Text = "";
                selectAfterDo();
            }
            else if (count == 2)
            {
                tb_cccd.Enabled = false;
                tb_dc.Enabled = false;
                tb_ht.Enabled = false;
                tb_sdt.Enabled = false;
                //F_QLKH_Sua.Enabled = true;
                F_QLKH_Xoa.Enabled = true;
                F_QLKH_Them.Enabled = true;
                count = 0;
                F_QLKH_Thoat.Text = "Thoát";
                selectAfterDo();
            }
            else this.Dispose();
        }
    }
}
