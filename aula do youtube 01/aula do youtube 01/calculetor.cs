using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_do_youtube_01
{
    internal  class calculator
    {
        /// <summary>
        /// Metodo que retorna o resultado do calculo.
        /// </summary>
        /// <param name="op">Opeator</param>
        /// <param name="values1">first value</param>
        /// <param name="values2">second value</param>
        /// <returns>the result </returns>
        public  decimal calculadora(string op,decimal values1,  decimal values2)
        {   //if ou else if costuma ser mais utilizado quando se tem mais condições ou regras. 
            if (op == "+")
            {
                return values1 + values2;
            }
            else if (op == "-")
            {
                return values1 - values2;
            }
            else if (op == "*")
            {
                return values1 * values2;
            }
            else if (op == "/")
            {
                return values1 / values2;
            }
            
            return 0;
            //swith é mais utilizado para apenas uma condição ou uma regra.
            //switch (op)
            //{
            //    case "+":
            //        return values1 + values2;
            //        break;
            //    case "-":
            //        return values1 - values2;
            //        break;
            //    case "*":
            //        return values1 * values2;
            //        break;
            //    case "/":
            //        return values1 / values2;
            //        break;
            //    imafault:
            //        return 0;


            //}

            //return 0;


        }
    }
}
