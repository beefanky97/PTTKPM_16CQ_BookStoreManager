using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore_WPF
{
    public class MiddleDebtors
    {
        private string id;
        private string ngaylap;
        private string idKhachHang;
        private string tenKhachHang;
        private string diachi;
        private string sdt;
        private string idNo;
        private string nodau;
        private string nocuoi;
        private string phatsinh;
        public string Id { get => id; set => id = value; }
        public string NgayLap { get => ngaylap; set => ngaylap = value; }
        public string IdKhachHang { get => idKhachHang; set => idKhachHang = value; }
        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        public string DiaChi { get => diachi; set => diachi = value; }
        public string SDT { get => sdt; set => sdt = value; }
        public string IdNo { get => idNo; set => idNo = value; }
        public string NoDau { get => nodau; set => nodau = value; }
        public string NoCuoi { get => nocuoi; set => nocuoi = value; }
        public string PhatSinh { get => phatsinh; set => phatsinh = value; }
    }
}
