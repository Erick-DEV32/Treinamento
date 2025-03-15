using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero = 16.0;
            double numero2 = 14.0;

            double resultado = numero + numero2;
            Console.WriteLine("Essa é a soma " + resultado);

            double resultado2 = numero - numero2;
            Console.WriteLine("Essa é a subtração " + resultado2);

            double resultado3 = numero * numero2;
            Console.WriteLine("Resultado multiplicação " + resultado3);

            double resultado4 = numero / numero2;
            Console.WriteLine("Resultado da divisão " + resultado4);
            //resto representado por %
            int resto1 = 4;
            int resto2 = 3;
            int resultado5 = resto1 % resto2;
            Console.WriteLine("Essa seria a forma de usar o resto " + resultado5);
            //---------------------------------------------------------------------------------------------------
            double som = 10;
            som = som += 10;
            Console.WriteLine("essa seria outra forma de usar a soma atribuindo o valor de uma variar a o valor dela mesma resultando no valor  " + som + " ou\n seja a minha variável era 10 e atribui o valor de 10 ");

            double sub = 10;
            sub = sub -= 10;
            Console.WriteLine("Essa segue a mesma lógica aplicada anteriormente porém subtraindo o valor 10 - 10 = " + sub);
            double multi = 10;
             multi = multi *= 10;
            Console.WriteLine("Essa segua a mesma lógica do modelo anterior porém multiplicando 10 * 10 = " + multi);
            double div = 10;
            div = div /= 10;
            Console.WriteLine("Essa segue a mesma lógica porém dividindo 10 / 10 = " + div);
            double incremento = 10;
             incremento++;
            Console.WriteLine("Essa é a espressão incremento adicionando mais um/1 = " + incremento);
            double decremento = 10;
            decremento --;
            Console.WriteLine("Essa é a expressão de decremento subtraindo um/1 = " + decremento );


            Console.ReadKey();

        }
    }
}
