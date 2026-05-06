using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Threading;

namespace centro_pokemon
{
    internal class Program
    {
        static void Main(string[] args)

        {
            int opcao = 0;
            while (opcao != 4)  // !=  diferente
            {
                Console.Clear();  //limpa  a tela
                Console.ForegroundColor = ConsoleColor.DarkBlue;

                Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░");







                Console.ResetColor();
                Console.WriteLine("\n seja bem vindo ao centro pokemon!\n");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n 1 - cadastrar pokemon");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n 2 - consultar pokemon");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("\n 3 - apagar pokemon");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n 4 - Sair");
                Console.ResetColor();
                opcao = int.Parse(Console.ReadLine());



                switch (opcao)
                {
                    case 1:
                        CadastroPokemon(); //abre a funcao
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(" Tchau Tchau !!!");
                        Thread.Sleep(2000);
                        break;


                    default:
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("opcao invalida!!!");
                        Console.ResetColor();
                        Thread.Sleep(2000); // Espera de 2 segundos
                        break;

                }

            }
        }


        static void CadastroPokemon()
        {



            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Clear();
            Console.WriteLine(@"
░█████╗░░█████╗░██████╗░░█████╗░░██████╗████████╗██████╗░░█████╗░
██╔══██╗██╔══██╗██╔══██╗██╔══██╗██╔════╝╚══██╔══╝██╔══██╗██╔══██╗
██║░░╚═╝███████║██║░░██║███████║╚█████╗░░░░██║░░░██████╔╝██║░░██║
██║░░██╗██╔══██║██║░░██║██╔══██║░╚═══██╗░░░██║░░░██╔══██╗██║░░██║
╚█████╔╝██║░░██║██████╔╝██║░░██║██████╔╝░░░██║░░░██║░░██║╚█████╔╝
░╚════╝░╚═╝░░╚═╝╚═════╝░╚═╝░░╚═╝╚═════╝░░░░╚═╝░░░╚═╝░░╚═╝░╚════╝░");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n Digite o nome do seu pokemon: ");
            string nomePokemon = Console.ReadLine(); //string = textos
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n Digite o tipo do seu pokemon: "); string tipoPokemon = Console.ReadLine(); //string = textos}
            Console.WriteLine("\n Digite o tamanho do seu pokemon: ");
            Console.WriteLine("\n Digite o peso do seu pokemon: ");
            double pesoPokemon = double.Parse(Console.ReadLine()); //double = casa decimal

            //fraqueza

            Console.WriteLine("quantas fraquezas ele tem? :");
            int qtdFraqueza = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdFraqueza; i++)
            {
                Console.WriteLine($"Fraqueza  {i} : "); // {i} --- colocar a variavel no texto
                string fraquezaPokemon = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n parabens . . .  pokemon cadastro ");
                Thread.Sleep(3000);
                Console.ResetColor();













            }


        }
    }
}
