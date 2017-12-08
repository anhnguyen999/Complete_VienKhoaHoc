using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyVienKhoaHoc.Enties;
using QuanLyVienKhoaHoc.Enum;

namespace QuanLyVienKhoaHoc.App
{
    class AppQuanLyVienKhoaHoc
    {
        List<NhanVien> nhanViens = new List<NhanVien>();

        public void NhapDanhSach()
        {
            int soLuong;
            int loaiNhanVien;
            NhanVien nhanVien=null;
            Console.Write("Nhap so luong: ");
            soLuong = int.Parse(Console.ReadLine());
            for (int i = 0; i < soLuong; i++)
            {
                Console.WriteLine("\tNhap nhan vien thu {0}", i + 1);
                Console.WriteLine("\t\tChon loai: ");
                Console.WriteLine("\t\t\t1.Nha Quan Ly ");
                Console.WriteLine("\t\t\t2.Nha Khoa Hoc ");
                Console.WriteLine("\t\t\t3.Nhan Vien Phong Thi Nghiem ");
                Console.WriteLine("\t\t\tChon: ");
                //Lay gia tri con lua
                loaiNhanVien = int.Parse(Console.ReadLine());
                //xac dinh loai nhan vien
                switch (loaiNhanVien)
                {
                    case (int) LoaiNhanVien.NhaQuanLy:
                        Console.WriteLine("\t\t\tNhap thong tin NQL: ");
                        nhanVien = new NhaQuanLy();
                        break;
                    case (int)LoaiNhanVien.NhaKhoaHoc:
                        nhanVien = new NhaKhoaHoc();
                        Console.WriteLine("\t\t\tNhap thong tin NKH: ");
                        break;
                    case (int)LoaiNhanVien.NhanVienPhongThiNghiem:
                        nhanVien = new NhanVienPhongThiNghiem();
                        Console.WriteLine("\t\t\tNhap thong tin NVPTN: ");
                        break;
                    default:
                        break;
                }
                //nhap thong tin
                nhanVien.Nhap();
                //them vao danh sach
                nhanViens.Add(nhanVien);
            }
        }

        public void XuatDanhSach()
        {
            foreach (NhanVien nhanVien in nhanViens)
            {
                nhanVien.Xuat();
            }
        }
    }
}
