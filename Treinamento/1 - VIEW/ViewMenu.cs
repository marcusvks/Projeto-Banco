using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento._1___VIEW
{
    public class ViewMenu
    {
        private static ConsoleKeyInfo _opcao;

        private static ViewAgencia _viewAgencia = new ViewAgencia();
        private static ViewContaBancaria _viewContaBancaria = new ViewContaBancaria();
        private static ViewPessoa _viewPessoa = new ViewPessoa();

        private ContaBancariaDao _contaDao = new ContaBancariaDao();
        private AgenciaDao _agenciaDao = new AgenciaDao();
        private PessoaDao _pessoaDao = new PessoaDao();
        
        public void IniciaMenu()
        {

            Console.WriteLine("\n É PRECISO PRIMEIRO TER PESSOA E AGENCIA PRA FUNGA \n");

            do
            {
                Console.WriteLine("\n Digite: \n f1 para cadastrar uma pessoa fisica ou jurídica \n f2 para cadastrar uma conta bancaria \n f3 para cadastrar uma agencia \n f4 para listar as pessoas \n f5 para listar as agencias \n f9 para sair");
                _opcao = Console.ReadKey();
                switch (_opcao.Key)
                {
                    case ConsoleKey.F1:
                        Console.Clear();
                        _viewPessoa.CadastraPessoa(_pessoaDao);
                        break;
                    case ConsoleKey.F2:
                        Console.Clear();
                        _viewContaBancaria.CadastraContaBancaria( _contaDao, _pessoaDao, _agenciaDao, _viewPessoa, _viewAgencia);
                        break;
                    case ConsoleKey.F3:
                        Console.Clear();
                        _viewAgencia.CadastraAgencia(_agenciaDao);
                        break;
                    case ConsoleKey.F4:
                        Console.Clear();
                        _viewPessoa.FormataListaDadosPessoa(_pessoaDao);
                        break;
                    case ConsoleKey.F5:
                        Console.Clear();
                        _viewAgencia.FormataListaAgencias(_agenciaDao);
                        break;
                }
            } while (_opcao.Key != ConsoleKey.F9);
        }
    }
}
