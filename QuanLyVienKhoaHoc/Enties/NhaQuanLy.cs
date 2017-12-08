using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyVienKhoaHoc.Enum;
namespace QuanLyVienKhoaHoc.Enties
{
    class NhaQuanLy : NhanVien
    {
        public ChucVu ChucVu { get; set; }

        public int SoNgayCong { get; set; }

        public double BacLuong { get; set; }

        public override void Nhap()
        {
            base.Nhap();
            Console.Write("\t\t\tChuc vu: 1. Truong phong, 2. pho phong, 3. nhan vien: ");
            ChucVu = (ChucVu)int.Parse(Console.ReadLine());
            Console.WriteLine("\t\t\tSo ngay cong ");
            SoNgayCong = int.Parse(Console.ReadLine());
            Console.Write("\t\t\tBac luong: ");
            BacLuong = double.Parse(Console.ReadLine());
        }

        public override void Xuat()
        {
            base.Xuat();
            Console.WriteLine("\t\t\tChuc vu: {0}", ChucVu);
            Console.WriteLine("\t\t\tSo ngay cong {0}", SoNgayCong);
            Console.WriteLine("\t\t\tBac luong {0} ", BacLuong);
        }
    }
}
