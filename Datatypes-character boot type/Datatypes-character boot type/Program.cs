using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatypes_character_boot_type
{
    class Program
    {
        static void Main(string[] args)
        {
            int charMin = char.MinValue;
            int charMax = char.MaxValue;
            char Myvar = 'G';
            Console.WriteLine("Min char ={0} Max char ={1} My character ={2}",charMin,charMax,Myvar);
            Console.ReadKey();
        }
    }
}
