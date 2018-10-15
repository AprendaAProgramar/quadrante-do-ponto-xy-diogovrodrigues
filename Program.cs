using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
           double x,y;
            Console.WriteLine("Insira o X");
          x=  Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o Y");
           y= Convert.ToDouble(Console.ReadLine());

           if (x > 0 && y > 0)
               Console.WriteLine("1º Quadrante");
           if (x < 0 && y > 0)
               Console.WriteLine("2º Quadrante");
           if (x < 0 && y < 0)
               Console.WriteLine("3º Quadrante");
           if (x > 0 && y < 0)
               Console.WriteLine("4º Quadrante");
        
        }
    }
}
