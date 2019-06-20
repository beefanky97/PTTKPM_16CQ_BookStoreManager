using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHangDTO
    {
        private string id;
        private string tenkh;
        private string diachi;
        private string sdt;
        private string email;
        private CongNoDTO congno;
        public string Id { get => id; set => id = value; }
        public string TenKH { get => tenkh; set => tenkh = value; }
        public string DiaChi { get => diachi; set => diachi = value; }
        public string SDT { get => sdt; set => sdt = value; }
        public string Email { get => email; set => email = value; }
        public CongNoDTO CongNo { get => congno; set => congno = value; }
    }
}
