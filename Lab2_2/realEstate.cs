﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2_2
{
    class realEstate : insuranceLiabilities 
    {
        public realEstate(string a, int b, int c)
        {
            Name = a;
            risk = b;
            price = c;
        }
    }
}
