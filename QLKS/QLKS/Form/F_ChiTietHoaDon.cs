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
    public partial class F_ChiTietHoaDon : Form
    {
        public F_ChiTietHoaDon()
        {
            InitializeComponent();
            getchitet();
        }

        private void getchitet()
        {
            string query = "select DichVu.TenDV,SL from ChiTietSDDV,DichVu where ChiTietSDDV.MaDV = DichVu.MaDV AND SoPhieuDV = @sophieu";
            GetData.com = new SqlCommand(query, GetData.con);
            GetData.com.Parameters.Add("@sophieu",F_HoaDonSDDV.sohoadon);
            dataGridView1.DataSource = GetData.getdata(query, true, true);
            dataGridView1.Columns[0].HeaderText = "Tên dịch vụ";
            dataGridView1.Columns[1].HeaderText = "Số lượng";
            //F_THUE_V.DataSource = GetData.getdata(query, false, false);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
        }

        private void F_ChiTietHoaDon_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn item in dataGridView1.Columns)
            {
                item.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }
    }
}
