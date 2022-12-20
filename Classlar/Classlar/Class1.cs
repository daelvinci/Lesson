using System;
using System.Collections.Generic;
using System.Text;

namespace Classlar
{
    internal class Cars
    {
        public string Brand;
        public string Model;
        public int Year;
        public double Price;
        public double Millage;
        public double GlobalMillage;

        public void Drive (double km)
        {
            Millage += km;
            GlobalMillage += km;
           
        }

        public void ResetMillage()
        {
             Millage = 0;

        }


       
    }
}
