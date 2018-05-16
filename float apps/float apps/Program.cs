using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace float_apps
{
    class Program
    {
        static void Main(string[] args)
        {
            float flMin = float.MinValue;
            float flMax = float.MaxValue;
            Console.WriteLine("Min value ={0} Max value ={1}", flMin, flMax);
            float flvar = 1F / 3;
            Double dlvar = 1D / 3;
            Decimal dcvar = 1M / 3;
            Console.WriteLine("float value ={0}\n double value ={1}\n decimal ={2}\n", flvar, dlvar, dcvar);
      
            Console.ReadKey();
        }
    }
}
