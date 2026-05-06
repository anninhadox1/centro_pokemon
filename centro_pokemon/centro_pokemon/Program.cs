using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

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
██████╗░░█████╗░██╗░░██╗███████╗███╗░░░███╗░█████╗░███╗░░██╗
██╔══██╗██╔══██╗██║░██╔╝██╔════╝████╗░████║██╔══██╗████╗░██║
██████╔╝██║░░██║█████═╝░█████╗░░██╔████╔██║██║░░██║██╔██╗██║
██╔═══╝░██║░░██║██╔═██╗░██╔══╝░░██║╚██╔╝██║██║░░██║██║╚████║
██║░░░░░╚█████╔╝██║░╚██╗███████╗██║░╚═╝░██║╚█████╔╝██║░╚███║
╚═╝░░░░░░╚════╝░╚═╝░░╚═╝╚══════╝╚═╝░░░░░╚═╝░╚════╝░╚═╝░░╚══╝");
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
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        Console.Clear(),
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(" Tchau Tchau !!!");
                        System.Threading.Thread.Sleep(2000);
                        break;


                    default:
                        Console.ForegroundColor = ConsoleColor.DarkGray;
                        Console.WriteLine("opcao invalida!!!");
                        Console.ResetColor();
                        System.Threading.Thread.Sleep(2000); // Espera de 2 segundos
                        break;

                }

            }

        }


    }
}



