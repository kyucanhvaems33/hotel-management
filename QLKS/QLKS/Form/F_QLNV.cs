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
        private int count = 0;
        // 1 la them - 2 la sua
        public F_QLNV()
        {
            InitializeComponent();
            getdataview();
        }

        private void cleardata()
        {
            tb_ht.Text = "";
        }

        private void getdataview()
        {
            string query = "select * from NhanVien";
            F_QLNV_V.DataSource = GetData.getdata(query, false,false);
            F_QLNV_V.Columns[0].HeaderText = "Mã nhân viên";
            F_QLNV_V.Columns[1].HeaderText = "Họ tên";
            F_QLNV_V.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            F_QLNV_V.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            //MessageBox.Show(GetData.getdata(query).Columns.Count+"");

        }

        private void F_QLNV_Load(object sender, EventArgs e)
        {
            F_QLNV_V.CurrentCell = null;
            tb_ma.Text = "";
            cleardata();
            //MessageBox.Show(F_QLKH_V.CurrentRow.Index + "");
            foreach (DataGridViewColumn item in F_QLNV_V.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            F_QLNV_Xoa.Enabled = false;
            F_QLNV_Sua.Enabled = false;
        }

        private void F_QLNV_V_SelectionChanged(object sender, EventArgs e)
        {
            tb_ma.Text = F_QLNV_V.CurrentRow.Cells[0].Value + "";
            tb_ht.Text = F_QLNV_V.CurrentRow.Cells[1].Value + "";
            F_QLNV_Sua.Enabled = true;
            F_QLNV_Xoa.Enabled = true;
        }
    
        private void F_QLNV_Them_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                F_QLNV_Thoat.Text = "Huỷ";
                cleardata();
                tb_ht.Enabled = true;
                F_QLNV_Sua.Enabled = false;
                F_QLNV_V.Enabled = false;
                F_QLNV_Xoa.Enabled = false;
                updatemanv();
                count = 1;
            }
            else if (count == 1)
            {
                string query = "insert into NhanVien (HoTen) values (@ht)";
                GetData.con.Open();
                GetData.com = new SqlCommand(query, GetData.con);
                GetData.com.Parameters.Add("@ht", tb_ht.Text);
                GetData.putdata();
                MessageBox.Show("Thêm nhân viên thành công!!", "Thông báo");
                getdataview();
                F_QLNV_V.CurrentCell = F_QLNV_V.Rows[F_QLNV_V.RowCount - 1].Cells[0];
                selectAfterDo();
                count = 0;
                F_QLNV_Thoat.Text = "Thoát";
                F_QLNV_V.Enabled = true;
            }
        }

        private void updatemanv()
        {
            string query = "SELECT ( CASE WHEN NOT EXISTS(SELECT NULL FROM DichVu) THEN 1 ELSE (SELECT IDENT_CURRENT('NhanVien') + 1) END) AS cl1";
            DataTable tb = GetData.getdata(query, false, false);
            tb_ma.Text = tb.Rows[0][0].ToString();
        }

        private void selectAfterDo()
        {
            if (F_QLNV_V.CurrentCell == null)
            {
                cleardata();
            }
            else
            {
                tb_ma.Text = F_QLNV_V.CurrentRow.Cells[0].Value + "";
                tb_ht.Text = F_QLNV_V.CurrentRow.Cells[1].Value + "";
                tb_ht.Enabled = false;
            }
        }

        private void F_QLNV_Sua_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                F_QLNV_Thoat.Text = "Huỷ";
                F_QLNV_V.Enabled = false;
                //cleardata();
                tb_ht.Enabled = true;
                F_QLNV_Xoa.Enabled = false;
                F_QLNV_Them.Enabled = false;
                //tb_makh.Text = Convert.ToInt32(F_QLKH_V.Rows[F_QLKH_V.RowCount - 1].Cells[0].Value) + 1 + "";
                count = 2;
            }
            else if (count == 2)
            {
                if (F_QLNV_V.CurrentCell == null)
                {
                    MessageBox.Show("Vui lòng chọn một hàng dưới bảng thông tin để sửa!!");
                }
                else
                {
                    string query = "update NhanVien set HoTen = @ht where MaNV = @ma";
                    GetData.con.Open();
                    GetData.com = new SqlCommand(query, GetData.con);
                    GetData.com.Parameters.Add("@ma", F_QLNV_V.CurrentRow.Cells[0].Value);
                    GetData.com.Parameters.Add("@ht", tb_ht.Text);
                    GetData.putdata();
                    int id = F_QLNV_V.CurrentRow.Index;
                    MessageBox.Show("Sửa nhân viên thành công!!", "Thông báo");
                    getdataview();
                    F_QLNV_V.CurrentCell = F_QLNV_V.Rows[id].Cells[0];
                    selectAfterDo();
                    count = 0;
                    F_QLNV_Thoat.Text = "Thoát";
                    F_QLNV_Them.Enabled = true;
                    F_QLNV_V.Enabled = true;
                }
            }
        }

        private void F_QLNV_Xoa_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Bạn có muốn xoá nhân viên đã chọn không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM NhanVien WHERE MaNV = @ma";
                GetData.con.Open();
                GetData.com = new SqlCommand(query, GetData.con);
                GetData.com.Parameters.Add("@ma", F_QLNV_V.CurrentRow.Cells[0].Value);
                try
                {
                    if (GetData.putdata() == 1)
                    {
                        MessageBox.Show("Xoá Khách nhân viên công!!", "Thông báo");
                        getdataview();
                        F_QLNV_V.CurrentCell = null;
                        F_QLNV_Sua.Enabled = false;
                        F_QLNV_Xoa.Enabled = false;
                        tb_ma.Text = "";
                        cleardata();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Vui lòng xoá tài khoản có mã nhân viên: " + F_QLNV_V.CurrentRow.Cells[0].Value + "trước!");
                }
            }
        }   
        

        private void F_QLNV_Thoat_Click(object sender, EventArgs e)
        {
            if (count == 1)
            {
                F_QLNV_V.CurrentCell = null;
                tb_ht.Enabled = false;
                F_QLNV_Sua.Enabled = false;
                F_QLNV_Xoa.Enabled = false;
                F_QLNV_V.Enabled = true;
                //F_QLKH_V.CurrentCell = null;
                count = 0;
                F_QLNV_Thoat.Text = "Thoát";
                tb_ma.Text = "";
                selectAfterDo();
            }
            else if (count == 2)
            {
                tb_ht.Enabled = false;
                //F_QLKH_Sua.Enabled = true;
                F_QLNV_Xoa.Enabled = true;
                F_QLNV_Them.Enabled = true;
                F_QLNV_V.Enabled = true;
                count = 0;
                F_QLNV_Thoat.Text = "Thoát";
                selectAfterDo();
            }
            else this.Dispose();
        }
    }
}
