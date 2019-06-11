using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TheLoaiDTO
    {
        private string id;
        private string tentheloai;
        public string Id { get => id; set => id = value; }
        public string TenTheLoai { get => tentheloai; set => tentheloai = value; }
    }
}
