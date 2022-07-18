using Microsoft.Reporting.WinForms;
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

namespace QLKS
{
    public partial class F_Export_SDDV : Form
    {
        public PhieuSDDV sddv;
        public ChiTietSDDV chitiet;
        public static List<PhieuSDDV> lst;
        public static List<ChiTietSDDV> lst1;
        public F_Export_SDDV()
        {
            InitializeComponent();
        }

        ReportDataSource rs;
        ReportDataSource rs1;

        private void F_Export_SDDV_Load(object sender, EventArgs e)
        {
            getdatareport();          
        }

        private void getdatareport()
        {

            string query = "alter view phieusddv as select SoPhieuDV,GioCungCap,SoPhieuThue,KhachHang.HoTen,KhachHang.DiaChi,KhachHang.DienThoai,KhachHang.CCCD from SDDV,KhachHang where SDDV.MaKH = KhachHang.MaKH";
            GetData.con.Open();
            GetData.com = new SqlCommand(query, GetData.con);
            GetData.putdata();

            DataTable tb = new DataTable();
            query = "select * from phieusddv where SoPhieuDV = @sodv";
            GetData.com = new SqlCommand(query, GetData.con);
            GetData.com.Parameters.Add("@sodv", F_SDDV.sophieusddv);
            tb = GetData.getdataview(query, true);


            //Lay du lieu su dung dich vu

            lst = new List<PhieuSDDV>();
            lst.Clear();
            sddv = new PhieuSDDV();
            sddv.sophieudv = (int)tb.Rows[0][0];
            sddv.GioCungCap = ((DateTime)tb.Rows[0][1]);
            sddv.sophieuthue = (int)tb.Rows[0][2];
            sddv.kh = tb.Rows[0][3].ToString().Trim();
            sddv.dc = tb.Rows[0][4].ToString().Trim();
            sddv.dt = tb.Rows[0][5].ToString().Trim();
            sddv.cccd = tb.Rows[0][6].ToString().Trim();
            sddv.hotennv = F_LogIn.TK.htnv;
            lst.Add(sddv);

            rs = new ReportDataSource("DataSet1", lst);

            //Lay du lieu chi tiet su dung dich vu

            query = "alter view phieuchitietsddv as select SoPhieuDV,DichVu.TenDV,DichVu.DonGia,ChiTietSDDV.SL,(DichVu.DonGia*ChiTietSDDV.SL) as thanhtien from ChiTietSDDV,DichVu where ChiTietSDDV.MaDV = DichVu.MaDV";
            GetData.con.Open();
            GetData.com = new SqlCommand(query, GetData.con);
            GetData.putdata();

            DataTable tb1 = new DataTable();
            query = "select * from phieuchitietsddv where SoPhieuDV = @sodv";
            GetData.com = new SqlCommand(query, GetData.con);
            GetData.com.Parameters.Add("@sodv", F_SDDV.sophieusddv);
            tb1 = GetData.getdataview(query, true);



            lst1 = new List<ChiTietSDDV>();
            lst1.Clear();
            for (int i = 0; i < tb1.Rows.Count; i++)
            {
                chitiet = new ChiTietSDDV();
                chitiet.sophieudv = (int)tb1.Rows[i][0];
                chitiet.tendv = tb1.Rows[i][1].ToString().Trim();
                chitiet.dongia = Convert.ToInt64(tb1.Rows[i][2]);
                chitiet.sl = Convert.ToInt32(tb1.Rows[i][3]);
                chitiet.thanhtien = Convert.ToInt64(tb1.Rows[i][4]);
                lst1.Add(chitiet);
            }

            rs1 = new ReportDataSource("DataSet2", lst1);

            //rs = new ReportDataSource();
            //rs.Name = "DataSet1";
            //rs.Value = lst;
            reportViewer1.LocalReport.ReportPath = @"C:\Users\THANG BUI\Desktop\3\2\DoAnPhanMem\App\QLKS\QLKS\PhieuSDDV.rdlc";
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rs);
            //rs = new ReportDataSource();
            //rs1.Name = "DataSet2";
            //rs.Value = lst1;
            reportViewer1.LocalReport.DataSources.Add(rs1);
            //reportViewer1.LocalReport.ReportEmbeddedResource= "QLKS.RP_PhieuSDDV.rdlc";
            reportViewer1.RefreshReport();
        }
    }
}
