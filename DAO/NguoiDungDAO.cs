using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAO
{
    public class NguoiDungDAO
    {
        public static NguoiDungDTO Login(NguoiDungDTO nguoidung)
        {
            string querry = "SELECT * FROM NguoiDung " +
                "WHERE TenDangNhap='" + nguoidung.TenDangNhap + "' AND MatKhau='" + nguoidung.MatKhau + "' AND QuanLi=" + nguoidung.QuanLi
                + " AND NhanVienNhapKho=" + nguoidung.NhanVienNhapKho + " AND NhanVienBanhang=" + nguoidung.NhanVienBanHang + "AND DaXoa=0";
            DataTable result = DataProvider.ExecuteQuerry(querry);
            NguoiDungDTO dangnhap = new NguoiDungDTO();
            if (result.Rows.Count == 0)
            {
                return null;
            }
            dangnhap.Id = result.Rows[0]["Id"].ToString();
            dangnhap.HoTen = result.Rows[0]["HoTen"].ToString();
            dangnhap.MatKhau = result.Rows[0]["MatKhau"].ToString();
            dangnhap.TenDangNhap = result.Rows[0]["TenDangNhap"].ToString();
            dangnhap.DaXoa = result.Rows[0]["DaXoa"].ToString();
            dangnhap.QuanLi = result.Rows[0]["QuanLi"].ToString();
            dangnhap.NhanVienBanHang = result.Rows[0]["NhanVienBanHang"].ToString();
            dangnhap.NhanVienNhapKho = result.Rows[0]["NhanVienNhapKho"].ToString();
            return dangnhap;
        }
    }
}
