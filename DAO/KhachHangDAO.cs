﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAO
{
    public class KhachHangDAO
    {
        public static int addCustomer(KhachHangDTO customer)
        {
            string querry = "";
            if (customer.CongNo == null)
            {
                querry = @"INSERT INTO KhachHang(TenKH, DiaChi, SDT, Email) VALUES (N'" + customer.TenKH + "', '" +
                         customer.DiaChi + "', '" + customer.SDT + "', '" +
                         customer.Email + "')";
            }
            else
            {
                querry = @"INSERT INTO KhachHang(TenKH, DiaChi, SDT, Email, CongNo) VALUES (N'" + customer.TenKH +
                         "', '" + customer.DiaChi + "', '" + customer.SDT + "', '" +
                         customer.Email + "'," + customer.CongNo.Id + ")";
            }
            int result = DataProvider.ExecuteNonQuerry(querry);
            return result;
        }
        public static KhachHangDTO getCustomer(string Name, string Phone)
        {
            string querry = @"SELECT KhachHang.Id, TenKH, DiaChi, SDT, Email, CongNo, NoDau, NoCuoi, PhatSinh FROM KhachHang INNER JOIN CongNo ON CongNo.Id = KhachHang.CongNo WHERE TenKH = N'" + Name + "' AND SDT = '" + Phone + "'";
            DataTable table = DataProvider.ExecuteQuerry(querry);
            KhachHangDTO result = new KhachHangDTO();
            result.CongNo = new CongNoDTO();
            if (table.Rows.Count > 0)
            {
                result.TenKH = table.Rows[0]["TenKH"].ToString();
                result.Id = table.Rows[0]["Id"].ToString();
                result.DiaChi = table.Rows[0]["DiaChi"].ToString();
                result.SDT = table.Rows[0]["SDT"].ToString();
                result.CongNo.Id = table.Rows[0]["CongNo"].ToString();
                result.CongNo.NoDau = table.Rows[0]["NoDau"].ToString();
                result.CongNo.NoCuoi = table.Rows[0]["NoCuoi"].ToString();
                result.CongNo.PhatSinh = table.Rows[0]["PhatSinh"].ToString();
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
