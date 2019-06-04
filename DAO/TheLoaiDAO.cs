using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DAO
{
    public class TheLoaiDAO
    {
        public static List<TheLoaiDTO> GetAllCategories()
        {
            string querry = "SELECT * FROM TheLoai";
            DataTable table = DataProvider.ExecuteQuerry(querry);
            List<TheLoaiDTO> result = new List<TheLoaiDTO>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                TheLoaiDTO item = new TheLoaiDTO();
                item.Id = table.Rows[i]["Id"].ToString();
                item.TenTheLoai = table.Rows[i]["TenTheLoai"].ToString();
                result.Add(item);
            }
            return result;
        }
    }
}
