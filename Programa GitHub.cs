using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp55
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, promfinal;
            Console.WriteLine("Numero 1:");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero 2:");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Numero 3:");
            n3 = int.Parse(Console.ReadLine());
            promfinal = (n1 + n2 + n3) / 3;
            Console.WriteLine("Promedio: {0}", promfinal);
            Console.ReadLine();

            if (promfinal >= 7)
            {
                Console.WriteLine("El alumno aprobo");
                Console.ReadLine();
            }
            else
            {
                    Console.WriteLine("El alumno se llevo la materia a diciembre");
                    Console.ReadLine();
                }
                


                    
                
            
        }

    }
}
