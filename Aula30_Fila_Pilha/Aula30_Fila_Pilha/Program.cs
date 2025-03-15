using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula30_Fila_Pilha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> filaDeNome = new Queue<string>(); //Criando uma fila, o primeiro que for adicionado é o preimiro a sair
            filaDeNome.Enqueue("Erick"); // Adicionadno na lista 
            filaDeNome.Enqueue("João");
            filaDeNome.Enqueue("Ana"); // Adicionadno na lista 
            filaDeNome.Enqueue("Luiz");


            string nome = filaDeNome.Dequeue();// removendo da lista. 

            Console.WriteLine(nome);
            nome = filaDeNome.Dequeue();
            Console.WriteLine(nome);

            //espeiando elementos
            string espiando = filaDeNome.Peek();
            Console.WriteLine(espiando);

            //Stack priemiro a entrear é o ultimo a sair. 
            Stack<string> TesteTasck = new Stack<string>();
            TesteTasck.Push("Pipapau");


        }
    }
}
