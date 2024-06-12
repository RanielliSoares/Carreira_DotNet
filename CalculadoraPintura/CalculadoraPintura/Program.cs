using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraPintura
{
    class Program
    {
        static void Main(string[] args)
        {
            const double Altura = 2.9;

            Console.WriteLine("Qual a largura do cômodo em Mts?");
            double largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a profundidade do cômodo em Mts?");
            double profundidade = double.Parse(Console.ReadLine());

            Console.WriteLine("A área das Paredes é: ");
            double areaParedes = (2 * (largura + profundidade) * Altura);
            Console.WriteLine(areaParedes + " Mts");

            Console.WriteLine("A área do teto é: ");
            double areaTeto = (largura * profundidade);
            Console.WriteLine(areaTeto + " Mts");

            Console.WriteLine("A quantidade de tinta necessária é: ");
            Console.WriteLine((areaTeto + areaParedes) / 10 + " Litros");

            Console.ReadLine();

        }
    }
}