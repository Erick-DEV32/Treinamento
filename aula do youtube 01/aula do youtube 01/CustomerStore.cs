using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula_do_youtube_01
{
    internal class CustomerStore : costumer
    {
        public CustomerStore(string name, string endereco, DateTime data)
        {
            Name = name;
            Endereco = endereco;
            Data = data;

        }
    }
}
