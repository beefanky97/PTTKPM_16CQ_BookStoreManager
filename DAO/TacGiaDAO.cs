using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class TacGiaDAO
    {
        public static List<TacGiaDTO> getAllAuthors()
        {
            string querry = "SELECT * FROM TacGia";
            DataTable table = DataProvider.ExecuteQuerry(querry);
            List<TacGiaDTO> result = new List<TacGiaDTO>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                TacGiaDTO item = new TacGiaDTO();
                item.Id = table.Rows[i]["Id"].ToString();
                item.TenTacGia = table.Rows[i]["TenTacGia"].ToString();
                item.NamSinh = table.Rows[i]["NamSinh"].ToString();
                item.GhiChu = table.Rows[i]["GhiChu"].ToString();
                result.Add(item);
            }
            return result;
        }
        public static string  addAuthor(string name)
        {
            string querry = @"INSERT INTO TacGia (TenTacGia) VALUES (N'" + name + "')";
            int result = DataProvider.ExecuteNonQuerry(querry);
            if (result > 0)
            {
                querry = @"SELECT IDENT_CURRENT('TacGia') AS Id";
                string id = DataProvider.ExecuteQuerry(querry).Rows[0]["Id"].ToString();
                return id;
            }
            else
            {
                return null;
            }
        }
    }
}
