using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaSobreVariaveis
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Idade = 22;
            Console.WriteLine(Idade);

            String Nome = "Erick Ramon";
            Console.WriteLine(Nome);

            Console.WriteLine("Olá, boa noite! \r\n " + Nome + " Qual a sua idade?");//\n\r foi utilizado para quebrar a linha. 
            Console.WriteLine("Minha idade é " + Idade);

            DateTime DataNascimento = new DateTime(2003, 09, 15, 5, 44, 58);
            //Logo abaixo está há demostração de como pegar as informações de forma detalhada do DateTime. 
            Console.WriteLine(DataNascimento.Year);
            Console.WriteLine(DataNascimento.Month);
            Console.WriteLine(DataNascimento.Day);
            Console.WriteLine(DataNascimento.Hour);
            Console.WriteLine(DataNascimento.Minute);
            Console.WriteLine(DataNascimento.Second);

            //Como utilizar o converte para alterar os dados de uma variavél
            String IdadeConv = "20";
            int IdateConvInt = Convert.ToInt32(IdadeConv);
            Console.WriteLine(IdateConvInt);

            String IdadeString = Convert.ToString(IdateConvInt);
            Console.WriteLine(IdadeString);

            Console.ReadKey(); 

        }
    }
}
