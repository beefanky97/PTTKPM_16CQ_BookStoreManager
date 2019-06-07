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
        private string tentacgia;
        private string tentheloai;
        private string dongia;
        private string luongton;
        public string Id { get => id; set => id = value; }
        public string TenSach { get => tensach; set => tensach = value; }
        public string TenTacGia { get => tentacgia; set => tentacgia = value; }
        public string TenTheLoai { get => tentheloai; set => tentheloai = value; }
        public string DonGia { get => dongia; set => dongia = value; }
        public string LuongTon { get => luongton; set => luongton = value; }
    }
}
