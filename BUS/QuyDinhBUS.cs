using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class QuyDinhBUS
    {
        public static List<QuyDinhDTO> GetAll() => QuyDinhDAO.getAll();
        public static int UpdateRule(QuyDinhDTO rule) => QuyDinhDAO.updateRule(rule);
    }
}
