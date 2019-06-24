using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class BaoCaoCongNoDTO
    {
        private string id;
        private string ngaylap;
        private string idno;
        private string nodau;
        private string nocuoi;
        private string phatsinh;
        public string Id { get => id; set => id = value; }
        public string NgayLap { get => ngaylap; set => ngaylap = value; }
        public string IdNo { get => idno; set => idno = value; }
        public string NoDau { get => nodau; set => nodau = value; }
        public string NoCuoi { get => nocuoi; set => nocuoi = value; }
        public string PhatSinh { get => phatsinh; set => phatsinh = value; }
    }
}
