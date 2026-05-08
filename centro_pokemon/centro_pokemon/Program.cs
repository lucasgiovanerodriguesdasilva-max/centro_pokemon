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
            while (opcao != 6 )
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
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
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
            for (int i = 1; i <= qtdevolucao; i++) ;
            {
                Console.WriteLine($"\n golpe do{i} pokemon: ");
                string evolucaopokemon = Console.ReadLine();

            }
            Console.WriteLine("\n elemento do pokemon: ");
            string elementopokemon = Console.ReadLine();

            Console.WriteLine("\n fraqueza do pokemon: ");
            int fraquezapokemon =int.Parse(Console.ReadLine());
            for (int i = 1; i <= fraquezapokemon; i++)
            {
                Console.WriteLine("\n fraqueza {i} do pokemon: ");
            }
                




            }
            



            }

        

    }
}