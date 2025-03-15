using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_do_youtube_01
{
    internal class notifications
    {
        public void Sendnotifications(List<string> list) 
        {   //metodo 1 

            foreach (var item in list) // Cria uma variavel em tempo de execução é para cada indice que ele encontrar na lista ele adicona dentro da variavél
            {

                Console.WriteLine("Inventation to the PARTY sent - " + item);
            }
            //metodo 2 
            /*var Count = 0;*/// criei um contador para que o loop continue até que ele não conte mais nada. 
            //While trabalha com condições, enquanto uma condição é atendida ele continuará executando. 
            //while (Count < list.Count)
            //{

            //    Console.WriteLine("Inventation to the PARTY sent - " + list[Count]);
            //    Count++;

            //}


        }
    }
}
