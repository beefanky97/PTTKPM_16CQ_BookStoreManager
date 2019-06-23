using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class BaoCaoSachTonBUS
    {
        public static List<BaoCaoSachTonDTO> GetAllData() => BaoCaoSachTonDAO.GetAllData();
        public static int GenerateReport() => BaoCaoSachTonDAO.GenerateReport();
    }
}
