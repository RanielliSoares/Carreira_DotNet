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
            Calculadora calculadora = new Calculadora();

            const double Altura = 2.9;

            Console.WriteLine("Qual a largura do cômodo em Mts?");
            double largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a profundidade do cômodo em Mts?");
            double profundidade = double.Parse(Console.ReadLine());

            Console.WriteLine("A área das Paredes é: ");
            calculadora.areaParedes = (2 * (largura + profundidade) * Altura);
            Console.WriteLine(calculadora.areaParedes + " Mts");

            Console.WriteLine("A área do teto é: ");
            calculadora.areaTeto = (largura * profundidade);
            Console.WriteLine(calculadora.areaTeto + " Mts");

            Console.WriteLine("A quantidade de tinta necessária é: ");
            Console.WriteLine((calculadora.areaTeto + calculadora.areaParedes) / 10 + " Litros");

            Console.ReadLine();

        }
    }
}