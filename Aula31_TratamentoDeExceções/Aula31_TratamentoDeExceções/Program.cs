using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula31_TratamentoDeExceções
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número");
            int Num1 = Convert.ToInt32(Console.ReadLine());
 
            try 
            {
                int Div = 10 / Num1;
                int resultado = Div;
                Console.WriteLine("Valor da divisão " + resultado);
            }
            catch (DivideByZeroException t ) 
            {
                Console.WriteLine("Execeção sem tratamento " + t.Message);

            }
            finally 
            {
                Console.WriteLine("Pressione qualquer tecla para continuar");
            }
        }
    }
}
