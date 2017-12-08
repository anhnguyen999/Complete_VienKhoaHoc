using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyVienKhoaHoc.Enties
{
    class NhaKhoaHoc : NhaQuanLy
    {
        public int SoBaiBao { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.WriteLine("\t\t\tSo bai bao: ");
            SoBaiBao = int.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("\t\t\tSo bai bao: {0}", SoBaiBao);
        }
    }
}
