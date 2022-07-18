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
    public partial class F_SDDV : Form
    {
        public static int sophieusddv;
        public F_SDDV()
        {
            InitializeComponent();
            getviewthue();
        }

        private void getviewthue()
        {
            string query = "select * from Thue where not exists(select * from Tra where Thue.SoPhieuThue = Tra.SoPhieuThue)";
            F_SDDV_THUE_V.DataSource = GetData.getdata(query, false, false);
            F_SDDV_THUE_V.Columns[0].HeaderText = "Số phiếu thuê";
            F_SDDV_THUE_V.Columns[1].HeaderText = "Ngày thuê";
            F_SDDV_THUE_V.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            F_SDDV_THUE_V.Columns[2].HeaderText = "Mã Phòng";
            F_SDDV_THUE_V.Columns[3].HeaderText = "Mã khách hàng";
            //F_THUE_V.DataSource = GetData.getdata(query, false, false);
            F_SDDV_THUE_V.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            F_SDDV_THUE_V.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void F_SDDV_Load(object sender, EventArgs e)
        {
            load();
            foreach (DataGridViewColumn item in F_SDDV_THUE_V.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }


        private void load()
        {
            timer1.Start();
            F_SDDV_THUE_V.CurrentCell = null;
            tb_mathue.Text = "";
            tb_makh.Text = "";
            updatemasddv();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tb_gio.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm", new CultureInfo("vi-VN"));
        }

        private void F_SDDV_THUE_V_SelectionChanged(object sender, EventArgs e)
        {
            tb_mathue.Text = F_SDDV_THUE_V.CurrentRow.Cells[0].Value.ToString();
            tb_makh.Text = F_SDDV_THUE_V.CurrentRow.Cells[3].Value.ToString();
            btn_taophieu.Enabled = true;
        }

        private void updatemasddv()
        {
            string query = "SELECT ( CASE WHEN NOT EXISTS(SELECT NULL FROM DichVu) THEN 1 ELSE (SELECT IDENT_CURRENT('SDDV') + 1) END) AS cl1";
            DataTable tb = GetData.getdata(query, false, false);
            tb_sophieu.Text = tb.Rows[0][0].ToString();
        }

        private void btn_taophieu_Click(object sender, EventArgs e)
        {
            sophieusddv = Convert.ToInt32(tb_sophieu.Text);
            string query = "insert into SDDV (GioCungCap,MaKH,SoPhieuThue) values (@gio,@makh,@sophieuthue)";
            GetData.con.Open();
            GetData.com = new SqlCommand(query, GetData.con);
            GetData.com.Parameters.Add("@gio", DBNull.Value);
            GetData.com.Parameters.Add("@makh", Convert.ToInt32(tb_makh.Text));
            GetData.com.Parameters.Add("@sophieuthue", Convert.ToInt32(tb_mathue.Text));

            GetData.putdata();
            this.Hide();
            new F_CHITIETSDDV().ShowDialog();
            this.Show();
            load();
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            if (tb_timkiem.Text == "")
            {
                getviewthue();
                F_SDDV_THUE_V.CurrentCell = null;
                cleardata();
            }
            else if (rdbtn_mathue.Checked)
            {
                try
                {
                    string query = "select * from Thue where not exists(select * from Tra where Thue.SoPhieuThue = Tra.SoPhieuThue) AND SoPhieuThue = @mathue";
                    GetData.com = new SqlCommand(query, GetData.con);
                    GetData.com.Parameters.Add("@mathue", Convert.ToInt32(tb_timkiem.Text));
                    F_SDDV_THUE_V.DataSource = GetData.getdata(query, false, true);
                    F_SDDV_THUE_V.CurrentCell = null;
                    cleardata();
                }
                catch (Exception)
                {
                    MessageBox.Show("Vui lòng nhập định dạng số khi tìm kiếm theo số phiếu thuê");
                    tb_timkiem.Text = "";
                }
            }
            else if (rdbtn_maphong.Checked)
            {
                string query = "select * from Thue where not exists(select * from Tra where Thue.SoPhieuThue = Tra.SoPhieuThue) AND MaPhong like @maphong";
                GetData.com = new SqlCommand(query, GetData.con);
                GetData.com.Parameters.Add("@maphong", tb_timkiem.Text.ToString() + "%");
                F_SDDV_THUE_V.DataSource = GetData.getdata(query, false, true);
                F_SDDV_THUE_V.CurrentCell = null;
                cleardata();
            }
        }

        private void cleardata()
        {
            tb_mathue.Text = "";
            tb_makh.Text = "";
        }
    }
}
