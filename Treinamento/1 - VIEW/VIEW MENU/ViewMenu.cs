using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento._1___VIEW.BASE;
using Treinamento._1___VIEW.VIEW_MENU;
using Treinamento._3___DAO;

namespace Treinamento._1___VIEW
{
    public class ViewMenu
    {
        private static ConsoleKeyInfo _opcao;
        //view
        private static ViewAgencia _viewAgencia = new ViewAgencia();
        private static ViewContaBancaria _viewContaBancaria = new ViewContaBancaria();
        private static ViewPessoa _viewPessoa = new ViewPessoa();
        private static ViewSaque _viewSaque = new ViewSaque();
        private static ViewDeposito _viewDeposito = new ViewDeposito();
        private static ViewTransferencia _viewTransferencia = new ViewTransferencia();
        private static ViewContaBancaria _viewConta = new ViewContaBancaria();
        private static ViewRelatorioOperacoes _viewRelatorio = new ViewRelatorioOperacoes();
        private static ViewFuncionario _viewFuncionario = new ViewFuncionario();
        //View Menu
        private static ViewMenuAgencia _viewMenuAgencia = new ViewMenuAgencia();
        private static ViewMenuConta _viewMenuConta = new ViewMenuConta();
        private static ViewMenuFuncionario _viewMenuFuncionario = new ViewMenuFuncionario();
        private static ViewMenuPessoa _viewMenuPessoa = new ViewMenuPessoa();
        private static ViewMenuOperacoes _viewMenuOperacoes = new ViewMenuOperacoes();
        //dao
        private ContaBancariaDao _contaDao = new ContaBancariaDao();
        private AgenciaDao _agenciaDao = new AgenciaDao();
        private PessoaDao _pessoaDao = new PessoaDao();
        private RelatorioOperacaoDao _relatorioDao = new RelatorioOperacaoDao();
        private FuncionarioDao _funcionarioDao = new FuncionarioDao();
        public ViewMenu()
        {
            DataBase.CadastrarPessoasFisicas(_pessoaDao, 10);
            DataBase.CadastraAgencias(_agenciaDao, 3);
        }

        public void IniciaMenu()
        {
            Console.Clear();

            Console.WriteLine("\n É PRECISO PRIMEIRO TER PESSOA E AGENCIA PRA FUNGA - 1 é operacao de Deposito, 2 de Saque, 3 de Transferencia \n");

            do
            {
                Console.WriteLine("\n PRESSIONE: \n\n F1 Para operacoes com Pessoa \n F2 Para operacoes com Conta Bancaria \n F3 Para operacoes com Agencia \n F4 Para operacoes com Funcionario \n F5 Para fazer as Operacoes \n F12 para sair");
                _opcao = Console.ReadKey();
                switch (_opcao.Key)
                {
                    case ConsoleKey.F1:
                        Console.Clear();
                        _viewMenuPessoa.StartMenuPessoa(_viewPessoa, _pessoaDao);
                        break;
                    case ConsoleKey.F2:
                        Console.Clear();
                        _viewMenuConta.IniciaMenuConta(_viewConta,_viewPessoa, _viewAgencia, _agenciaDao, _contaDao, _pessoaDao);
                        break;
                    case ConsoleKey.F3:
                        Console.Clear();
                        _viewMenuAgencia.IniciaMenuAgencia(_viewAgencia, _agenciaDao);
                        break;
                    case ConsoleKey.F4:
                        Console.Clear();
                        _viewMenuFuncionario.IniciaMenuFuncionario(_funcionarioDao, _viewFuncionario);
                        break;
                    case ConsoleKey.F5:
                        Console.Clear();
                        _viewMenuOperacoes.StartMenuOperacoes(_viewConta, _viewRelatorio, _viewTransferencia, _viewDeposito, _viewSaque, _relatorioDao, _contaDao);
                        break;
                }
            } while (_opcao.Key != ConsoleKey.F12);
        }
    }
}
