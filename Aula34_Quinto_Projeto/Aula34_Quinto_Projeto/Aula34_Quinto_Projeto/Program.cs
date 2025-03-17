using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Aula34_Quinto_Projeto
{
    class Program
    {       //Treinando métodos.
        public struct Dados
        {
            public string nome;
            public DateTime Data_Nacimento;
            public string Nome_da_Rua;
            public UInt32 Numero_Casa; 

        }
        public enum resultado
        {
            sucesso = 0,
            sair = 1,
            Excecao = 2
        }
        public static void MostraMensagem (String Mensagem)
        {
            Console.WriteLine(Mensagem);
            Console.WriteLine("Pressione qualquer tecla para sair..");
            Console.ReadKey();
            Console.Clear();
        }
        public static resultado PegaString(ref string MinhaString, string mensagem)
        {
            resultado retorno;
            Console.WriteLine(mensagem);
            string temp = Console.ReadLine();
            if (temp == "s" || temp == "S")
            {
                retorno = resultado.sair;
            }
            else
            {
                MinhaString = temp;
                retorno = resultado.sucesso;
                Console.Clear();
                return retorno;
            }
            Console.Clear();
            return retorno;
        }


        public static resultado Data (ref DateTime data, string mensagem)
        {
            resultado retorno;
            do
            {
                try
                {
                    Console.WriteLine(mensagem);
                    string temp = Console.ReadLine();
                    if (temp == "s" || temp == "S")
                    {
                        retorno = resultado.sair;
                    }
                    else
                    {
                        data = Convert.ToDateTime(temp);
                        retorno = resultado.sucesso;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("EXECÇÃO: " + e.Message);
                    Console.WriteLine("Pressione qualquer tecla");
                    Console.ReadKey();
                    Console.Clear();
                    retorno = resultado.Excecao;
                }

            } while (retorno == resultado.Excecao);
            Console.Clear();
            return retorno;

        }
        public static resultado PegaUint32(ref UInt32 numeroUint32, string mensagem)
        {
            resultado retorno;
            do
            {
                try
                {
                    Console.WriteLine(mensagem);
                    string temp = Console.ReadLine();
                    if (temp == "s" || temp == "S")
                    {
                        retorno = resultado.sair;
                    }
                    else
                    {
                        numeroUint32 = Convert.ToUInt32(temp);
                        retorno = resultado.sucesso;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("EXECÇÃO: " + e.Message);
                    Console.WriteLine("Pressione qualquer tecla");
                    Console.ReadKey();
                    Console.Clear();
                    retorno = resultado.Excecao;
                }

            } while (retorno == resultado.Excecao);
            Console.Clear();
            return retorno;

        }
        public static void CadastroUsuario (ref List <Dados> ListaUsuario)
        {
            Dados CadastroUsuario;
            CadastroUsuario.nome = "";
            CadastroUsuario.Nome_da_Rua = "";
            CadastroUsuario.Numero_Casa = 0;
            CadastroUsuario.Data_Nacimento = new DateTime();
            if (PegaString(ref CadastroUsuario.nome, "Digite o nome completo ou digite S para sair.") != resultado.sucesso)
                return;
            if (Data(ref CadastroUsuario.Data_Nacimento, "Digite a data de nascimento no formato DD/MM/AAAA ou digite S para sair") != resultado.sucesso)
                return;
            if (PegaString(ref CadastroUsuario.Nome_da_Rua, "Digite o nome da rua ou S para sair") != resultado.sucesso)
                return;
            if (PegaUint32(ref CadastroUsuario.Numero_Casa, "Digite o numero da casa ou S para sair") != resultado.sucesso)
                return;
            ListaUsuario.Add(CadastroUsuario);
        }


        static void Main(string[] args)
        {
            List<Dados> ListaDeUsuario = new List<Dados>();
            string opcao = "";
            do
            {
                Console.WriteLine("Digite C para cadastrar um novo usuário e S para sair.");
                opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();
                if (opcao == "c")
                {
                    CadastroUsuario(ref ListaDeUsuario);
                }
                else if (opcao == "s")
                {
                    MostraMensagem("encerrando o programa");
                }
                else
                {
                    MostraMensagem("opção desconecida");
                }
            } while (opcao !="s");

        }
    }
}
