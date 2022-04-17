using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiposPredefinidos
{
    class Program
    {
        static void Main(string[] args)
        {
            int entero = 100;
            short s = 140;
            byte b= 10;
            long largo = 32322223;

            

            float f = 123.5f;
            double d = 3.14159;
            decimal dec = 129.99m;

            Console.WriteLine("float: {0}, decimal:{1}", f, dec);


            char c = 'E';
            bool booleano = true;

            Console.Write("char: {0}", c);
            Console.WriteLine("bool:{0}", booleano);

        }
    }
}
