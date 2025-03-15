using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula27_Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> Lista = new List<string>();
            //Adinionar elementos dentro da lista 
            Lista.Add("Jone");
            Lista.Add("Erick");
            Lista.Add("Daniel");
            Lista.Add("Sávio");
            Lista.Add("Gabigay");

            //Removendo elemnetos da listas
            Lista.Remove("Jone");
            //Removendo elementos em posições especificas
            Lista.RemoveAt(1); // Como o jone foi removido acima ele não conta mais como elemento, ou seja o Erick passou a ser o elemneto zero. 

            foreach (string nome in Lista)
            {
                Console.WriteLine(nome);
            }
            Console.WriteLine("-----------------------");
            List<string> nome2 = new List<string>();
            nome2.Add("Jone");
            nome2.Add("Erick");
            nome2.Add("Daniel");
            nome2.Add("Sávio");
            nome2.Add("Gabigay");
            nome2.RemoveRange(0, 3); //remove os elementos apartir do número zero até o número 3 
            foreach (string nomew in nome2)
            {
                // Console.WriteLine(nomew);

            }
            Console.WriteLine("Como contrar os elementos " + nome2.Count + " nome da lista.Cout");

            Console.WriteLine("------------------------------------------------------");

            List<string> lista3 = new List<string>();
            lista3.Add("Ericka");
            lista3.Add("Erick");
            lista3.Add("Mauricio");
            lista3.Add("Leandro");
            lista3.Add("Douglas");

            List<string> lista4 = new List<string>();
            lista4.Add("Rafael");
            lista4.Add("Radar");
            lista4.Add("Mel");
            lista4.Add("Rodouf");
            lista4.Add("Samuel");

            List<string> Listaconcatenada = lista3.Concat(lista4).ToList();
            foreach (string nomel in Listaconcatenada)
            {
                Console.WriteLine(nomel);
            }
            Console.WriteLine("------------------------------------------------------");
            //Verificando se uma lista de um determinado valor. 3
            bool ContemNome = Listaconcatenada.Contains("Rafael"); //Para falso e vendadeiro
            Console.WriteLine(ContemNome);
            bool contemNome = Listaconcatenada.Contains("ANA");
            Console.WriteLine(contemNome);

            Console.WriteLine("--------------------------------------------------------");
            //descobrindo indice ou sejo onde ou em qual está. 
            int indece = Listaconcatenada.IndexOf("Mauricio");
            Console.WriteLine(indece);
            Console.WriteLine("---------------------------------------------------------");
            List<string> Listawhere = Listaconcatenada.Where(t => t.StartsWith("R")).ToList();//Filtro Where
            foreach (string testeWhere in Listawhere)
            {
                Console.WriteLine(testeWhere);
            }


        }
    }
}
