using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projecto11_ClaseMath
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM1;
            string linea;
            long RESUL;
            Console.Write("DIGITE UN NUMERO :");
            linea = Console.ReadLine();
            NUM1 = int.Parse(linea);
            RESUL = Math.Abs(NUM1);
            Console.WriteLine("valor absoluto : " + RESUL);
            Console.WriteLine("Potencia : " + Math.Pow(NUM1, 3));
            Console.WriteLine("raiz cuadrada : " + Math.Sqrt(NUM1));
            Console.WriteLine("SENO : " + Math.Sin(NUM1 * Math.PI / 180));
            Console.WriteLine("Coseno :" + Math.Cos(NUM1 * Math.PI / 180));
            Console.WriteLine("tangente : " + Math.Tan(NUM1 * Math.PI / 180));
            Console.WriteLine("Numero maximo : " + Math.Max(NUM1, 50));
            Console.WriteLine("Numero minimo : " + Math.Min(NUM1, 50));
            Console.WriteLine("Parte entera : " + Math.Truncate(18.78));
            Console.WriteLine("Redondeo de numero : " + Math.Round(18.78));

            Console.ReadLine();
        }
    }
}
