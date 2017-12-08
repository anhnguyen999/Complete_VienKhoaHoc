using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuanLyVienKhoaHoc.Enties;
using QuanLyVienKhoaHoc.App;
using QuanLyVienKhoaHoc.Enum;
namespace QuanLyVienKhoaHoc
{
    class Program
    {
        static void Main(string[] args)
        {
            AppQuanLyVienKhoaHoc app = new AppQuanLyVienKhoaHoc();
            app.NhapDanhSach();
            Console.WriteLine("----Danh sach nhan vien-----");
            app.XuatDanhSach();
            Console.ReadLine();
        }
    }
}
