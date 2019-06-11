using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TacGiaDTO
    {
         private string id;
        private string tentacgia;
        private string namsinh;
        private string ghichu;
        public string Id { get => id; set => id = value; }
        public string TenTacGia { get => tentacgia; set => tentacgia = value; }
        public string NamSinh { get => namsinh; set => namsinh = value; }
        public string GhiChu { get => ghichu; set => ghichu = value; }
    }
}
