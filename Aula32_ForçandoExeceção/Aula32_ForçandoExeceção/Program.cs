using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula32_ForçandoExeceção
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Selecione preencha com um número positivo");
                int Num = Convert.ToInt32(Console.ReadLine());
                if (Num < 0)
                throw new Exception("O Nuémro " + Num + " é menor que zero");
            }
            catch (Exception T)
            {
                Console.WriteLine("Execeção: " + T.Message);
            }
            finally
            {
                Console.WriteLine("Pressione qualquer tecla para sair");
                Console.ReadKey();
            }

        }
    }
}
