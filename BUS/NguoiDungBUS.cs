using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class NguoiDungBUS
    {
        public static NguoiDungDTO Login(NguoiDungDTO nguoidung)
        {
            return NguoiDungDAO.Login(nguoidung);
        }
    }
}
