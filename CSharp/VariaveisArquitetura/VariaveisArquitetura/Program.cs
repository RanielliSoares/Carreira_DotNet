using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /***  Tipos de variáveis **
            int = 10,20,30,40,50
            float = 10.2, 20.5, 15.7
            string = palavra
            char = caractere unico = o
            bool = 0 ou 1 
            */

            int numero = 10;

            float dinheiro = 2.5f;

            string nome = "José";
            char caractere = 'A';


            Console.WriteLine(numero);
            Console.WriteLine(dinheiro);
            Console.WriteLine(nome);
            Console.WriteLine(caractere);

        }
    }
}