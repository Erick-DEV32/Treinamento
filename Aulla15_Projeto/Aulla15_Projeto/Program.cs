using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aulla15_Projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, vamos alugar um filme?\n Pressione A para alugar ou S para Sair");
            char alugar = Console.ReadKey(true).KeyChar; //Caso seja uma string no If utilizar .ToUpperCase para não ter que utilizar o || para Maiusculo ou minusculo. 
            if (alugar == 'A' || alugar == 'a')
            {
                Console.WriteLine("Pressione o número 1 para alugar Homem aranha ");
                Console.WriteLine("Pressione o número 2 para alugar Pantera cor de Rosa");
                Console.WriteLine("Pressione o npumero 3 para alugar Top Gun");
                int opcao = Convert.ToInt32(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Parabéns você alugou o Homem aranha");
                        break;
                    case 2:
                        Console.WriteLine("Parabéns você alugou Pantera cor de Rosa");
                        break;
                    case 3:
                        Console.WriteLine("Parabéns, você alugou Top Gun ");
                        break;
                    default:
                        Console.WriteLine("Infelizmente não temos esse filme ");
                        break;
                }
            }
            else if (alugar == 'S' || alugar == 's')
            {
                Console.WriteLine("Fraco, Você resolviu sair ");
            }
            Console.WriteLine("Pressione qualquer tecla para sair");

        }
    }
}
