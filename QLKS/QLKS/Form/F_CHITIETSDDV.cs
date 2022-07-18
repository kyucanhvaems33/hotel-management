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
    public partial class F_CHITIETSDDV : Form
    {
        public static PhieuSDDV sddv;
        private int sl;
        private bool afterclickchon = false;
        public static DateTime date;
        private int count = 0;

        public F_CHITIETSDDV()
        {
            InitializeComponent();
            getviewDV();
        }

        private void getviewDV()
        {
            string query = "select MaDV, TenDV, DonGia from DichVu";
            V_Dichvu.DataSource = GetData.getdata(query, false, false);
            V_Dichvu.Columns[0].HeaderText = "Mã dịch vụ";
            V_Dichvu.Columns[1].HeaderText = "Tên dịch vụ";
            V_Dichvu.Columns[2].HeaderText = "Đơn giá";
            //F_THUE_V.DataSource = GetData.getdata(query, false, false);
            V_Dichvu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            V_Dichvu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void F_CHITIETSDDV_Load(object sender, EventArgs e)
        {
            timer1.Start();
            V_Dichvu.CurrentCell = null;

            V_chitiet.Columns[3].ReadOnly = false;

            tb_madv.Text = "";
            tb_gia.Text = "";
            tb_sl.Text = "";
            tb_tendv.Text = "";
            lb_tien.Text = "";
            tb_sl.Enabled = false;

            V_chitiet.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            V_chitiet.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            foreach (DataGridViewColumn item in V_Dichvu.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            foreach (DataGridViewColumn item in V_chitiet.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void V_Dichvu_SelectionChanged(object sender, EventArgs e)
        {
            if (!afterclickchon)
            {
                tb_madv.Text = V_Dichvu.CurrentRow.Cells[0].Value.ToString();
                tb_gia.Text = string.Format("{0:#,##0}", double.Parse(V_Dichvu.CurrentRow.Cells[2].Value.ToString()));
                tb_tendv.Text = V_Dichvu.CurrentRow.Cells[1].Value.ToString();
                tb_sl.Enabled = true;
            }
            else
            {
                tb_madv.Text = V_Dichvu.CurrentRow.Cells[0].Value.ToString();
                tb_gia.Text = string.Format("{0:#,##0}", double.Parse(V_Dichvu.CurrentRow.Cells[2].Value.ToString()));
                tb_tendv.Text = V_Dichvu.CurrentRow.Cells[1].Value.ToString();
                tb_sl.Text = "";
                lb_tien.Text = "";
                afterclickchon = false;               
            }
        }

        private void tb_sl_TextChanged(object sender, EventArgs e)
        {
            if (tb_sl.Text != "")
            {
                if(!int.TryParse(tb_sl.Text,out sl))
                {
                    MessageBox.Show("Vui lòng nhập định dạng số cho số lượng");
                    tb_sl.Text = "";
                    btn_chon.Enabled = false;
                }
                else if (sl != 0)
                {
                    lb_tien.Text = string.Format("{0:#,##0}", double.Parse((Convert.ToInt64(V_Dichvu.CurrentRow.Cells[2].Value) * sl).ToString()));
                    btn_chon.Enabled = true;
                }
            }
            else
            {
                lb_tien.Text = "";
                btn_chon.Enabled = false;
            }
        }

        private void btn_chon_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < V_chitiet.RowCount; i++)
            {
                if (Convert.ToInt32(V_chitiet.Rows[i].Cells[0].Value) == Convert.ToInt32(tb_madv.Text))
                {
                    MessageBoxManager.Yes = "Làm mới";
                    MessageBoxManager.No = "Cộng dồn";
                    MessageBoxManager.Cancel = "Huỷ";
                    MessageBoxManager.Register();
                    DialogResult a = MessageBox.Show(null, "Đã có dịch vụ trong chi tiết dịch vụ. Bạn muốn làm mới hay cộng dồn?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                    MessageBoxManager.Unregister();
                    if (a == DialogResult.Yes)
                    {
                        V_chitiet.Rows[i].Cells[3].Value = sl;
                        return;
                    }
                    else if (a == DialogResult.No)
                    {
                        V_chitiet.Rows[i].Cells[3].Value = Convert.ToInt32(V_chitiet.Rows[i].Cells[3].Value) + sl;
                        return;
                    }
                    else return;                    
                }             
            }
            V_chitiet.Rows.Add(Convert.ToInt32(tb_madv.Text), tb_tendv.Text, V_Dichvu.CurrentRow.Cells[2].Value, sl);
            afterclickchon = true;
        }

        private void V_chitiet_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (V_chitiet.Rows.Count != 0)
            {
                if (V_chitiet.CurrentCell == V_chitiet.CurrentRow.Cells[3])
                {
                    //DialogResult a = MessageBox.Show(null, "Đã có dịch vụ trong chi tiết dịch vụ. Bạn muốn làm mới hay cộng dồn?", "Thông báo", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                    V_chitiet.BeginEdit(true);
                }
            }
        }

        private void V_chitiet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (V_chitiet.BeginEdit(true))
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    V_chitiet.EndEdit();
                }
            }
        }

        private void V_chitiet_KeyDown(object sender, KeyEventArgs e)
        {
            if (V_chitiet.CurrentRow != null)
            {
                if (e.KeyCode == Keys.Delete)
                {
                    DialogResult a = MessageBox.Show(null, "Bạn có muốn xoá chi tiết dịch vụ này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (a == DialogResult.Yes)
                    {
                        V_chitiet.Rows.RemoveAt(V_chitiet.CurrentRow.Index);
                    }
                }

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (V_chitiet.Rows.Count != 0)
            {
                btn_luu.Enabled = true;
                long tongtien = 0;
                for (int i = 0; i < V_chitiet.Rows.Count; i++)
                {
                    tongtien = tongtien + (Convert.ToInt64(V_chitiet.Rows[i].Cells[2].Value) * Convert.ToInt32(V_chitiet.Rows[i].Cells[3].Value));                   
                }
                lb_tongtien.Text = string.Format("{0:#,##0}", double.Parse(tongtien.ToString()));
            }
            else btn_luu.Enabled = false;
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                string query = "delete SDDV where SoPhieuDV = @sophieudv";
                GetData.con.Open();
                GetData.com = new SqlCommand(query, GetData.con);
                GetData.com.Parameters.Add("@sophieudv", F_SDDV.sophieusddv);
                GetData.putdata();
            }
        }

        private void btn_luu_Click(object sender, EventArgs e)
        {
            date = DateTime.Now;
            string query = "update SDDV set GioCungCap = @gio where SoPhieuDV = @sophieudv";
            GetData.con.Open();
            GetData.com = new SqlCommand(query, GetData.con);
            GetData.com.Parameters.Add("@gio", date.ToString("yyyy-MM-dd HH:mm:ss", new CultureInfo("vi-VN")));
            GetData.com.Parameters.Add("@sophieudv", F_SDDV.sophieusddv);
            GetData.putdata();


            query = "insert into ChiTietSDDV (SoPhieuDV,MaDV,SL) values (@sophieudv,@madv,@sl)";
            for (int i = 0; i < V_chitiet.Rows.Count; i++)
            {
                GetData.con.Open();
                GetData.com = new SqlCommand(query, GetData.con);
                GetData.com.Parameters.Add("@sophieudv", F_SDDV.sophieusddv);
                GetData.com.Parameters.Add("@madv", Convert.ToInt32(V_chitiet.Rows[i].Cells[0].Value));
                GetData.com.Parameters.Add("@sl", Convert.ToInt32(V_chitiet.Rows[i].Cells[3].Value));
                GetData.putdata();
            }
            count = 1;
            DialogResult a = MessageBox.Show(null, "Hoàn tất lưu phiếu. Bạn có muốn in/xuất phiếu thanh toán sử dụng dịch vụ không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (a == DialogResult.Yes)
            {
                this.Hide();
                new F_Export_SDDV().ShowDialog();
            }
            this.Dispose();           
        }

        private void F_CHITIETSDDV_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (count == 0)
            {
                string query = "delete SDDV where SoPhieuDV = @sophieudv";
                GetData.con.Open();
                GetData.com = new SqlCommand(query, GetData.con);
                GetData.com.Parameters.Add("@sophieudv", F_SDDV.sophieusddv);
                GetData.putdata();
            }
        }
    }
}
