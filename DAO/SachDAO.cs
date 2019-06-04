﻿using System;
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
            string querry = "SELECT Sach.Id, Sach.TenSach, Sach.TacGia, TheLoai.TenTheLoai, Sach.DonGia, Sach.LuongTon, TenTheLoai FROM Sach INNER JOIN TheLoai ON TheLoai.Id = Sach.TheLoai";
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
                sach.TacGia = table.Rows[i]["TacGia"].ToString();
                sach.TenTheLoai = table.Rows[i]["TenTheLoai"].ToString();
                sach.DonGia = table.Rows[i]["DonGia"].ToString();
                sach.LuongTon = table.Rows[i]["LuongTon"].ToString();
                result.Add(sach);
            }
            return result;
        }
    }
}
