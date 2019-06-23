using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HoaDonDTO
    {
        private string id;
        private string ngay;
        private string thanhtien;
        private string sotienthanhtoan;
        private List<SachDTO> sach = new List<SachDTO>();
        public string Id { get => id; set => id = value; }
        public string Ngay { get => ngay; set => ngay = value; }
        public string ThanhTien { get => thanhtien; set => thanhtien = value; }
        public string SoTienThanhToan { get => sotienthanhtoan; set => sotienthanhtoan = value; }
        public List<SachDTO> Sach { get => sach; set => sach = value; }
    }
}
