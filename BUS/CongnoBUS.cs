﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAO;
using DTO;

namespace BUS
{
    public class CongnoBUS
    {
        public static string addDeb(CongNoDTO congno) => CongNoDAO.addDeb(congno);
    }
}
