using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Operadores
{
    internal class Program
    {
        static void Main(string[] args)

        {
            
            Console.WriteLine("Pressione uma letra do seu teclado de merda!!");
            char  nome = Console.ReadKey(true).KeyChar;
            Console.WriteLine("Qual a sua idade? ");
            int idade = Convert.ToInt32(Console.ReadLine());
            bool ChaveDeAcesso = true;

            if (idade == 18)
            {
                Console.WriteLine("Parabéns!! \r\nVocê está apto a começar na agente como suporte de missão.");
            }
            else if (idade == 19)
            {
                Console.WriteLine("Parabéns, você tem a idade para ser agente de campo, caso não queira suas memorias estaram sendo apagadas e você retornara a sua vida normalmente. ");
            }
            else if (idade <= 17)
            {
                Console.WriteLine("Você está fora.");
            }
            else { Console.WriteLine("Você está reprovado, não volte mais aqui"); }

            Console.ReadKey();

            //switch (nome)
            //{
            //    case 'a':
            //        Console.WriteLine("Você clicou na letra A ");
            //        break;
            //    case 'b':
            //        Console.WriteLine("Você clicou na letra B");
            //        break;
            //    case 'c':
            //        Console.WriteLine("Você clicou na letra C");
            //        break;
            //    default:
            //        Console.WriteLine("Você não pressionou nem A nem B ou C");
            //        break;
            //}

            Console.ReadKey();  

        }
    }
}
