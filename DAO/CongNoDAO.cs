using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAO
{
    public class CongNoDAO
    {
        public static string addDeb(CongNoDTO deb)
        {
            string querry = @"INSERT INTO CongNo (NoDau, NoCuoi, PhatSinh) VALUES (" + deb.NoDau + ", " + deb.NoCuoi +
                            ", " + deb.PhatSinh + ")";
            int result = DataProvider.ExecuteNonQuerry(querry);
            querry = @"SELECT IDENT_CURRENT('CongNo') AS Id";
            string id = DataProvider.ExecuteQuerry(querry).Rows[0]["Id"].ToString();
            return id;
        }
        public static int updateDeb(CongNoDTO deb)
        {
            string querry = @"UPDATE CongNo SET NoDau=" + deb.NoDau + ", NoCuoi=" + deb.NoCuoi + ", PhatSinh="+ deb.PhatSinh + "WHERE Id=" + deb.Id;
            int result = DataProvider.ExecuteNonQuerry(querry);
            return result;
        }
        public static CongNoDTO getDeb(string Id)
        {
            string querry = @"SELECT * FROM CongNo WHERE Id=" + Id;
            DataTable table = DataProvider.ExecuteQuerry(querry);
            CongNoDTO result = new CongNoDTO();
            result.Id = table.Rows[0]["Id"].ToString();
            result.NoDau = table.Rows[0]["NoDau"].ToString();
            result.NoCuoi = table.Rows[0]["NoCuoi"].ToString();
            result.PhatSinh = table.Rows[0]["PhatSinh"].ToString();
            return result;
        }
    }
}
