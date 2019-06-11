using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguoiDungDTO
    {
        private string id;
        private string email;
        private string matkhau;
        private string hoten;
        private string tendangnhap;
        private string daxoa = "0";
        private string quanli = "0";
        private string nhanviennhapkho = "0";
        private string nhanvienbanhang = "0";

        public string Id { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
        public string MatKhau { get => matkhau; set => matkhau = value; }
        public string HoTen { get => hoten; set => hoten = value; }
        public string TenDangNhap { get => tendangnhap; set => tendangnhap = value; }
        public string DaXoa { get => daxoa; set => daxoa = value; }
        public string QuanLi { get => quanli; set => quanli = value; }
        public string NhanVienBanHang { get => nhanvienbanhang; set => nhanvienbanhang = value; }
        public string NhanVienNhapKho { get => nhanviennhapkho; set => nhanviennhapkho = value; }
    }
}
