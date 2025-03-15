using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Aula24_ManipulacaoDeString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Manipulação de string 
            //indexação de string
            string nome = "Erick";
            char Letra = nome [3];
            Console.WriteLine(Letra);
            Console.WriteLine("---------------------------");

            //concatenar String
            string nome2 = "Erick";
            string Sobrenome = "Ramon";
            Console.WriteLine(nome2 + Sobrenome);
            string nomesobrenome = string.Concat(nome, Sobrenome);
            Console.WriteLine(nomesobrenome);
            Console.WriteLine("---------------------------");

            //Substituicao de string
            string nome3 = "João Ricardo";
            nome3 = nome3.Replace("Ricardo", "Claudio");
            Console.WriteLine(nome3);
            Console.WriteLine("---------------------------");

            //Remoção de dados da string 
            string nome4 = "Erick Ramon Morais";
            nome4 = nome4.Replace("Morais", "Vieira");
            Console.WriteLine(nome4);
            /*Outra forma de remover*/
            string nome5 = nome4.Remove(6,5);
            Console.WriteLine(nome5);
            Console.WriteLine("---------------------------");

            //Capitalização de string maiuscula e minuscula
            string nome6 = "Erick Ramon Morais";
             nome6 = nome6.ToUpper();
            Console.WriteLine(nome6);
            string nome66 = nome6.ToLower();
            Console.WriteLine(nome66);
            Console.WriteLine("---------------------------");

            //verificando se a informação existe na string com bool
            string nome7 = "Erick Ramon";
            bool contem = nome7.Contains("Ramon");
            Console.WriteLine(contem);
            bool naocontem = nome7.Contains("Bruno");
            Console.WriteLine(naocontem);
            Console.WriteLine("---------------------------");

            //Localização de texto
            string nome8 = "Erick Ramon Da Silva";
            int indice = nome8.IndexOf("Da");
            Console.WriteLine(indice);
            Console.WriteLine("---------------------------");

            //divisão de string
            string nome9 = "Ana da Silva";
            string[] divisao = {"da"};
            string[] resultado = nome9.Split(divisao, StringSplitOptions.None);
            foreach (string texto in resultado) 
            {
                Console.WriteLine(texto);
            }
            Console.WriteLine("---------------------------");

            //Numero de caracteres
            string nome10 = "Douglas Insano";
            int Quantletra = nome10.Length;
            Console.WriteLine(Quantletra);
            Console.WriteLine("---------------------------");

            //subString 
            string nome11 = "Erick Ramon";
            string ultimo = nome11.Substring(6,5);
            Console.WriteLine(ultimo);
            Console.WriteLine("---------------------------");

            //
        }
    }
}
