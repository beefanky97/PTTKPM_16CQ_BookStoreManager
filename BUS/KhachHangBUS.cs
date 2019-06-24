using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class KhachHangBUS
    {
        public static int addCustomer(KhachHangDTO customer)
        {
            int result = 0;
            if (customer.CongNo == null)
            {
                result = KhachHangDAO.addCustomer(customer);
            }
            else
            {
                string id = CongNoDAO.addDeb(customer.CongNo);
                customer.CongNo.Id = id;
                result = KhachHangDAO.addCustomer(customer);
            }
            return result;
        }
        public static int checkDeb(string Name, string Phone)
        {
            KhachHangDTO customer = KhachHangDAO.getCustomer(Name, Phone);
            if (customer == null)
            {
                return 0;
            }
            else
            {
                if (customer.CongNo == null)
                {
                    return 3;
                }
                int nodau = int.Parse(customer.CongNo.NoDau);
                if (nodau < 20000)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        public static KhachHangDTO GetCustomer(string name, string phone) => KhachHangDAO.getCustomer(name, phone);
    }
}
