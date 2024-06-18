using CalculadoraSigno;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //instanciando o objeto Signo
            Signo signo = new Signo();

            signo.caracteristicas = "Você é legal";
            Console.WriteLine(signo.caracteristicas);
        }
    }
}