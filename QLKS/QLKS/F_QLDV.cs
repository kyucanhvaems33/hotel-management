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
            F_QLDV_V.Columns[2].HeaderText = "Đơn vị tính";
            F_QLDV_V.Columns[3].HeaderText = "Tồn kho";
            F_QLDV_V.Columns[4].HeaderText = "Đơn giá";
            F_QLDV_V.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            F_QLDV_V.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            //MessageBox.Show(GetData.getdata(query).Columns.Count+"");

        }

        private void F_QLDV_Load(object sender, EventArgs e)
        {
            F_QLDV_V.CurrentCell = null;
            tb_ma.Text = "";
            tb_ten.Text = "";
            tb_dvtinh.Text = "";
            tb_gia.Text = "";
            tb_ton.Text = "";
            //F_QLDV_V.ClearSelection();
            foreach (DataGridViewColumn item in F_QLDV_V.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }


        private void F_QLDV_V_SelectionChanged(object sender, EventArgs e)
        {
            tb_ma.Text = F_QLDV_V.CurrentRow.Cells[0].Value + "";
            tb_ten.Text = F_QLDV_V.CurrentRow.Cells[1].Value + "";
            tb_dvtinh.Text = F_QLDV_V.CurrentRow.Cells[2].Value + "";
            tb_ton.Text = F_QLDV_V.CurrentRow.Cells[3].Value + "";
            long gia = Convert.ToInt64(F_QLDV_V.CurrentRow.Cells[4].Value);
            tb_gia.Text = gia.ToString();
        }

        private void F_QLDV_Them_Click(object sender, EventArgs e)
        {
            string query = "SELECT CAST(COUNT(1) AS BIT) AS Expr1 FROM DichVu WHERE TenDV = @ten";
            GetData.con.Open();
            GetData.com = new SqlCommand(query, GetData.con);
            GetData.com.Parameters.Add("@ten", tb_ten.Text);
            bool ss = GetData.testdata(false);
            if (tb_ten.Text == "" || tb_dvtinh.Text == "" || tb_gia.Text == "" || tb_ton.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!!!");
            }
            else if (ss)
            {
                MessageBox.Show("Đã có dịch vụ "+tb_ten.Text+" !!");
            }
            else
            {
                decimal gia;
                int ton;
                bool check = int.TryParse(tb_ton.Text, out ton);
                if (decimal.TryParse(tb_gia.Text, out gia)||check)
                {
                    query = "insert into DichVu (TenDV,DVTinh,TonKho,DonGia) values (@ten,@dvtinh,@ton,@gia)";
                    GetData.con.Open();
                    GetData.com = new SqlCommand(query, GetData.con);
                    GetData.com.Parameters.Add("@ten", tb_ten.Text.ToLower());
                    GetData.com.Parameters.Add("@dvtinh", tb_dvtinh.Text.ToLower());
                    GetData.com.Parameters.Add("@ton",ton);
                    GetData.com.Parameters.Add("@gia",gia);
                    GetData.putdata();
                    getdataview();
                    F_QLDV_V.CurrentCell = F_QLDV_V.Rows[F_QLDV_V.RowCount - 1].Cells[0];
                    selectAfterDo();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng số cho đơn giá!!");
                }

            }
        }

        private void selectAfterDo()
        {
            tb_ma.Text = F_QLDV_V.CurrentRow.Cells[0].Value + "";
            tb_ten.Text = F_QLDV_V.CurrentRow.Cells[1].Value + "";
            tb_dvtinh.Text = F_QLDV_V.CurrentRow.Cells[2].Value + "";
            tb_ton.Text = F_QLDV_V.CurrentRow.Cells[3].Value + "";
            long gia = Convert.ToInt64(F_QLDV_V.CurrentRow.Cells[4].Value);
            tb_gia.Text = gia.ToString();
        }

        private void F_QLDV_Sua_Click(object sender, EventArgs e)
        {
            string query = "SELECT CAST(COUNT(1) AS BIT) AS Expr1 FROM DichVu WHERE TenDV = @ten AND MaDV != @ma";
            GetData.con.Open();
            GetData.com = new SqlCommand(query, GetData.con);
            GetData.com.Parameters.Add("@ten", tb_ten.Text);
            GetData.com.Parameters.Add("@ma", tb_ma.Text);
            bool ss = GetData.testdata(false);
            if (F_QLDV_V.CurrentCell == null)
            {
                MessageBox.Show("Vui lòng chọn một hàng dưới bảng thông tin để sửa!!");
            }
            else if (tb_ten.Text == "" || tb_dvtinh.Text == "" || tb_gia.Text == "" || tb_ton.Text == "")
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
                bool check = int.TryParse(tb_ton.Text, out ton);
                if (decimal.TryParse(tb_gia.Text, out gia) || check)
                {
                    query = "update DichVu set TenDV = @ten, DVTinh = @dvtinh, TonKho = @ton, DonGia = @gia where MaDV = @ma";
                    GetData.con.Open();
                    GetData.com = new SqlCommand(query, GetData.con);
                    GetData.com.Parameters.Add("@ma", tb_ma.Text);
                    GetData.com.Parameters.Add("@ten", tb_ten.Text.ToLower());
                    GetData.com.Parameters.Add("@dvtinh", tb_dvtinh.Text.ToLower());
                    GetData.com.Parameters.Add("@ton", ton);
                    GetData.com.Parameters.Add("@gia", gia);
                    GetData.putdata();
                    int id = F_QLDV_V.CurrentRow.Index;
                    getdataview();
                    F_QLDV_V.CurrentCell = F_QLDV_V.Rows[id].Cells[0];
                    selectAfterDo();
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng định dạng số cho đơn giá!!");
                }

            }
        }

        private void F_QLDV_Xoa_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM DichVu WHERE MaDV = @ma";
            GetData.con.Open();
            GetData.com = new SqlCommand(query, GetData.con);
            GetData.com.Parameters.Add("@ma", tb_ma.Text);
            if (F_QLDV_V.CurrentCell == null)
            {
                MessageBox.Show("Vui lòng chọn một hàng dưới bảng thông tin để xoá!!");
                GetData.con.Close();
                GetData.com.Dispose();
            }
            else if (GetData.putdata() == 1)
            {
                MessageBox.Show("Xoá dịch vụ thành công!!");
                getdataview();
            }
        }

        private void F_QLDV_Thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
