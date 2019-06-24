using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
