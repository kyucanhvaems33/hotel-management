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
    public partial class F_TimKiem_P : Form
    {
        public F_TimKiem_P()
        {
            InitializeComponent();
            getviewp();
        }

        private void getviewp()
        {
            string query = "select * from Phong";
            V_P.DataSource = GetData.getdata(query, true, false);
            V_P.Columns[0].HeaderText = "Mã phòng";
            V_P.Columns[1].HeaderText = "Loại phòng";
            V_P.Columns[2].HeaderText = "Đơn giá";
            V_P.Columns[3].HeaderText = "Trạng thái";
            V_P.Columns[4].HeaderText = "Mã nhân viên";
            //F_QLP_V.column
            V_P.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            V_P.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            //MessageBox.Show(GetData.getdata(query).Columns.Count+"");
        }

        private void F_TimKiem_P_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn item in V_P.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            comboBox1.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_timkiem.Text = "";
        }

        private void tb_timkiem_TextChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                string query = "select * from Phong where TrangThai like @tt";
                GetData.com = new SqlCommand(query, GetData.con);
                GetData.com.Parameters.Add("@tt", SqlDbType.NVarChar).Value = tb_timkiem.Text + "%";
                V_P.DataSource = GetData.getdata(query, false, true);
            }

            if (comboBox1.SelectedIndex == 1)
            {
                string query = "select * from Phong where Loai like @loai";
                GetData.com = new SqlCommand(query, GetData.con);
                GetData.com.Parameters.Add("@loai", SqlDbType.NVarChar).Value = tb_timkiem.Text + "%";
                V_P.DataSource = GetData.getdata(query, false, true);
            }
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
