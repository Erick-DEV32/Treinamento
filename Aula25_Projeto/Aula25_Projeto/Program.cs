using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Aula26_Projeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            do
            {
                Console.WriteLine("Pressione C para realizar um cadastro e S para sair");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();
                if (opcao == "c")
                {
                    Console.WriteLine("Qual o seu nome?");
                    string nome = Console.ReadLine(); 
                    Console.WriteLine("Qual a sua idade?");
                    UInt32 idade = Convert.ToUInt32(Console.ReadLine());
                    Console.WriteLine("Qual sua data de nascimento");
                    DateTime DataNascimento = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Qual o seu genero? Pressione M para Masculino ou F para Feminino");
                    char genero = Convert.ToChar(Console.ReadKey(true).KeyChar.ToString());
                    Console.WriteLine("Qual o endereço da sua casa?");
                    string endereco = Console.ReadLine();
                    Console.WriteLine("Qual o numero da sua casa?");
                    UInt32 Numcasa = Convert.ToUInt32(Console.ReadLine().ToString());
                    Console.WriteLine("Cadastro realizado com sucesso!!");

                }
                else if (opcao == "s")
                {
                    Console.WriteLine("Processo finalizado esperamos você para realizar mais cadastro em nosso sistema.");
                }
                else if (opcao != "c" || opcao != "s")
                {
                    Console.WriteLine("A tecla pressionada não atende os requisitos, por favor pressione C para realizar o cadastro ou S para sair.");
                    Console.WriteLine("Presione qualquer tecla para limpar e começar novamente");
                    Console.ReadKey();
                    Console.Clear();
                }
           

            } while (opcao != "s");
           // Console.WriteLine("A tecla pressionada não atende os requisitos, por favor pressione C para realizar o cadastro ou S para sair.");
            Console.WriteLine("Pressione qualquer tecla para limpar a tela");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
