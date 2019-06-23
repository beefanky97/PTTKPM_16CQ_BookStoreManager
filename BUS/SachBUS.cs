using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class SachBUS
    {
        public static List<SachDTO> GetAll() => SachDAO.GetAllData();
        public static List<SachDTO> GetBookByAuthor(TacGiaDTO tacgia) => SachDAO.GetBookByAuthor(tacgia);
        public static List<SachDTO> GetBookByCategory(TheLoaiDTO theloai) => SachDAO.GetBookByCategory(theloai);
        public static int AddBook(SachDTO book) => SachDAO.addBook(book);
        public static int ChangeAmount(SachDTO book) => SachDAO.changeAmount(book);
    }
}
