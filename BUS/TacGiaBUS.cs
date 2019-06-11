using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class TacGiaBUS
    {
        public static List<TacGiaDTO> getAllAuthors()
        {
            return TacGiaDAO.getAllAuthors();
        }
    }
}
