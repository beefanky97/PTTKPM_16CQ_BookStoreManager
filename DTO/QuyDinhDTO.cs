using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class QuyDinhDTO
    {
        private string id;
        private string tenquydinh;
        private string giatri;
        private string tinhtrang;
        public string Id { get => id; set => id = value; }
        public string TenQuyDinh { get => tenquydinh; set => tenquydinh = value; }
        public string GiaTri { get => giatri; set => giatri = value; }
        public string TinhTrang { get => tinhtrang; set => tinhtrang = value; }
    }
}
