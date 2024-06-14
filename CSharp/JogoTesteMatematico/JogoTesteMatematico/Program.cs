using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Escreva seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine(" ***** Bem vindo " + nome + " *****\n");
            Console.WriteLine(" O jogo tem um total de 5 pergutas, no final será somado os seus pontos e se acertar até 4 perguntas você vence o jogo!! \n");

            Console.WriteLine("João tem R$ 1.120 e recebe no dia 30 de seu serviço o pagamento de R$ 2.140 ");
            Console.WriteLine("Qual o valor total de joão ? ");
            int R1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nMaria tem 120 pirulitos e terá que dividir entre seus 5 irmãos. ");
            Console.WriteLine("Quantos pirulitos cada um irá receber? ");
            int R2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPedro viu uma camisa com o preço de R$100 mas ao chegar no caixa a atendente lhe informa que recebeu um desconto de 25%");
            Console.WriteLine("Quanto Pedro irá pagar em sua camiseta? ");
            int R3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nAlice precisa fazer uma viagem de 250Km, sabendo que seu carro faz 10Km por litro rodado. ");
            Console.WriteLine("Quantos litros serão necessário para a viagem? ");
            int R4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nRicardo tinha 98 balas, comeu 15 após o almoço, próximo da janta comeu mais 13, no dia seguite Ricardo comprou mais 47 balas.");
            Console.WriteLine("Com quantas balas Ricardo ficou ? ");
            int R5 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nCalculando resultados ... \n");

            int pontos = 0;

            if (R1 == 3260)
            {
                pontos ++;
            }
            if (R2 == 24)
            {
                pontos++;
            }
            if (R3 == 75)
            {
                pontos++;
            }
            if (R4 == 25)
            {
                pontos++;
            }
            if (R5 == 117)
            {
                pontos++;
            }

            
            if ( pontos >= 4)
            {
                Console.WriteLine("Parabéns você foi o vencedor !!");
            }
            else
            {
                Console.WriteLine("Que pena, você acertou menos de 4 questões, tente novamente!");
            }
        }
    }
}