using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class SachDAO
    {
        public static List<SachDTO> GetAllData()
        {
            string querry = @"SELECT Sach.Id, TenSach, TenTheLoai, TenTacGia, DonGia, LuongTon FROM Sach LEFT JOIN TheLoai ON TheLoai.Id = Sach.TheLoai LEFT JOIN  TacGia ON TacGia.Id = Sach.TacGia";
            DataTable table = DataProvider.ExecuteQuerry(querry);
            if (table.Rows.Count == 0)
            {
                return null;
            }
            List<SachDTO> result = new List<SachDTO>();
            for (int i = 0 ; i < table.Rows.Count ; i++)
            {
                SachDTO sach = new SachDTO();
                sach.Id = table.Rows[i]["Id"].ToString();
                sach.TenSach = table.Rows[i]["TenSach"].ToString();
                sach.TenTacGia = table.Rows[i]["TenTacGia"].ToString();
                sach.TenTheLoai = table.Rows[i]["TenTheLoai"].ToString();
                sach.DonGia = table.Rows[i]["DonGia"].ToString();
                sach.LuongTon = table.Rows[i]["LuongTon"].ToString();
                result.Add(sach);
            }
            return result;
        }
        public static List<SachDTO> GetBookByCategory(TheLoaiDTO theloai)
        {
            string querry = @"SELECT Sach.Id, TenSach, TenTheLoai, TenTacGia, DonGia, LuongTon FROM Sach INNER JOIN TheLoai ON TheLoai.Id = Sach.TheLoai INNER JOIN  TacGia ON TacGia.Id = Sach.TacGia WHERE TheLoai.Id = " + theloai.Id;
            DataTable table = DataProvider.ExecuteQuerry(querry);
            if (table.Rows.Count == 0)
            {
                return null;
            }
            List<SachDTO> result = new List<SachDTO>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                SachDTO sach = new SachDTO();
                sach.Id = table.Rows[i]["Id"].ToString();
                sach.TenSach = table.Rows[i]["TenSach"].ToString();
                sach.TenTacGia = table.Rows[i]["TenTacGia"].ToString();
                sach.TenTheLoai = table.Rows[i]["TenTheLoai"].ToString();
                sach.DonGia = table.Rows[i]["DonGia"].ToString();
                sach.LuongTon = table.Rows[i]["LuongTon"].ToString();
                result.Add(sach);
            }
            return result;
        }

        public static List<SachDTO> GetBookByAuthor(TacGiaDTO tacgia)
        {
            string querry = @"SELECT Sach.Id, TenSach, TenTheLoai, TenTacGia, DonGia, LuongTon FROM Sach INNER JOIN TheLoai ON TheLoai.Id = Sach.TheLoai INNER JOIN  TacGia ON TacGia.Id = Sach.TacGia WHERE TacGia.Id = " + tacgia.Id;
            DataTable table = DataProvider.ExecuteQuerry(querry);
            if (table.Rows.Count == 0)
            {
                return null;
            }
            List<SachDTO> result = new List<SachDTO>();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                SachDTO sach = new SachDTO();
                sach.Id = table.Rows[i]["Id"].ToString();
                sach.TenSach = table.Rows[i]["TenSach"].ToString();
                sach.TenTacGia = table.Rows[i]["TenTacGia"].ToString();
                sach.TenTheLoai = table.Rows[i]["TenTheLoai"].ToString();
                sach.DonGia = table.Rows[i]["DonGia"].ToString();
                sach.LuongTon = table.Rows[i]["LuongTon"].ToString();
                result.Add(sach);
            }
            return result;
        }

        public static int addBook(SachDTO book)
        {
            string querry = @"INSERT INTO dbo.Sach(TenSach,TacGia,TheLoai,DonGia,LuongTon) VALUES (N'" + book.TenSach + "', " + book.TenTacGia + "," + book.TenTheLoai + "," + book.DonGia + "," + book.LuongTon + ")";
            int result = DataProvider.ExecuteNonQuerry(querry);
            return result;
        }

        public static int changeAmount(SachDTO book)
        {
            string querry = @"UPDATE Sach SET LuongTon = " + book.LuongTon + " WHERE Id = " + book.Id;
            int result = DataProvider.ExecuteNonQuerry(querry);
            return result;
        }

        public static int findAmount(SachDTO book)
        {
            string querry = @"SELECT * FROM Sach WHERE Id=" + book.Id;
            DataTable table = DataProvider.ExecuteQuerry(querry);
            return int.Parse(table.Rows[0]["LuongTon"].ToString());
        }
    }
}
