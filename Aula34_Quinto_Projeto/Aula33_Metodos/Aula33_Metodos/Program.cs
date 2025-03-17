using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Aula33_Metodos
{
    class Program
    {
        // tipo de acesso do metodo _____ Modificador_de_metodo tipo de retorno (Parametro_de_metodos)
        public static double soma(double a, double b)
        {
            double SomaResul = a + b;
            return SomaResul;
            // return (a + b); apenas outra forma para apresentar. 
        }

        public static void ImprimiMensagens()
        {
            Console.WriteLine("Não existi informação no metodos.");
            Console.WriteLine("Não tem informação de entrada ou saída. ");
        }
        //Modificadores de parâmetros de entradas. 
        /*
         Ref: sinaliza que os parâmetros de entradas "PODE" ser modificado pelo metodos
        Out: Sinaliza que os parâmetros de entrada "DEVE" ser modificado pelo método
         */
        public static void multiplica (double a, double b, ref double resultado)
        {
            double ResultadoMult = a * b;
            resultado = ResultadoMult;
        }
        public static void multiplica2(double a, double b, out double resultado)
        {
            double ResultadoMult = a * b;
            resultado = ResultadoMult;
        }

        static void Main(string[] args)
        {
            //Chamando metodis
            double resul = soma(100, 101);
            Console.WriteLine("O resultado é " + resul);
            Console.WriteLine("Digite dois números");
            double Teste1 = Convert.ToDouble(Console.ReadLine());
            double Teste2 = Convert.ToDouble(Console.ReadLine());
            double Resultado = soma(Teste1, Teste2);
            Console.WriteLine("O resultado dos dois numeros somados é " + Resultado);

            ImprimiMensagens();
            double numero1 = 10;
            double numero2 = 20;
            double resultadomultiplica = 0;
            multiplica(numero1, numero2, ref resultadomultiplica);
            Console.WriteLine("Seu resultado é " + resultadomultiplica);
            multiplica2(numero1, numero2, out resultadomultiplica);
            Console.WriteLine("O Resultado é: " + resultadomultiplica);
        }
    }
}
