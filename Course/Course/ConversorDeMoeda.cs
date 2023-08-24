using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    internal class ConversorDeMoeda
    {
        static double Iof = 6.0;

        public static double CotacaoDolar;
        public static double TotalDolar;

        public static double ValorPago()
        {

           double Total = TotalDolar * CotacaoDolar;

            return Total + ((Total * Iof) / 100) ;

        }

}
}
