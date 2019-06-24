using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAO
{
    public class QuyDinhDAO
    {
        public static List<QuyDinhDTO> getAll()
        {
            string querry = @"SELECT * FROM QuyDinh";
            DataTable table = DataProvider.ExecuteQuerry(querry);
            List<QuyDinhDTO> list = new List<QuyDinhDTO>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                QuyDinhDTO quydinh = new QuyDinhDTO();
                quydinh.Id = table.Rows[i]["Id"].ToString();
                quydinh.TenQuyDinh = table.Rows[i]["TenQuyDinh"].ToString();
                quydinh.GiaTri = table.Rows[i]["GiaTri"].ToString();
                quydinh.TinhTrang = table.Rows[i]["TinhTrang"].ToString();
                list.Add(quydinh);
            }
            return list;
        }
        public static int updateRule(QuyDinhDTO quydinh)
        {
            string querry = @"UPDATE QuyDinh SET GiaTri = " + quydinh.GiaTri + " WHERE Id=" + quydinh.Id;
            int result = DataProvider.ExecuteNonQuerry(querry);
            return result;
        }
    }
}
