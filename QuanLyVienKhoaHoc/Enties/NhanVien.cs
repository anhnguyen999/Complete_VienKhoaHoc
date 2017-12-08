using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyVienKhoaHoc.Enum;

namespace QuanLyVienKhoaHoc.Enties
{
    class NhanVien
    {
        public string HoTen { get; set; }

        public DateTime NamSinh { get; set; }

        public BangCap BangCap { get; set; }

        public virtual void Nhap()
        {
            Console.WriteLine("\t\t\tHo Ten: ");
            HoTen = Console.ReadLine();
            Console.WriteLine("\t\t\tNam Sinh: ");
            NamSinh = DateTime.Parse(Console.ReadLine());
            Console.Write("\t\t\tChon: 1.Ky Su \t2. Thac Si \t3. Tien si: ");
            BangCap = (BangCap)int.Parse(Console.ReadLine());
        }

        public virtual void Xuat()
        {
            Console.WriteLine("\t\t\tHo Ten: {0}", HoTen);
            Console.WriteLine("\t\t\tNam sinh: {0}", NamSinh.ToShortDateString());
            Console.WriteLine("\t\t\tBang cap {0}", BangCap);
        }
    }
}
