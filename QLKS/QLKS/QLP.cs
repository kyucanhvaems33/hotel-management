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
    public partial class F_QLP : Form
    {
        static private string note;
        public F_QLP()
        {
            InitializeComponent();
            getdataview();
        }

        private void getdataview()
        {
            string query = "select * from Phong";
            F_QLP_V.DataSource = GetData.getdata(query,true,false);
            F_QLP_V.Columns[0].HeaderText = "Mã phòng";
            F_QLP_V.Columns[1].HeaderText = "Loại phòng";
            F_QLP_V.Columns[2].HeaderText = "Đơn giá";
            F_QLP_V.Columns[3].HeaderText = "Trạng thái";
            //F_QLP_V.column
            F_QLP_V.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            F_QLP_V.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            //MessageBox.Show(GetData.getdata(query).Columns.Count+"");

        }

        private void F_QLP_Load(object sender, EventArgs e)
        {
            F_QLP_V.CurrentCell = null;
            tb_ma.Text = "";
            tb_gia.Text = "";
            cb_loai.SelectedItem = null;
            cb_tinhtrang.SelectedItem = null;
            //F_QLP_V.CurrentCell = null;
            foreach (DataGridViewColumn item in F_QLP_V.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

        }

        private void F_QLP_V_SelectionChanged(object sender, EventArgs e)
        {
            //CultureInfo culture = new CultureInfo("vi-VN");
            tb_ma.Text = F_QLP_V.CurrentRow.Cells[0].Value.ToString();
            note = F_QLP_V.CurrentRow.Cells[0].Value.ToString();
            //string gia1 = F_QLP_V.CurrentRow.Cells[2].Value;
            decimal gia = Convert.ToDecimal(F_QLP_V.CurrentRow.Cells[2].Value);
            tb_gia.Text = gia.ToString();
            RefreshData();
        }

        private void RefreshData()
        {
            string loai1 = "thường đơn", loai2 = "thường đôi", loai3 = "vip đơn", loai4 = "vip đôi";
            string tt1 = "rảnh", tt2 = "bận";
            if (F_QLP_V.CurrentRow.Cells[1].Value.ToString().ToLower() == loai1)
            {
                cb_loai.SelectedIndex = 0;
            }
            else if (F_QLP_V.CurrentRow.Cells[1].Value.ToString().ToLower() == loai2)
            {
                cb_loai.SelectedIndex = 1;
            }
            else if (F_QLP_V.CurrentRow.Cells[1].Value.ToString().ToLower() == loai3)
            {
                cb_loai.SelectedIndex = 2;
            }
            else if (F_QLP_V.CurrentRow.Cells[1].Value.ToString().ToLower() == loai4)
            {
                cb_loai.SelectedIndex = 3;
            }

            if (F_QLP_V.CurrentRow.Cells[3].Value.ToString().ToLower() == tt1)
            {
                cb_tinhtrang.SelectedIndex = 0;
            }
            else if (F_QLP_V.CurrentRow.Cells[3].Value.ToString().ToLower() == tt2)
            {
                cb_tinhtrang.SelectedIndex = 1;
            }
        }

        private void F_QLP_Them_Click(object sender, EventArgs e)
        {
            string query = "SELECT CAST(COUNT(1) AS BIT) AS Expr1 FROM Phong WHERE MaPhong = @ma";
            GetData.con.Open();
            GetData.com = new SqlCommand(query, GetData.con);
            GetData.com.Parameters.Add("@ma", tb_ma.Text);
            bool ss = GetData.testdata(false);
            if (tb_ma.Text == ""||tb_gia.Text == ""|| cb_loai.SelectedItem == null || cb_tinhtrang.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!!!");
            }
            else if (ss)
            {
                MessageBox.Show("Đã tồn tại phòng trong CSDL!!");
            }
            else
            {
                decimal gia;
                if (decimal.TryParse(tb_gia.Text, out gia))
                {
                    query = "insert into Phong (MaPhong,Loai,DonGia,TrangThai) values (@ma,@loai,@gia,@tt)";
                    GetData.con.Open();
                    GetData.com = new SqlCommand(query, GetData.con);
                    GetData.com.Parameters.Add("@ma", tb_ma.Text);
                    GetData.com.Parameters.Add("@loai", cb_loai.SelectedItem.ToString());
                    GetData.com.Parameters.Add("@gia", gia);
                    GetData.com.Parameters.Add("@tt", cb_tinhtrang.SelectedItem.ToString());
                    GetData.putdata();
                    getdataview();
                    F_QLP_V.CurrentCell = F_QLP_V.Rows[F_QLP_V.RowCount - 1].Cells[0];
                    selectAfterDo();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng số cho đơn giá phòng!!");
                }
            }
        }

        private void selectAfterDo()
        {
            tb_ma.Text = F_QLP_V.CurrentRow.Cells[0].Value.ToString();
            int gia = Convert.ToInt32(F_QLP_V.CurrentRow.Cells[2].Value);
            note = F_QLP_V.CurrentRow.Cells[0].Value.ToString();
            tb_gia.Text = gia.ToString();
            RefreshData();
        }

        private void F_QLP_Sua_Click(object sender, EventArgs e)
        {
            if (F_QLP_V.CurrentCell == null)
            {
                MessageBox.Show("Vui lòng chọn một hàng dưới bảng thông tin để sửa!!");
            }
            else if (tb_gia.Text == "" || cb_loai.SelectedItem == null || cb_tinhtrang.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!!!");
            }
            else
            {
                decimal gia;
                if (decimal.TryParse(tb_gia.Text, out gia))
                {
                    string query = "update Phong set Loai = @loai, DonGia = @gia, TrangThai = @tt where MaPhong = @ma";
                    GetData.con.Open();
                    GetData.com = new SqlCommand(query, GetData.con);
                    GetData.com.Parameters.Add("@ma", note);
                    GetData.com.Parameters.Add("@loai", cb_loai.SelectedItem.ToString());
                    GetData.com.Parameters.Add("@gia", gia);
                    GetData.com.Parameters.Add("@tt", cb_tinhtrang.SelectedItem.ToString());
                    GetData.putdata();
                    int id = F_QLP_V.CurrentRow.Index;
                    getdataview();
                    F_QLP_V.CurrentCell = F_QLP_V.Rows[id].Cells[0];
                    selectAfterDo();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng số cho đơn giá phòng!!");
                }
            }
        }

        private void F_QLP_Xoa_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Phong WHERE MaPhong = @ma";
            GetData.con.Open();
            GetData.com = new SqlCommand(query, GetData.con);
            GetData.com.Parameters.Add("@ma", note);
            if (F_QLP_V.CurrentCell ==null)
            {
                MessageBox.Show("Vui lòng chọn một hàng dưới bảng thông tin để xoá!!");
                GetData.con.Close();
                GetData.com.Dispose();
            }
            else if (GetData.putdata() == 1)
            {
                MessageBox.Show("Xoá phòng thành công!!");
                getdataview();
            }
        }

        private void F_QLP_Thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
