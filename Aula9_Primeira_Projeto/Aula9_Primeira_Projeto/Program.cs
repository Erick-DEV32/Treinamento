using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula9_Primeira_Projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá Tudo bem, poderia digitar o seu nome, por favor? ");
            String nome = Console.ReadLine();
            Console.WriteLine("Certo " + nome +", agora preciso que informe a sua idade.");
            UInt32 Idade = Convert.ToUInt32 (Console.ReadLine());
            Console.WriteLine(nome + " Preencha o número do seu documento.");
            String Documento = Console.ReadLine();
            Console.WriteLine(nome + " Qual seria o seu endereço?");
            String Endereco = Console.ReadLine();
            Console.WriteLine(nome + " Estamos quase finalizando, preencha o número da sua casa, por favor.");
            UInt32 NumCasa = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine(nome + " Pessione M para masculino, F para feminino ou O para outro");
            string Genero = Console.ReadKey(true).KeyChar.ToString();
            Console.WriteLine(Genero);

            Console.ReadKey();

        }
    }
}
