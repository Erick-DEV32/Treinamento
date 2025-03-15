using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Aula29_Projeto
{
    internal class Program
    {
        struct Cadastro_Struct
        {
            public  string nome;
            public  string NomedaRua;
            public  int NumeroRua;
            public  int Idade;
        };
        static void Main(string[] args)
        {
            List<Cadastro_Struct> Cadastro = new  List<Cadastro_Struct> ();
            string Opcao;
            do
            {
             Console.WriteLine("Por favor pressione C para Cadastrar o usuário e S para Sair");
             Opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();

                if (Opcao == "c")
                {
                    Cadastro_Struct cadastro;
                    Console.WriteLine("Qual o nome do usuário");
                    cadastro.nome = Console.ReadLine();
                    Console.WriteLine("Qual o nome da sua rua?");
                    cadastro.NomedaRua = Console.ReadLine();
                    Console.WriteLine("Qual o número da sua rua?");
                    cadastro.NumeroRua = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Qual a sua Idade?");
                    cadastro.Idade = Convert.ToInt32(Console.ReadLine());
                }
                else if (Opcao == "s")
                {
                    Console.WriteLine("Você está saindo do cadastro");
                }
                else if (Opcao != "c" || Opcao != "s")
                {
                    Console.WriteLine("Você sabe ler? Caso saiba verifique a letra pressionada animal!!");
                    Console.ReadKey();
                    Console.Clear();
                }
            }while (Opcao !="s");
            Console.WriteLine("Você saiu da operação."); 
        }
    }
}
