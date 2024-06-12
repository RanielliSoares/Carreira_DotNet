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
            double altura = 3;

            Console.WriteLine("Qual a largura do cômodo em Mts?");
            double largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a profundidade do cômodo em Mts?");
            double profundidade = double.Parse(Console.ReadLine());

            Console.WriteLine("A área das Paredes é: ");
            double areaParedes = (2 * (largura + profundidade) * altura);
            Console.WriteLine(areaParedes);

            Console.WriteLine("A área do teto é: ");
            double areaTeto = (largura * profundidade);
            Console.WriteLine(areaTeto);

            Console.ReadLine();

        }
    }
}