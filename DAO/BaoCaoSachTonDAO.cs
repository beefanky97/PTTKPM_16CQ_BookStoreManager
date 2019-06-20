﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAO
{
    public class BaoCaoSachTonDAO
    {
        public static List<BaoCaoSachTonDTO> GetAllData()
        {
            string querry = @"SELECT Sach.Id AS SachId, BaoCaoSachTon.Id AS BaoCaoId, TenSach, DonGia, LuongTon, NgayLap, SoLuong, TenTacGia, TenTheLoai FROM Sach INNER JOIN Sach_BaoCao ON Sach_BaoCao.Sach = Sach.Id INNER JOIN BaoCaoSachTon ON BaoCaoSachTon.Id = Sach_BaoCao.BaoCao INNER JOIN TheLoai ON TheLoai.Id = Sach.TheLoai INNER JOIN TacGia ON TacGia.Id = Sach.TacGia";
            DataTable table = DataProvider.ExecuteQuerry(querry);
            List<BaoCaoSachTonDTO> result = new List<BaoCaoSachTonDTO>();
            if (table.Rows.Count <= 0)
            {
                return null;
            } else
            {
                string last = "0";
                int i = 0;
                while (i < table.Rows.Count)
                {
                    BaoCaoSachTonDTO item = new BaoCaoSachTonDTO();
                    item.Id = table.Rows[i]["BaoCaoId"].ToString();
                    item.NgayLap = table.Rows[i]["NgayLap"].ToString();
                    item.SoLuong = table.Rows[i]["SoLuong"].ToString();
                    last = item.Id;
                    item.Sach = new List<SachDTO>();
                    while (table.Rows[i]["BaoCaoId"].ToString() == last)
                    {
                        SachDTO sach = new SachDTO();
                        sach.Id = table.Rows[i]["SachId"].ToString();
                        sach.TenSach = table.Rows[i]["TenSach"].ToString();
                        sach.LuongTon = table.Rows[i]["LuongTon"].ToString();
                        sach.DonGia = table.Rows[i]["DonGia"].ToString();
                        sach.TenTacGia = table.Rows[i]["TenTacGia"].ToString();
                        sach.TenTheLoai = table.Rows[i]["TenTheLoai"].ToString();
                        item.Sach.Add(sach);
                        i++;
                        if (i >= table.Rows.Count)
                        {
                            break;
                        }
                    }
                    result.Add(item);
                }
            }
            return result;
        }
    }
}