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
        public static List<TacGiaDTO> getAllAuthors() => TacGiaDAO.getAllAuthors();
        public static string addAuthor(string name) => TacGiaDAO.addAuthor(name);
    }
}
