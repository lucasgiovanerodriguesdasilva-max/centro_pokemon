using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace centro_pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            while (opcao != 6)
            {

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(@"
██████╗░░█████╗░██╗░░██╗███████╗███╗░░░███╗░█████╗░███╗░░██╗
██╔══██╗██╔══██╗██║░██╔╝██╔════╝████╗░████║██╔══██╗████╗░██║
██████╔╝██║░░██║█████═╝░█████╗░░██╔████╔██║██║░░██║██╔██╗██║
██╔═══╝░██║░░██║██╔═██╗░██╔══╝░░██║╚██╔╝██║██║░░██║██║╚████║
██║░░░░░╚█████╔╝██║░╚██╗███████╗██║░╚═╝░██║╚█████╔╝██║░╚███║
╚═╝░░░░░░╚════╝░╚═╝░░╚═╝╚══════╝╚═╝░░░░░╚═╝░╚════╝░╚═╝░░╚══╝");
                Console.ResetColor();
                Console.WriteLine("\n 1 - cadastro de pokemon");
                Console.WriteLine("\n 2 - cadastro de pokebolas");
                Console.WriteLine("\n 3 - cadastro de treinaderes");
                Console.WriteLine("\n 4 - cadastro de cidades");
                Console.WriteLine("\n 5 - cadastro de ginásios");
                Console.WriteLine("\n 6 - sair");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n digite a opcao escolhida: ");
                Console.ResetColor();
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {

                    case 1:
                        Cadastropokemon();
                        break;
                    case 2:
                        pokebolas();
                        break;
                    case 3:
                        treine();
                        break;
                    case 4:
                        cidade();
                        break;
                    case 5:
                        ginasio();
                        break;
                    case 6:
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("opcao invalida!!");
                        Console.ResetColor();
                        Thread.Sleep(2000);  // pausa a programacao por 2 segundos 

                        break;

                }
            }
        }

        static void Cadastropokemon()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░");

            Console.ResetColor();
            Console.WriteLine("\n nome do pokemon: ");
            string nomepokemon = Console.ReadLine();
            Console.WriteLine("\n status do pokemon: ");
            string statuspokemon = Console.ReadLine();
            Console.WriteLine("\n qtd de golpes do pokemon: ");
            int qtdgoles = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtdgoles; i++)
            {
                Console.WriteLine($"\n golpes do {i} pokemon: ");
                string golpepokemon = Console.ReadLine();
            }

            Console.WriteLine("\n qtd evolucao do pokemon:");
            int qtdevolucao = int.Parse(Console.ReadLine());
            for (int i = 1; i <= qtdevolucao; i++)
            {
                Console.WriteLine($"\n golpe do{i} pokemon: ");
                string evolucaopokemon = Console.ReadLine();

            }
            Console.WriteLine("\n elemento do pokemon: ");
            string elementopokemon = Console.ReadLine();

            Console.WriteLine("\n fraqueza do pokemon: ");
            int fraquezapokemon = int.Parse(Console.ReadLine());
            for (int i = 1; i <= fraquezapokemon; i++)
            {
                Console.WriteLine("\n fraqueza {i} do pokemon: ");
                string fraqueza = Console.ReadLine();
            }
            Console.WriteLine("\n raridade do pokemon: ");
            string raridadepokemon = Console.ReadLine();
            Console.WriteLine("\n peso do pokemon: ");
            double pesopokemon = double.Parse(Console.ReadLine());
            Console.WriteLine("\n cadratro finalizado!!! ");
            Thread.Sleep(2000);

        }
        static void pokebolas()

        {


            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.BackgroundColor = ConsoleColor.Blue;

            Console.WriteLine(@"
██████╗░░█████╗░██╗░░██╗███████╗██████╗░░█████╗░██╗░░░░░░█████╗░
██╔══██╗██╔══██╗██║░██╔╝██╔════╝██╔══██╗██╔══██╗██║░░░░░██╔══██╗
██████╔╝██║░░██║█████═╝░█████╗░░██████╦╝██║░░██║██║░░░░░███████║
██╔═══╝░██║░░██║██╔═██╗░██╔══╝░░██╔══██╗██║░░██║██║░░░░░██╔══██║
██║░░░░░╚█████╔╝██║░╚██╗███████╗██████╦╝╚█████╔╝███████╗██║░░██║");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n Tipo da Pokebola: ");
            string kind = Console.ReadLine();
            Console.WriteLine("\n Cor da Pokebola: ");
            string color = Console.ReadLine();
            Console.WriteLine("\n Possibilidade de captura da Pokebola: ");
            string poss = Console.ReadLine();
            Thread.Sleep(2000);

        }

    
    
    
      static void treine()

        {

            Console.Clear();

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
████████╗██████╗░███████╗██╗███╗░░██╗░█████╗░██████╗░░█████╗░██████╗░
╚══██╔══╝██╔══██╗██╔════╝██║████╗░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗
░░░██║░░░██████╔╝█████╗░░██║██╔██╗██║███████║██║░░██║██║░░██║██████╔╝
░░░██║░░░██╔══██╗██╔══╝░░██║██║╚████║██╔══██║██║░░██║██║░░██║██╔══██╗
░░░██║░░░██║░░██║███████╗██║██║░╚███║██║░░██║██████╔╝╚█████╔╝██║░░██║");

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n Nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Sua idade: ");
            string age = Console.ReadLine();
            Console.WriteLine("\n Quantos Pokémons você possui", nome, ": ");
            int qtdpoke = int.Parse(Console.ReadLine());
            for (int i = 1; i < qtdpoke; i++)
            {
                Console.WriteLine($"\n Qual o nome do {i} Pokémon");
                string nomepoke = Console.ReadLine();
            }
            Console.WriteLine("\nQuantas vitória você possuiu, ", nome, ": ");
            string qtdvic = Console.ReadLine();
            Console.WriteLine("\n ", nome, ", Qual sua terra natal: ");
            string reg = Console.ReadLine();
            Thread.Sleep(2000);
        }
        static void cidade()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
░█████╗░██╗██████╗░░█████╗░██████╗░███████╗
██╔══██╗██║██╔══██╗██╔══██╗██╔══██╗██╔════╝
██║░░╚═╝██║██║░░██║███████║██║░░██║█████╗░░
██║░░██╗██║██║░░██║██╔══██║██║░░██║██╔══╝░░
╚█████╔╝██║██████╔╝██║░░██║██████╔╝███████╗");

            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n Nome da cidade:");
            string cidade = Console.ReadLine();
            Console.WriteLine("\n Região: ");
            string regiao = Console.ReadLine();
            Thread.Sleep(2000);
        }
        static void ginasio()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
░██████╗░██╗███╗░░██╗░█████╗░░██████╗██╗░█████╗░
██╔════╝░██║████╗░██║██╔══██╗██╔════╝██║██╔══██╗
██║░░██╗░██║██╔██╗██║███████║╚█████╗░██║██║░░██║
██║░░╚██╗██║██║╚████║██╔══██║░╚═══██╗██║██║░░██║
╚██████╔╝██║██║░╚███║██║░░██║██████╔╝██║╚█████╔╝");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\n Nome do Ginásio:");
            string gin = Console.ReadLine();
            Console.WriteLine("Dono do Ginásio:");
            string dono = Console.ReadLine();
        }
    }
}   