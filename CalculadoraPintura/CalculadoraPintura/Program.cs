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
            Console.WriteLine("Qual a largura do cômodo?");
             double largura = double.Parse(Console.ReadLine());

             Console.WriteLine("Qual a profundidade do cômodo?");
             double profundidade = double.Parse(Console.ReadLine());

             Console.WriteLine("A área das Paredes é: ");
             Console.WriteLine(2 * (largura + profundidade) * altura);

             Console.WriteLine("A área do teto é: ");
             Console.WriteLine(largura * profundidade);

             Console.ReadLine();

        }
    }
}