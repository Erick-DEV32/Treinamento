using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_do_youtube_01
{

    //Classe serve para gardar atributos
    internal class costumer
    {
        string _name;
        public string Name 
        { get { return " Mister" + _name; }
            set { _name = value; } 
        } // get ou GETTERS  e set OU CETTERS controlam os valores de entrada e saída das propriedades. 
        public string Endereco { get; set; }
        public DateTime Data { get; set; }

        //public costumer(string name, string endereco, DateTime data)
        //{
        //    Name = name;
        //    Endereco = endereco;
        //    Data = data;

        //}
        public void Bem_Vindo ()   
        {
            Console.WriteLine("Bem Vindo" + Name + "! Your credit card is on the way. ");
        }


    }
   
   
}
