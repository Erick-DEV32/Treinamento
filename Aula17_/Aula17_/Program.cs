using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Aula17_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //pontenciação 
            double potencia = Math.Pow(4, 2);
            Console.WriteLine(potencia);

            //Radiação
            double raiz = 3;
            double radiciacao = Math.Pow(27, 1 / raiz);
            Console.WriteLine(radiciacao);

            //Maximo e o minimo
            double maximo = Math.Max(4, 8);
            Console.WriteLine(maximo);
            double minimo = Math.Min(4, 8);
            Console.WriteLine(minimo);

            //Módulo faz a troca do sinal 
            double modulo = Math.Abs(-10);
            Console.WriteLine(modulo);

            //Operações trignométricas 
            //para o seno = sin
            //para o cosseno = cos
            //para o Tangente = tan
            double angulo = 30 * (2 * Math.PI) / 360;
            double seno = Math.Sin(angulo);
            Console.WriteLine(seno);

            //Arcsseno 
            //Arccosseno
            //arctamgente
            double arseno = Math.Asin(seno);
            Console.WriteLine(arseno);

            double arsenoGraus = arseno * 360 / (2 * Math.PI);
            Console.WriteLine(arsenoGraus);

            //Arredondando números 
            double numero = 1.3;
            double ArredondandoParaCima = Math.Ceiling(numero);
            double ArredondandoParaBaixo = Math.Floor(numero);
            Console.WriteLine(ArredondandoParaCima);
            Console.WriteLine(ArredondandoParaBaixo);

            //Logaritmo
            double base10 = Math.Log10(100);
            Console.WriteLine(base10);
            double BaseE = Math.Log(Math.E * Math.E * Math.E);
            Console.WriteLine(BaseE);


        }
    }
}
