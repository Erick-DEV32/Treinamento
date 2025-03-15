using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Aula27_Struct
{
    internal class Program
    {
        struct CADASTRO
        {
           public string nome; // o motivo do public no começo da variavél e para que eu possa consultar caso contrario daria erro de liberação. 
           public string nomerua;
           public UInt32 NumeroCasa;
           public DateTime DataNascimento;

        };
        static void Main(string[] args)
        {
            CADASTRO Meucadastro;
            Meucadastro.nome = "Erick";
            Meucadastro.nomerua = "Alamenda";
            Meucadastro.NumeroCasa = 5;
            Meucadastro.DataNascimento = Convert.ToDateTime("15/09/2003");
            Console.WriteLine(Meucadastro.nome);
            Console.WriteLine(Meucadastro.nomerua);
            Console.WriteLine(Meucadastro.NumeroCasa);
            Console.WriteLine(Meucadastro.DataNascimento);
            Console.WriteLine(Meucadastro.DataNascimento.Day + "/" + Meucadastro.DataNascimento.Month + "/" + Meucadastro.DataNascimento.Year);//Outra forma de apresenta a data nascimento de forma mais separa dia, mês, ano. 
        }   
    }
}
