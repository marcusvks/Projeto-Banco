using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento._1___VIEW;

namespace Treinamento
{
    public class Program
    {
        public static string Cpf, Cnpj;
        public static string TipoPessoa;
        public static ViewAgencia viewAgencia = new ViewAgencia();
        public static ViewContaBancaria viewContaBancaria = new ViewContaBancaria();
        public static ViewPessoa viewPessoa = new ViewPessoa();
        public static ConsoleKeyInfo opcao;

        static void Main(string[] args)
        {
            Console.WriteLine("\n É PRECISO PRIMEIRO TER PESSOA E AGENCIA PRA FUNGA \n");

            do
            {                
                Console.WriteLine("\n Digite: \n f1 para cadastrar uma pessoa fisica ou jurídica \n f2 para cadastrar uma conta bancaria \n f3 para cadastrar uma agencia \n f4 para listar as pessoas \n f5 para listar as agencias \n f9 para sair");
                opcao = Console.ReadKey();
                switch (opcao.Key)
                {
                    case ConsoleKey.F1:
                        Console.Clear();
                        viewPessoa.CadastraPessoa();
                        break;
                    case ConsoleKey.F2:
                        Console.Clear();
                        viewContaBancaria.CadastraContaBancaria();
                        break;
                    case ConsoleKey.F3:
                        Console.Clear();
                        viewAgencia.CadastraAgencia();
                        break;
                    case ConsoleKey.F4:
                        Console.Clear();
                        viewPessoa.FormataListaDadosPessoa();
                        break;
                    case ConsoleKey.F5:
                        Console.Clear();
                        viewAgencia.FormataListaAgencias();
                        break;
                }
            } while (opcao.Key != ConsoleKey.F9);
        }
    }
}
