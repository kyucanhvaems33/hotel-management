using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace QLKS
{
    public partial class F_DoanhThu_DV : Form
    {
        public F_DoanhThu_DV()
        {
            InitializeComponent();
        }

        ReportDataSource rs = new ReportDataSource();

        private void F_DoanhThu_DV_Load(object sender, EventArgs e)
        {
            string query = "alter view doanhthu1 as select ChiTietSDDV.MaDV,DichVu.TenDV,SDDV.GioCungCap,DichVu.DonGia,ChiTietSDDV.SL,(DichVu.DonGia*ChiTietSDDV.SL) as thanhtien  from ChiTietSDDV,DichVu,SDDV where ChiTietSDDV.SoPhieuDV = SDDV.SoPhieuDV and ChiTietSDDV.MaDV = DichVu.MaDV";
            GetData.con.Open();
            GetData.com = new SqlCommand(query, GetData.con);
            GetData.putdata();

            query = "select * from doanhthu1";
            DataTable tb = GetData.getdataview(query, false);
            getreport(tb, reportViewer1);
        }

        private void getreport(DataTable tb, ReportViewer rp)
        {
            List<DTDichVu> doanhthu = new List<DTDichVu>();
            doanhthu.Clear();
            for (int i = 0; i < tb.Rows.Count; i++)
            {
                DTDichVu p = new DTDichVu();

                p.madv = (int)tb.Rows[i][0];
                p.tendv = tb.Rows[i][1].ToString().Trim();
                p.gio = ((DateTime)tb.Rows[i][2]);
                p.dongia = Convert.ToInt64(tb.Rows[i][3]);
                p.sl = (int)tb.Rows[i][4];
                p.thanhtien = Convert.ToInt64(tb.Rows[i][5]);


                doanhthu.Add(p);
            }

            rs.Name = "DataSet1";
            rs.Value = doanhthu;
            rp.LocalReport.DataSources.Clear();
            rp.LocalReport.DataSources.Add(rs);
            rp.LocalReport.ReportEmbeddedResource = "QLKS.RP_DoanhThuDichVu.rdlc";
            rp.RefreshReport();
        }

        private void tabcontrol1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabcontrol1.SelectedIndex == 0)
            {
                string query = "select * from doanhthu1";
                DataTable tb = GetData.getdataview(query, false);
                getreport(tb, reportViewer1);
            }
            if (tabcontrol1.SelectedIndex == 1)
            {
                string query = "SELECT DISTINCT FORMAT ( GioCungCap , 'MM-yyyy' ) as thangnam, MONTH(GioCungCap) as thang , YEAR (GioCungCap) as nam from doanhthu1";
                bindcombobox(query, comboBox1, "thangnam",false);
            }

            if (tabcontrol1.SelectedIndex == 2)
            {
                string query = "select DISTINCT MaDV,TenDV from doanhthu1 ";
                bindcombobox(query, comboBox2, "TenDV",true);
            }
        }

        private void bindcombobox(string query, ComboBox cb, string display,bool value)
        {
            //MessageBox.Show("1");
            DataTable tb = GetData.getdataview(query, false);
            cb.DataSource = tb;
            cb.DisplayMember = display;
            if (value)
            {
                cb.ValueMember = "MaDV";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int nam = (int)((DataRowView)comboBox1.SelectedItem).Row.ItemArray[2];
            string thang = (int)((DataRowView)comboBox1.SelectedItem).Row.ItemArray[1] / 10 > 1 ? ((DataRowView)comboBox1.SelectedItem).Row.ItemArray[1].ToString() : "0" + ((DataRowView)comboBox1.SelectedItem).Row.ItemArray[1].ToString();
            //MessageBox.Show(thang);
            int days = DateTime.DaysInMonth(nam, Convert.ToInt32(thang));
            string query = "select * from doanhthu1 where GioCungCap >= @ngaytra1 AND GioCungCap <= @ngaytra2";
            //string thang = comboBox1.Text;
            //MessageBox.Show(days + "");
            string ngaytra1 = nam + "-" + thang + "-01";
            //MessageBox.Show(ngaytra1);
            //DateTime.ParseExact(ngaytra1, "yyyy-MM-dd", null);
            //MessageBox.Show(ngaytra1);
            GetData.com = new SqlCommand(query, GetData.con);
            GetData.com.Parameters.Add("@ngaytra1", DateTime.ParseExact(ngaytra1, "yyyy-MM-dd", null));
            GetData.com.Parameters.Add("@ngaytra2", DateTime.ParseExact(nam + "-" + thang + "-" + days, "yyyy-MM-dd", null));
            DataTable tb = GetData.getdataview(query, true);
            getreport(tb, reportViewer2);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            int madv = Convert.ToInt32(((DataRowView)comboBox2.SelectedItem).Row.ItemArray[0]);
            //MessageBox.Show(comboBox2.SelectedValue.ToString());
            //MessageBox.Show(((DataRowView)comboBox2.SelectedItem).Row.ItemArray[0] + "");
            string query = "select * from doanhthu1 where madv = @madv";
            GetData.com = new SqlCommand(query, GetData.con);
            GetData.com.Parameters.Add("@madv", madv);
            DataTable tb = GetData.getdataview(query, true);
            getreport(tb, reportViewer3);
        }
    }
}
