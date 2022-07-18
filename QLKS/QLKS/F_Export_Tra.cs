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
    public partial class F_Export_Tra : Form
    {

        public F_Export_Tra()
        {
            InitializeComponent();
        }
        ReportDataSource rs = new ReportDataSource();
        private void F_Export_Tra_Load(object sender, EventArgs e)
        {
            string query = "alter view dbo.phieutra as select  Tra.SoHoaDon,Tra.SoPhieuThue,KhachHang.HoTen,KhachHang.DiaChi,KhachHang.DienThoai,KhachHang.CCCD,Tra.NgayThue,Tra.NgayTra,cast (case when DATEDIFF(DAY,Tra.NgayThue,Tra.NgayTra) = 0 then 1 else DATEDIFF(DAY,Tra.NgayThue,Tra.NgayTra) end as int) as ngayo, Phong.MaPhong, Phong.Loai,Phong.DonGia, (DonGia * cast (case when DATEDIFF(DAY,NgayThue,NgayTra) = 0 then 1 else DATEDIFF(DAY,NgayThue,NgayTra) end as int)) as tienphong from Tra,Phong,KhachHang where Tra.MaKH = KhachHang.MaKH and Tra.MaPhong = Phong.MaPhong";
            GetData.con.Open();
            GetData.com = new SqlCommand(query, GetData.con);
            GetData.putdata();

            DataTable tb = new DataTable();
            query = "select * from phieutra where SoHoaDon = @sohd";
            GetData.com = new SqlCommand(query, GetData.con);
            GetData.com.Parameters.Add("@sohd", F_TRA.matra);
            tb = GetData.getdataview(query, true);

            PhieuTra ptra = new PhieuTra();
            ptra = new PhieuTra();
            ptra.sohoadon = Convert.ToInt32(tb.Rows[0][0]);
            ptra.sophieuthue = Convert.ToInt32(tb.Rows[0][1]);
            ptra.kh = tb.Rows[0][2].ToString().Trim();
            ptra.dc = tb.Rows[0][3].ToString().Trim();
            ptra.dt = tb.Rows[0][4].ToString().Trim();
            ptra.cccd = tb.Rows[0][5].ToString().Trim();
            ptra.ngaythue = (DateTime)tb.Rows[0][6];
            ptra.ngaytra = (DateTime)tb.Rows[0][7];
            ptra.ngayo = Convert.ToInt32(tb.Rows[0][8]);
            ptra.maphong = tb.Rows[0][9].ToString().Trim();
            ptra.loai = tb.Rows[0][10].ToString().Trim();
            ptra.dongia = Convert.ToInt64(tb.Rows[0][11]);
            ptra.thanhtien = Convert.ToInt64(tb.Rows[0][12]);
            ptra.hotennv = F_LogIn.TK.htnv;


            List<PhieuTra> lst = new List<PhieuTra>();
            lst.Clear();
            lst.Add(ptra);
            rs.Name = "DataSet1";
            rs.Value = lst;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rs);
            reportViewer1.LocalReport.ReportEmbeddedResource = "QLKS.RP_PhieuTra.rdlc";
            reportViewer1.RefreshReport();
        }
    }
}
