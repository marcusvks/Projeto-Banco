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
        public static int OpcaoMenu;

        static void Main(string[] args)
        {
            Console.WriteLine("\n É PRECISO PRIMEIRO TER PESSOA E AGENCIA PRA FUNGA \n");
            while (OpcaoMenu != 9)
            {
                Console.WriteLine("\n Digite: \n 1 para cadastrar uma pessoa fisica ou jurídica \n 2 para cadastrar uma conta bancaria \n 3 para cadastrar uma agencia \n 4 para listar as pessoas \n 5 para listar as agencias \n 9 para sair");
                OpcaoMenu = Convert.ToInt16(Console.ReadLine());

                switch (OpcaoMenu)
                {
                    case 1:
                        viewPessoa.CadastraPessoa();
                        break;
                    case 2:
                        viewContaBancaria.CadastraContaBancaria();
                        break;
                    case 3:
                        viewAgencia.CadastraAgencia();
                        break;
                    case 4:
                        viewPessoa.FormataListaDadosPessoa();
                        break;
                    case 5:
                        viewAgencia.FormataListaAgencias();
                        break;
                }
            }
        }
    }
}
