using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula11_Operadores_logicos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool var1 = true; // verdade 
            bool var2 = false; // Falso
            // Negação - !
            bool resultadonegacao = !var1;
                Console.WriteLine("O resultado de " + var1 + " e " + resultadonegacao);
            resultadonegacao = !var2;
                Console.WriteLine("O resultado de " + var2 + " e " + resultadonegacao);

            //Operador E (AND) - &
            bool resultadoE = var1 & var1;
                Console.WriteLine("O resultado de " + var1 + " e " + var1 + " resulta em " + resultadoE);
            resultadoE = var1 & var2;
                Console.WriteLine("O resultado de " + var1 + " e " + var2 + " resulta em " + resultadoE);
            resultadoE = var2 & var1;
                Console.WriteLine("O resultado de " + var2 + " e " + var2 + " resulta em " + resultadoE);

            //Operador OU (OR) respresentado por |
            bool resultadoOU = var1 | var1;
                Console.WriteLine("O resultado de " + var1 + " e "+ var1 + " resulta em " + resultadoOU) ;
            resultadoOU = var1 | var2;
                Console.WriteLine("O resultado de " + var1 + " e " + var2 + " resulta em " + resultadoOU);
            resultadoOU = var2 | var2;
                Console.WriteLine("O resultado de " + var2 + " e " + var2 + " resulta em " + resultadoOU);
            //Operador XOR representado ^
            bool resultadoXor = var1 ^ var1;
            Console.WriteLine("O resultado de " + var1 + " e " + var1 + " resulta em " + resultadoXor);
            resultadoXor = var1 ^ var2;
            Console.WriteLine("O resultado de " + var1 + " e " + var1 + " resulta em " + resultadoXor);
            resultadoXor = var2 ^ var2;
            Console.WriteLine("O resultado de " + var1 + " e " + var1 + " resulta em " + resultadoXor);
            Console.ReadKey();
        }
    }
}
