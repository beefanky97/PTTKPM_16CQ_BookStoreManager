using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SachDTO
    {
        private string id;
        private string tensach;
        private string tacgia;
        private string theloai;
        private string dongia;
        private string luongton;
        public string Id { get => id; set => id = value; }
        public string TenSach { get => tensach; set => tensach = value; }
        public string TacGia { get => tacgia; set => tacgia = value; }
        public string TheLoai { get => theloai; set => theloai = value; }
        public string DonGia { get => dongia; set => dongia = value; }
        public string LuongTon { get => luongton; set => luongton = value; }
    }
}
