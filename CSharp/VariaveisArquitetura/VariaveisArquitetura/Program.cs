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

            //Console.WriteLine(numero);
            //Console.WriteLine(dinheiro);
            //Console.WriteLine(nome);
            //Console.WriteLine(caractere);


            /*********************************************/
            /* Operadores Aritméticos */

            Console.WriteLine("Escreva um número: ");
            int numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escreva um número: ");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            int soma = numero1 + numero2;
            int subtracao = numero1 - numero2;
            int divisao = numero1 / numero2;
            int mult = numero1 * numero2;
            Console.WriteLine("Total Soma: " + soma);
            Console.WriteLine("Total Subt: " + subtracao);
            Console.WriteLine("Total Divs: " + divisao);
            Console.WriteLine("Total Mult: " + mult);

            /*************************************************/
            /*Operadores condicionais*/
        }
    }
}