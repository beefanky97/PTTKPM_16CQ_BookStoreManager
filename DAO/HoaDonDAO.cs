using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAO
{
    public class HoaDonDAO
    {
        public static int AddBill(HoaDonDTO bill)
        {
            string querry1 = @"INSERT INTO HoaDon (Ngay, ThanhTien, SoTienThanhToan) VALUES
('" + bill.Ngay + "', '" + bill.ThanhTien + "', '" + bill.SoTienThanhToan + "')";
            int result = DataProvider.ExecuteNonQuerry(querry1);
            if (result <= 0) return 0;
            string querry2 = @"SELECT IDENT_CURRENT('HoaDon') AS Id";
            string id = DataProvider.ExecuteQuerry(querry2).Rows[0]["Id"].ToString();
            foreach (SachDTO item in bill.Sach)
            {
                string querry = @"INSERT INTO Sach_HoaDon (SoLuong, HoaDon, Sach) VALUES (" + item.LuongTon + "," + id +
                                "," + item.Id + ")";
                int res = DataProvider.ExecuteNonQuerry(querry);
                if (result <= 0) return 0;
            }
            return 1;
        }
    }
}
