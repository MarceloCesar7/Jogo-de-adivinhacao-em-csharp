using System;

namespace JogoAdivinhacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int numeroAdivinhar = random.Next(1, 101); // Gera um número aleatório entre 1 e 100

            Console.WriteLine("Bem-vindo ao jogo de adivinhação!");
            Console.WriteLine("Tente adivinhar o número entre 1 e 100.");

            bool acertou = false;
            int tentativas = 0;

            while (!acertou)
            {
                Console.Write("Digite o seu palpite: ");
                int palpite = Convert.ToInt32(Console.ReadLine());
                tentativas++;

                if (palpite == numeroAdivinhar)
                {
                    Console.WriteLine("Parabéns, você acertou o número!");
                    Console.WriteLine("Total de tentativas: " + tentativas);
                    acertou = true;
                }
                else if (palpite < numeroAdivinhar)
                {
                    Console.WriteLine("Tente um número maior!");
                }
                else
                {
                    Console.WriteLine("Tente um número menor!");
                }
            }

            Console.WriteLine("Obrigado por jogar. Pressione qualquer tecla para sair.");
            Console.ReadKey();
        }
    }
}
