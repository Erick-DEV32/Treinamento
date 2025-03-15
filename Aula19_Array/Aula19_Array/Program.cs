using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula19_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[ 3 ]; //Arraey de uma dimensão. modo padrão de criação
            array [0] = 1;
            array [1] = 10;
            array [2] = 100;
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);
            Console.WriteLine("---------------------------");
            int[] array2 = {1,2,3 }; // segunda maneira de array de uma dimensão. 
            Console.WriteLine(array2[0]);
            Console.WriteLine(array2[1]);
            Console.WriteLine(array2[2]);
            Console.WriteLine("---------------------------");
            int[] array3 = new int [] {11,12,13 }; //terceira forma de um array em uma dimensão com chave e couchete 
            Console.WriteLine(array3[0]);
            Console.WriteLine(array3[1]);
            Console.WriteLine(array3[2]);
            //----------------------------------------------------------------------------------
            string [,] array4 = new string [2,3]; //array de duas dimensões
            array4 [0, 0] = "1";
            array4 [0, 1] = "2";
            array4 [0, 2] = "3";
            array4 [1, 0] = "11";
            array4 [1, 1] = "12";
            array4 [1, 2] = "13";
            Console.WriteLine("---------------------------");
            string [,] array5 = { { "1", "2", "3" },{ "11", "22", "33" } }; // criação de array de duas dimenções com chaves 
            Console.WriteLine(array5[0,0]);
            Console.WriteLine(array5[0,1]);
            Console.WriteLine(array5[0,2]);
            Console.WriteLine(array5[1,0]);
            Console.WriteLine(array5[1,1]);
            Console.WriteLine(array5[1,2]);
            Console.WriteLine("---------------------------");
            int[,] array6 = new int[,] { { 12, 23, 33 }, { 11, 12, 13 } }; // array de duas dimensões com chaves e couchetes 
            Console.WriteLine(array6[0,0]);
            Console.WriteLine(array6[0,1]);
            Console.WriteLine(array6[0,2]);
            Console.WriteLine(array6[1,0]);
            Console.WriteLine(array6[1,1]);
            Console.WriteLine(array6[1,2]);
            Console.WriteLine("---------------------------");
            //--------------------------------------------------------------------------------------------------------------------------------------
            int tamanhoarray = array6.GetLength(0);
            int tamanhoarray2 = array6.GetLength(1);
            Console.WriteLine("Valor do array6 " + tamanhoarray + " primeira unicade");//GetLength(); mostra o valor armazenado dentro do array. 
            Console.WriteLine("Valor do Array6 " + tamanhoarray2 + " Segunda unidade");

        }
    }
}
