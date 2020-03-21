using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dairenin_Alanını_Hesaplamaaa
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.14;
            double yaricap, alan;
            Console.Write("Dairenin Yarıçapını Girin :");
            yaricap = Convert.ToDouble(Console.ReadLine());
            alan = pi * yaricap * yaricap;
            Console.Write("Yarıçapını {0} Girdiğiniz Dairenin Alanı :{1}", yaricap, alan);
            Console.ReadKey();
                
        }
    }
}
