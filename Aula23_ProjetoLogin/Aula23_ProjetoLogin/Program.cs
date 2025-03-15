using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula23_ProjetoLogin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Qual o seu Usuário?");
                string Usuario = Console.ReadLine();
                Console.WriteLine("Qual sua senha? ");
                string senha = "";

                while (true)
                {
                    ConsoleKeyInfo tecla = Console.ReadKey(true);
                    if (tecla.Key == ConsoleKey.Enter)
                        break;

                    else
                    {
                        senha += tecla.KeyChar;
                        Console.Write("*");
                    }
                }

                if (Usuario == "Erick" || Usuario == "erick" && senha == "1234")
                {
                    Console.WriteLine("\n\r Usuário tem acesso. ");
                    break;
                }
                else
                {
                    Console.WriteLine("\r\n Usuário ou senha incorreta ");
                    Console.WriteLine("Pressione qualquer tecla para continuar. ");
                    Console.ReadKey();
                    Console.Clear();
                }
            }
             Console.WriteLine("Auxilio em algo mais no momento?");
            
        }
    }
}
