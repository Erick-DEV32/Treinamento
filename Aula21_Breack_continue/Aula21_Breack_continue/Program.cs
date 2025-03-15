using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula21_Breack_continue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Pressione C para Continuar ");
                Console.WriteLine("Pressione S para Sair ");
                string tecla = Console.ReadKey(true).KeyChar.ToString();
                if (tecla == "c" || tecla == "C")
                {
                    continue;
                }

                else if (tecla == "s" || tecla == "S")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Parabens você não clicou nem no C nem no S");
                }
                    
            }
            Console.WriteLine("Vencemos a aula 21");

        }
    }
}
