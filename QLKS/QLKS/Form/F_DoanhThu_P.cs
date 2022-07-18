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
using Microsoft.Reporting.WinForms;
using System.Data.SqlClient;

namespace QLKS
{
    public partial class F_DoanhThu_P : Form
    {
        public F_DoanhThu_P()
        {
            InitializeComponent();
        }

        ReportDataSource rs = new ReportDataSource();
        

        private void F_DoanhThu_P_Load(object sender, EventArgs e)
        {
            string query = "alter view dbo.doanhthu as select Tra.MaPhong, MaKH, NgayThue, NgayTra, cast (case when DATEDIFF(DAY,NgayThue,NgayTra) = 0 then 1 else DATEDIFF(DAY,NgayThue,NgayTra) end as int) as Ngayo,Phong.DonGia,(DonGia * cast (case when DATEDIFF(DAY,NgayThue,NgayTra) = 0 then 1 else DATEDIFF(DAY,NgayThue,NgayTra) end as int)) as tienphong from Tra,Phong where Tra.MaPhong = Phong.MaPhong";
            GetData.con.Open();
            GetData.com = new SqlCommand(query, GetData.con);
            GetData.putdata();

            query = "select * from doanhthu";
            DataTable tb = GetData.getdataview(query, false);
            getreport(tb,reportViewer1);
        }

        

        private void tabcontrol1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabcontrol1.SelectedIndex == 0)
            {
                string query = "select * from doanhthu";
                DataTable tb = GetData.getdataview(query, false);
                getreport(tb,reportViewer1);
            }
            if (tabcontrol1.SelectedIndex == 1)
            {
                string query = "SELECT DISTINCT FORMAT ( NgayTra , 'MM-yyyy' ) as thangnam, MONTH(NgayTra) as thang , YEAR (NgayTra) as nam from doanhthu";
                bindcombobox(query,comboBox1,"thangnam");
            }

            if (tabcontrol1.SelectedIndex == 2)
            {
                string query = "select DISTINCT MaPhong from doanhthu ";
                bindcombobox(query,comboBox2,"MaPhong");
            }


        }

        private void getreport(DataTable tb,ReportViewer rp)
        {
            //int b = (int) tb.Rows[0][0];
            List<DTPhong> doanhthu = new List<DTPhong>();
            doanhthu.Clear();
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                DTPhong p = new DTPhong();

                p.maphong = tb.Rows[i][0].ToString().Trim();
                p.makh = (int)tb.Rows[i][1];
                p.ngaythue = ((DateTime)tb.Rows[i][2]);
                p.ngaytra = ((DateTime)tb.Rows[i][3]);
                p.ngayo = (int)tb.Rows[i][4];
                p.dongia = Convert.ToInt64(tb.Rows[i][5]);
                p.thanhtien = Convert.ToInt64(tb.Rows[i][6]);


                doanhthu.Add(p);
            }
            
            rs.Name = "DataSet1";
            rs.Value = doanhthu;
            rp.LocalReport.DataSources.Clear();
            rp.LocalReport.DataSources.Add(rs);
            rp.LocalReport.ReportEmbeddedResource = "QLKS.RP_DoanhThuPhong.rdlc";
            rp.RefreshReport();
        }

        private void bindcombobox(string query,ComboBox cb,string display)
        {
            
            DataTable tb = GetData.getdataview(query,false);
            cb.DataSource = tb;
            cb.DisplayMember = display;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nam = (int)((DataRowView)comboBox1.SelectedItem).Row.ItemArray[2];
            string thang = (int)((DataRowView)comboBox1.SelectedItem).Row.ItemArray[1] / 10 > 1 ? ((DataRowView)comboBox1.SelectedItem).Row.ItemArray[1].ToString():"0"+ ((DataRowView)comboBox1.SelectedItem).Row.ItemArray[1].ToString();
            //MessageBox.Show(thang);
            int days = DateTime.DaysInMonth(nam, Convert.ToInt32(thang));
            string query = "select * from doanhthu where NgayTra >= @ngaytra1 AND NgayTra <= @ngaytra2";
            //string thang = comboBox1.Text;
            //MessageBox.Show(days + "");
            string ngaytra1 = nam + "-" + thang + "-01";
            //MessageBox.Show(ngaytra1);
            //DateTime.ParseExact(ngaytra1, "yyyy-MM-dd", null);
            //MessageBox.Show(ngaytra1);
            GetData.com = new SqlCommand(query, GetData.con);
            GetData.com.Parameters.Add("@ngaytra1",DateTime.ParseExact(ngaytra1,"yyyy-MM-dd",null));
            GetData.com.Parameters.Add("@ngaytra2", DateTime.ParseExact(nam + "-" + thang + "-"+days, "yyyy-MM-dd", null));
            DataTable tb = GetData.getdataview(query, true);
            getreport(tb, reportViewer2);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mp = ((DataRowView)comboBox2.SelectedItem).Row.ItemArray[0].ToString().Trim();
            string query = "select * from doanhthu where MaPhong like @mp";
            GetData.com = new SqlCommand(query, GetData.con);
            GetData.com.Parameters.Add("@mp", mp+"%");
            DataTable tb = GetData.getdataview(query, true);
            getreport(tb, reportViewer3);
        }
    }
}
