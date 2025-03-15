using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace aula_do_youtube_01
{
    internal class CustomerOnline : costumer
    {
        public CustomerOnline(string name, string endereco, DateTime data)
        {
            Name = name;
            Endereco = endereco;
            Data = data;

        }
    }
}
