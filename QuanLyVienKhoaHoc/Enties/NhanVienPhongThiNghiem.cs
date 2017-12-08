using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVienKhoaHoc.Enties
{
    class NhanVienPhongThiNghiem : NhanVien
    {
        public double LuongThang { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("\t\t\tLuong thang: ");
            //chua bat loi rang buoc (lam sau)
            LuongThang = double.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("\t\t\tLuong thang: {0}", LuongThang);
        }
    }
}