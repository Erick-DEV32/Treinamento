using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula26_Enum
{
    internal class Program
    {
        enum notas
        {
            nota2 = 2,
            nota5 = 5,
            nota10 = 10,
            nota20 = 20, 
            nota50 = 50

        };
        enum Nota
        {
            nota0=10,
            nota1,
            nota2=2,
            nota3=3,
            nota4=4,
        }

        static void Main(string[] args)
        {
           notas notaDinheiro = notas.nota2;
            Console.WriteLine(Convert.ToInt32(notaDinheiro)); //Caso convertido o valor aparecera sem a escrita. 
            notas notaDinheiro2 = notas.nota5; //Exemplo não convertido. 
            Console.WriteLine(notaDinheiro2);//Exemplo não convertido. 
            notas notaDinehrio3  = notas.nota10;
            Console.WriteLine(Convert.ToInt32(notaDinehrio3));//Caso convertido o valor aparecera sem a escrita. 
            notas notadinehiro4 = notas.nota20;
            Console.WriteLine(Convert.ToInt32(notadinehiro4));//Caso convertido o valor aparecera sem a escrita. 
            notas notadinehiro5 = notas.nota50;
            Console.WriteLine(Convert.ToInt32(notadinehiro5));//Caso convertido o valor aparecera sem a escrita. 
            Console.WriteLine("-------------------------------------------");
            Nota notasprova = Nota.nota0;
            Console.WriteLine(Convert.ToInt32(notasprova));
            Nota notasprova2 = Nota.nota1;
            Console.WriteLine(Convert.ToInt32(notasprova2));
            Nota notasprova3 = Nota.nota3;
            Console.WriteLine(Convert.ToInt32(notasprova3));
            Nota notasprova4 = Nota.nota4;
            Console.WriteLine(Convert.ToInt32(notasprova4));

        }
    }
}
