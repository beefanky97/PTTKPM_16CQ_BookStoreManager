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
        public static List<TheLoaiDTO> getAllCategories() => TheLoaiDAO.getAllCategories();
        public static string addCategory(string name) => TheLoaiDAO.addCategory(name);
    }
}
