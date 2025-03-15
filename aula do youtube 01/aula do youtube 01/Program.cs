using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace aula_do_youtube_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var age = Convert.ToDecimal(Console.ReadLine());
            var operador = Console.ReadLine();
            var age2 = Convert.ToDecimal(Console.ReadLine());
            //Console.WriteLine(int.Parse (age) * int.Parse (age2));
            calculator calculator = new calculator();
            calculator.calculadora(operador, age, age2);

            Console.WriteLine(calculator.calculadora(operador, age, age2));
            // List<string> list = new List<string>();
            // //a list é generia portanto podemos adicionar string, int, bool, var entre outros. 
            // list.Add("name 1");
            // list.Add("name 2");
            // list.Add("name 3");
            // list.Add("name 4");
            // notifications notifications = new notifications();
            // notifications.Sendnotifications(list);

            // //calse seria um objeto completo.

            //CustomerStore customerX = new CustomerStore(" Erick", "Rua Alameda Nadir", DateTime.Now);

            // customerX.Bem_Vindo();

            // CustomerOnline customerY = new CustomerOnline(" Ana", "Rua Alameda Nadir", DateTime.Now);

            // customerY.Bem_Vindo();

            // Console.WriteLine(customerX.Name);
            // Console.WriteLine(customerY.Name);

            //dESTE COMENTE PARA CIMA NÃO MEXER, RISCO DE LEVAR UNS TAPAS. 








            Console.ReadKey();


        }
    }
}
 