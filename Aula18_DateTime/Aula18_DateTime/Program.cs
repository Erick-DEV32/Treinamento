using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Aula18_DateTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime data = new DateTime(2025, 09, 15);
            DateTime DataHota = new DateTime(2025, 09, 15, 22, 15, 43);
            Console.WriteLine("Ano " + DataHota.Year);
            Console.WriteLine("Mês " + DataHota.Month);
            Console.WriteLine("Dia " + DataHota.Day);
            Console.WriteLine("Hora " + DataHota.Hour);
            Console.WriteLine("Minuto " + DataHota.Minute);
            Console.WriteLine("Segundos " + DataHota.Second);
            Console.WriteLine("DiaDaSemana " + DataHota.DayOfWeek);
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine(data.ToString());
            Console.WriteLine(DataHota.ToString());
            Console.WriteLine("-------------------------------------------");
            DateTime DataHoraAtual = DateTime.Now;
            Console.WriteLine(DataHoraAtual.ToString());
            Console.WriteLine("Apenas a Data " + DataHoraAtual.Date);

            //Conversão de data para String e de String para data

            DateTime DataConv = Convert.ToDateTime("2023/09/15");
            DateTime DataConvHora = Convert.ToDateTime("2023/09/15 15:15:43");
            Console.WriteLine(DataConv.ToString());
            Console.WriteLine(DataConvHora.ToString());

            //Formatando data e hora

            Console.WriteLine(DataHoraAtual.ToString("Y"));
            Console.WriteLine(DataHoraAtual.ToString("M"));
            Console.WriteLine(DataHoraAtual.ToString("yyyy"));

            Console.WriteLine("-------------------------------------------");

            DateTime Datahora2 = new DateTime(2024, 10, 01, 14, 5, 10);
            Datahora2 = Datahora2.AddDays(5); // Variavél com data 
            Console.WriteLine(Datahora2.ToString("dd/MM/yyyy"));
            Datahora2 = Datahora2.Add(new TimeSpan(1, 5, 10)); // Porcesso de Variavél com hora 
            Console.WriteLine(Datahora2.ToString("hh:mm:ss"));
            //Subtração de datahora
            DateTime Datahora3 = new DateTime(2024,10,01,14, 5, 10);
            Datahora3 = Datahora3.Subtract(new TimeSpan(2024, 13, 5, 10));
            Console.WriteLine(Datahora3.ToString("hh:mm:ss"));
            Datahora3 = Datahora3.AddDays(-5); // Por se tratar de uma variavél de subtração adicionamos o simbolo de menos (-) dentro do parentese para subtrair o dia o mês ou o ano. 
        }
    }
}
