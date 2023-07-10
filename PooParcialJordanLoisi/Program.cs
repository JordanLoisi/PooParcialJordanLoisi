using PooParcial.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PooParcialJordanLoisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el valor del radio ");
            double radio=double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el valor de la altura ");
            double altura = double.Parse(Console.ReadLine());

            Console.WriteLine("ingrese el valor de la generatriz");
            double generatriz = double.Parse(Console.ReadLine());

            Cono c = new Cono(altura,radio);

            Console.WriteLine($"el area es {c.GetArea()}");
            Console.WriteLine($"el volumen es {c.CalcularVolumen()}");

            Console.ReadLine();



        }
    }
}
