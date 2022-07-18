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
    public partial class F_Export_Thue : Form
    {
        public F_Export_Thue()
        {
            InitializeComponent();
        }

        ReportDataSource rs = new ReportDataSource();

        private void F_Export_Thue_Load(object sender, EventArgs e)
        {
            string query = "alter view phieuthue as select Thue.SoPhieuThue,KhachHang.HoTen,KhachHang.DiaChi,KhachHang.DienThoai,KhachHang.CCCD,NgayThue,Thue.MaPhong,Phong.Loai,Phong.TrangThai,Phong.DonGia from Thue,KhachHang,Phong where Thue.MaKH = KhachHang.MaKH and Thue.MaPhong = Phong.MaPhong";
            GetData.con.Open();
            GetData.com = new SqlCommand(query, GetData.con);
            GetData.putdata();

            DataTable tb = new DataTable();
            query = "select * from phieuthue where SoPhieuThue = @sopt";
            GetData.com = new SqlCommand(query, GetData.con);
            GetData.com.Parameters.Add("@sopt", F_THUE.sophieu);
            tb = GetData.getdataview(query, true);

            PhieuThue pt = new PhieuThue();
            pt.sophieuthue = Convert.ToInt32(tb.Rows[0][0]);
            pt.kh = tb.Rows[0][1].ToString().Trim();
            pt.dc = tb.Rows[0][2].ToString().Trim();
            pt.dt = tb.Rows[0][3].ToString().Trim();
            pt.cccd = tb.Rows[0][4].ToString().Trim();
            pt.ngaythue = (DateTime) tb.Rows[0][5];
            pt.maphong = tb.Rows[0][6].ToString().Trim();
            pt.loai = tb.Rows[0][7].ToString().Trim();
            pt.tt = tb.Rows[0][8].ToString().Trim();
            pt.dongia = Convert.ToInt64(tb.Rows[0][9]);
            pt.hotennv = F_LogIn.TK.htnv;

            List<PhieuThue> lst = new List<PhieuThue>();
            lst.Clear();
            lst.Add(pt);
            rs.Name = "DataSet1";
            rs.Value = lst;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(rs);
            reportViewer1.LocalReport.ReportEmbeddedResource = "QLKS.RP_PhieuThue.rdlc";
            reportViewer1.RefreshReport();
        }
    }
}
