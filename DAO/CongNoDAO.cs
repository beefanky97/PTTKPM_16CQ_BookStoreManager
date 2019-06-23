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
        public static int AddDeb(CongNoDTO deb)
        {
            string querry = @"INSERT INTO CongNo (NoDau, NoCuoi, PhatSinh) VALUES (" + deb.NoDau + ", " + deb.NoCuoi +
                            ", " + deb.PhatSinh + ")";
            int result = DataProvider.ExecuteNonQuerry(querry);
            return result;
        }
    }
}
