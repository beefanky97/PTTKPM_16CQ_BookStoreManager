using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaoCaoSachTonDTO
    {
        private string id;
        private string ngaylap;
        private string soluong;
        private List<SachDTO> sach;
        public string Id { get => id; set => id = value; }
        public string NgayLap { get => ngaylap; set => ngaylap = value; }
        public string SoLuong { get => soluong; set => soluong = value; }
        public List<SachDTO> Sach { get => sach; set => sach = value; }
    }
}
