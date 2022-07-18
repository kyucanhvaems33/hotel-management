using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLKS
{
    public class Tra
    {

        public int sophieuthue, makh, matra,ngayo;
        public string maphong;
        public long dongia,tongtien;
        public DateTime ngaythue,ngaytra;
        

        public Tra(int sophieuthue, int makh, string maphong, long dongia, long tongtien, DateTime ngaythue, DateTime ngaytra, int matra, int ngayo)
        {
            this.sophieuthue = sophieuthue;
            this.makh = makh;
            this.maphong = maphong;
            this.dongia = dongia;
            this.tongtien = tongtien;
            this.ngaythue = ngaythue;
            this.ngayo = ngayo;
            this.ngaytra = ngaytra;
            this.matra = matra; 
        }
    }
}
