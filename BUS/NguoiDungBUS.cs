using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class NguoiDungBUS
    {
        public static NguoiDungDTO Login(NguoiDungDTO nguoidung) => NguoiDungDAO.Login(nguoidung);
        public static List<NguoiDungDTO> GetAll() => NguoiDungDAO.getAll();
        public static int AddEmployee(NguoiDungDTO employee)
        {
            if (employee.NhanVienBanHang == "True")
            {
                employee.NhanVienBanHang = "1";
                employee.NhanVienNhapKho = "0";
                employee.QuanLi = "0";
            }
            if (employee.NhanVienNhapKho == "True")
            {
                employee.NhanVienBanHang = "0";
                employee.NhanVienNhapKho = "1";
                employee.QuanLi = "0";
            }
            if (employee.QuanLi == "True")
            {
                employee.NhanVienBanHang = "0";
                employee.NhanVienNhapKho = "0";
                employee.QuanLi = "1";
            }
            return NguoiDungDAO.addEmployee(employee);
        }
        public static int EditEmployee(NguoiDungDTO employee)
        {
            if (employee.NhanVienBanHang == "True")
            {
                employee.NhanVienBanHang = "1";
                employee.NhanVienNhapKho = "0";
                employee.QuanLi = "0";
            }
            if (employee.NhanVienNhapKho == "True")
            {
                employee.NhanVienBanHang = "0";
                employee.NhanVienNhapKho = "1";
                employee.QuanLi = "0";
            }
            if (employee.QuanLi == "True")
            {
                employee.NhanVienBanHang = "0";
                employee.NhanVienNhapKho = "0";
                employee.QuanLi = "1";
            }
            return NguoiDungDAO.editEmployee(employee);
        }
    }
}
