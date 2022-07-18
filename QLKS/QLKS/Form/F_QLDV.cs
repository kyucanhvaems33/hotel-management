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
    public partial class F_QLDV : Form
    {
        private int count = 0;
        // 1 la them - 2 la sua
        public F_QLDV()
        {
            InitializeComponent();
            getdataview();
        }

        private void getdataview()
        {
            string query = "select * from DichVu";
            F_QLDV_V.DataSource = GetData.getdata(query, false,false);
            F_QLDV_V.Columns[0].HeaderText = "Mã dịch vụ";
            F_QLDV_V.Columns[1].HeaderText = "Tên dịch vụ";
            F_QLDV_V.Columns[2].HeaderText = "Đơn giá";
            F_QLDV_V.Columns[3].HeaderText = "Mã nhân viên";
            F_QLDV_V.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            F_QLDV_V.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            //MessageBox.Show(GetData.getdata(query).Columns.Count+"");

        }
        private void cleardata()
        {
            tb_ten.Text = "";
            tb_manv.Text = "";
            tb_gia.Text = "";
        }
        private void F_QLDV_Load(object sender, EventArgs e)
        {
            F_QLDV_V.CurrentCell = null;
            tb_ma.Text = "";
            cleardata();
            //F_QLDV_V.ClearSelection();
            foreach (DataGridViewColumn item in F_QLDV_V.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            F_QLDV_Xoa.Enabled = false;
            F_QLDV_Sua.Enabled = false;
        }


        private void F_QLDV_V_SelectionChanged(object sender, EventArgs e)
        {
            tb_ma.Text = F_QLDV_V.CurrentRow.Cells[0].Value + "";
            tb_ten.Text = F_QLDV_V.CurrentRow.Cells[1].Value + "";
            long gia = Convert.ToInt64(F_QLDV_V.CurrentRow.Cells[2].Value);
            tb_gia.Text = gia.ToString();
            tb_manv.Text = F_LogIn.TK.MaNV.ToString();
            F_QLDV_Sua.Enabled = true;
            F_QLDV_Xoa.Enabled = true;
        }



        private void F_QLDV_Them_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                F_QLDV_Thoat.Text = "Huỷ";
                cleardata();
                tb_gia.Enabled = true;
                F_QLDV_V.Enabled = false;
                tb_ten.Enabled = true;
                F_QLDV_Sua.Enabled = false;
                F_QLDV_Xoa.Enabled = false;
                updatemadv();
                count = 1;
                string query = "select HoTen from NhanVien where MaNV = @manv";
                GetData.com = new SqlCommand(query, GetData.con);
                GetData.com.Parameters.Add("@manv", F_LogIn.TK.MaNV);
                DataTable tb = GetData.getdata(query, true, true);
                tb_manv.Text = tb.Rows[0][0].ToString();
            }
            else if (count == 1)
            {
                string query = "SELECT CAST(COUNT(1) AS BIT) AS Expr1 FROM DichVu WHERE TenDV = @ten";
                GetData.con.Open();
                GetData.com = new SqlCommand(query, GetData.con);
                GetData.com.Parameters.Add("@ten", tb_ten.Text);
                bool ss = GetData.testdata(false);
                if (tb_ten.Text == "" || tb_gia.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!!!");
                }
                else if (ss)
                {
                    MessageBox.Show("Đã có dịch vụ " + tb_ten.Text + " !!");
                }
                else
                {
                    decimal gia;
                    //bool check = int.TryParse(tb_ton.Text, out ton);
                    if (decimal.TryParse(tb_gia.Text, out gia))
                    {
                        query = "insert into DichVu (TenDV,DonGia) values (@ten,@gia)";
                        GetData.con.Open();
                        GetData.com = new SqlCommand(query, GetData.con);
                        GetData.com.Parameters.Add("@ten", tb_ten.Text.ToLower());
                        GetData.com.Parameters.Add("@gia", gia);
                        GetData.putdata();
                        MessageBox.Show("Thêm dịch vụ thành công!!", "Thông báo");
                        getdataview();
                        F_QLDV_V.CurrentCell = F_QLDV_V.Rows[F_QLDV_V.RowCount - 1].Cells[0];
                        selectAfterDo();
                        count = 0;
                        F_QLDV_V.Enabled = true;
                        F_QLDV_Thoat.Text = "Thoát";
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập đúng định dạng số cho đơn giá!!");
                    }

                }
            }
        }

        private void updatemadv()
        {
            string query = "SELECT ( CASE WHEN NOT EXISTS(SELECT NULL FROM DichVu) THEN 1 ELSE (SELECT IDENT_CURRENT('DichVu') + 1) END) AS cl1";
            DataTable tb = GetData.getdata(query, false, false);
            tb_ma.Text = tb.Rows[0][0].ToString();
        }

        private void selectAfterDo()
        {
            if (F_QLDV_V.CurrentCell == null)
            {
                cleardata();
            }
            else
            {
                tb_ma.Text = F_QLDV_V.CurrentRow.Cells[0].Value + "";
                tb_ten.Text = F_QLDV_V.CurrentRow.Cells[1].Value + "";
                long gia = Convert.ToInt64(F_QLDV_V.CurrentRow.Cells[2].Value);
                tb_gia.Text = gia.ToString();
                tb_ten.Enabled = false;
                tb_gia.Enabled = false;
            }
        }

        private void F_QLDV_Sua_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                F_QLDV_Thoat.Text = "Huỷ";
                //cleardata();
                tb_gia.Enabled = true;
                tb_ten.Enabled = true;
                F_QLDV_V.Enabled = false;
                F_QLDV_Xoa.Enabled = false;
                F_QLDV_Them.Enabled = false;
                //tb_makh.Text = Convert.ToInt32(F_QLKH_V.Rows[F_QLKH_V.RowCount - 1].Cells[0].Value) + 1 + "";
                count = 2;
            }
            else if (count == 2)
            {
                string query = "SELECT CAST(COUNT(1) AS BIT) AS Expr1 FROM DichVu WHERE TenDV = @ten AND MaDV != @ma";
                GetData.con.Open();
                GetData.com = new SqlCommand(query, GetData.con);
                GetData.com.Parameters.Add("@ten", tb_ten.Text);
                GetData.com.Parameters.Add("@ma", tb_ma.Text);
                bool ss = GetData.testdata(false);
                if (tb_ten.Text == "" || tb_gia.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin!!!");
                }
                else if (ss)
                {
                    MessageBox.Show("Đã có dịch vụ " + tb_ten.Text + " !!");
                    selectAfterDo();
                }
                else
                {
                    decimal gia;
                    int ton;
                    //bool check = int.TryParse(tb_ton.Text, out ton);
                    if (decimal.TryParse(tb_gia.Text, out gia))
                    {
                        query = "update DichVu set TenDV = @ten,DonGia = @gia where MaDV = @ma";
                        GetData.con.Open();
                        GetData.com = new SqlCommand(query, GetData.con);
                        GetData.com.Parameters.Add("@ma", tb_ma.Text);
                        GetData.com.Parameters.Add("@ten", tb_ten.Text.ToLower());
                        GetData.com.Parameters.Add("@gia", gia);
                        GetData.putdata();
                        int id = F_QLDV_V.CurrentRow.Index;
                        MessageBox.Show("Sửa dịch vụ thành công!!", "Thông báo");
                        getdataview();
                        F_QLDV_V.CurrentCell = F_QLDV_V.Rows[id].Cells[0];
                        selectAfterDo();
                        count = 0;
                        F_QLDV_Thoat.Text = "Thoát";
                        F_QLDV_Them.Enabled = true;
                        F_QLDV_V.Enabled = true;
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng nhập đúng định dạng số cho đơn giá!!");
                    }

                }
            }
        }

        private void F_QLDV_Xoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xoá dịch vụ đã chọn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string query = "DELETE FROM DichVu WHERE MaDV = @ma";
                    GetData.con.Open();
                    GetData.com = new SqlCommand(query, GetData.con);
                    //GetData.com.Parameters.Add("@ma", tb_ma.Text);
                    GetData.com.Parameters.Add("@ma", F_QLDV_V.CurrentRow.Cells[0].Value);
                    if (GetData.putdata() == 1)
                    {
                        MessageBox.Show("Xoá dịch vụ thành công!!", "Thông báo");
                        getdataview();
                        F_QLDV_V.CurrentCell = null;
                        F_QLDV_Sua.Enabled = false;
                        F_QLDV_Xoa.Enabled = false;
                        tb_ma.Text = "";
                        cleardata();
                    }
                }catch(Exception)
                {
                    MessageBox.Show("lỗi");
                    GetData.con.Close();
                }

            }
        }

        private void F_QLDV_Thoat_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                F_QLDV_V.CurrentCell = null;
                tb_gia.Enabled = false;
                tb_ten.Enabled = false;
                F_QLDV_Sua.Enabled = false;
                F_QLDV_Xoa.Enabled = false;
                F_QLDV_V.Enabled = true;
                //F_QLKH_V.CurrentCell = null;
                count = 0;
                F_QLDV_Thoat.Text = "Thoát";
                tb_ma.Text = "";
                selectAfterDo();
            }
            else if (count == 2)
            {
                tb_gia.Enabled = false;
                tb_ten.Enabled = false;
                //F_QLKH_Sua.Enabled = true;
                F_QLDV_Xoa.Enabled = true;
                F_QLDV_Them.Enabled = true;
                F_QLDV_V.Enabled = true;
                count = 0;
                F_QLDV_Thoat.Text = "Thoát";
                selectAfterDo();
            }
            else this.Dispose();
        }
    }
}
