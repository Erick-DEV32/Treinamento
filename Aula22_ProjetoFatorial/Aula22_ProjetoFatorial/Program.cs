using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Aula22_ProjetoFatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Pressione S para sair ou um número para calcular o fatorial.");
                string opcao = Console.ReadLine();
              if (opcao == "S" || opcao == "s")
                {

                    break;
                }
                
              else
                        {
                            int valor = Convert.ToInt32(opcao);
                            if (valor == 0)
                                Console.WriteLine("Fatorial de 0! = 1");
                            else if (valor < 0)
                                Console.WriteLine("Não é possúivel calcular número negativos");
                            else
                            {
                                int resultado = 1;
                                Console.Write(valor + "! = ");
                                for (int i = valor; i > 0; i--)
                                {
                                    resultado *= i;
                                    if (i == 1)
                                    {
                                        Console.Write(i + " = " + resultado);
                                    }
                                    else
                                    {
                                        Console.Write(i + "X");
                                    }
                                }
                                Console.Write("\n");
                                Console.Write("O Resultado de " + valor + " fatorial é " + resultado);
                            }
                            Console.ReadKey();
                            Console.Clear();
                        }
                


            }
            Console.WriteLine("Fico feliz que tenha participado");

            



        }

    }
}
