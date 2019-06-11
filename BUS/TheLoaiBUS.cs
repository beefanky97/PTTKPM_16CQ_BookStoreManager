using DTO;
using DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class TheLoaiBUS
    {
        public static List<TheLoaiDTO> GetAllCategories()
        {
            return TheLoaiDAO.GetAllCategories();
        }
    }
}
