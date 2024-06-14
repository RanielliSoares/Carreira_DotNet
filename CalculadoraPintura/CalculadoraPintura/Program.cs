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
            Console.WriteLine("Qual a largura do cômodo em Mts?");
            double largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Qual a profundidade do cômodo em Mts?");
            double profundidade = double.Parse(Console.ReadLine());
            
            Console.WriteLine("A área das Paredes é: ");
            const double Altura = 2.9;

            Calculadora calculadora = new Calculadora();
            Console.WriteLine(calculadora.CalcularAreaParedes(largura, profundidade, Altura) + " Mts");

            Console.WriteLine("A área do teto é: ");
            Console.WriteLine(calculadora.CalcularAreaTeto(largura, profundidade) + " Mts");

            Console.WriteLine("A quantidade de tinta necessária é: ");
            Console.WriteLine(calculadora.CalcularLitros() + " Litros");

            Console.ReadLine();

        }
    }
}