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

        public static List<NguoiDungDTO> getAll()
        {
            string querry = @"SELECT * FROM NguoiDung WHERE DaXoa=0";
            DataTable table = DataProvider.ExecuteQuerry(querry);
            List<NguoiDungDTO> list = new List<NguoiDungDTO>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                NguoiDungDTO item = new NguoiDungDTO();
                item.TenDangNhap = table.Rows[i]["TenDangNhap"].ToString();
                item.HoTen = table.Rows[i]["HoTen"].ToString();
                item.MatKhau = table.Rows[i]["MatKhau"].ToString();
                item.Email = table.Rows[i]["Email"].ToString();
                item.QuanLi = table.Rows[i]["QuanLi"].ToString();
                item.NhanVienBanHang = table.Rows[i]["NhanVienBanHang"].ToString();
                item.NhanVienNhapKho = table.Rows[i]["NhanVienNhapKho"].ToString();
                item.DaXoa = table.Rows[i]["DaXoa"].ToString();
                item.Id = table.Rows[i]["Id"].ToString();
                list.Add(item);
            }
            return list;
        }
        public static int addEmployee(NguoiDungDTO employee)
        {
            string querry = @"INSERT INTO NguoiDung (Email, MatKhau, HoTen, TenDangNhap, DaXoa, QuanLi, NhanVienNhapKho, NhanVienBanHang) VALUES ( N'" + employee.Email + "',N'" + employee.MatKhau + "', N'" + employee.HoTen + "', N'" + employee.TenDangNhap + "', " + employee.DaXoa + ", " + employee.QuanLi + ", " + employee.NhanVienNhapKho + ", " + employee.NhanVienBanHang + ")";
            int result = DataProvider.ExecuteNonQuerry(querry);
            return result;
        }

        public static int editEmployee(NguoiDungDTO employee)
        {
            string querry = @"UPDATE NguoiDung SET Email = N'" + employee.Email + "', MatKhau = N'" + employee.MatKhau + "', HoTen = N'" + employee.HoTen + "', TenDangNhap = N'" + employee.TenDangNhap + "', DaXoa = " + employee.DaXoa + ", QuanLi = " + employee.QuanLi + ", NhanVienNhapKho = " + employee.NhanVienNhapKho + ", NhanVienBanHang = " + employee.NhanVienBanHang + " WHERE Id = " + employee.Id;
            int result = DataProvider.ExecuteNonQuerry(querry);
            return result;
        }
    }
}
