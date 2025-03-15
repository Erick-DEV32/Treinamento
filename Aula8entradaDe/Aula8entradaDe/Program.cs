using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Aula8entradaDe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o Seu nome? ");
            String nome = Console.ReadLine();
            Console.WriteLine("Muito prazer " + nome);

            Console.WriteLine("Qual a sua idade? ");
            string idade = Console.ReadLine();
            //int idadeConv = Convert.ToInt32(idade); // Convertento a String retirei o converte poois caso tivesse algum ingraçadinho para pressionar uma letra o código não irá parar. 
            Console.WriteLine("Então sua idade é " + idade);

            //Captura de tecla do usuário
            Console.WriteLine("Poderia pressionar qualquer tecla");
            char Tecla = Console.ReadKey(true ).KeyChar;// sem o Key char no final irá aparecer erro na compilação. 
            Console.WriteLine(Tecla);

            Console.WriteLine("Pressione qualquer tecla para encerrar.");

            Console.ReadKey();  


        }
    }
}
