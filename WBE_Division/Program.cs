﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WBE_Division
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        static int Division(int numerator, int denominator)
        {
            int result = 0;
            while(numerator >= denominator)
            {
                numerator -= denominator;
                result++;
            }
            return result;
        }
    }
}
