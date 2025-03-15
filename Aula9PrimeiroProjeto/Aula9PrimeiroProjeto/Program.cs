using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Aula9PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, tudo bem? poderia preencher o seu nome por favor. ");
            String nome = Console.ReadLine();
            Console.WriteLine("Olá, " + nome);
            Console.WriteLine("Preencha a dua idade");
            UInt32 idade = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Qual o número do seu documento?");
            UInt32 doc = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Qual o seu endereço?");
            String Endereco = Console.ReadLine();
            Console.WriteLine("Qual o número da sua casa? ");
            UInt32 NumCasa = Convert.ToUInt32(Console.ReadLine());
            Console.WriteLine("Qual o seu genêro? Pressione M para Masculino F para Feminino ou O para Outros");
            String Genero = Console.ReadKey(true).KeyChar.ToString();
            Console.WriteLine("A seguir as informações solicitadas.");
            Console.WriteLine("Seu nome" + nome);
            Console.WriteLine("Sua Idade" + idade);
            Console.WriteLine("Seu documento" + doc);
            Console.WriteLine("Seu endereço" + Endereco);
            Console.WriteLine("Numero da sua casa " + NumCasa);
            Console.WriteLine("Seu genêro é " + Genero);

            Console.ReadKey();

        }
    }
}
