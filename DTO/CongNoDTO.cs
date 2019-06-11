using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CongNoDTO
    {
        private string id;
        private string nodau;
        private string nocuoi;
        private string phatsinh;
        public string Id { get => id; set => id = value; }
        public string NoDau { get => nodau; set => nodau = value; }
        public string NoCuoi { get => nocuoi; set => nocuoi = value; }
        public string PhatSinh { get => phatsinh; set => phatsinh = value; }
    }
}
