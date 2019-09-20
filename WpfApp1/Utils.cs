using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Utils
    {



        public static double calculMedie(List<int> numere)
        {

            //float ret = 0;
            //int n = 0;
            //foreach (int nr in numere)
            //{
            //    ret += nr;
            //    n++;
            //}
            double ret = numere.Average();
            return ret ;
        }

        






    }
}
