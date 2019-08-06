using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento._2___MODEL;
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

        //dao
        private ContaBancariaDao _contaDao = new ContaBancariaDao();
        private AgenciaDao _agenciaDao = new AgenciaDao();
        private PessoaDao _pessoaDao = new PessoaDao();
        private RelatorioOperacaoDao _relatorioDao = new RelatorioOperacaoDao();

        public void IniciaMenu()
        {

            Console.WriteLine("\n É PRECISO PRIMEIRO TER PESSOA E AGENCIA PRA FUNGA - 1 é operacao de Deposito, 2 de Saque, 3 de Transferencia \n");

            do
            {
                Console.WriteLine("\n PRESSIONE: \n\n F1 Para operacoes com Pessoa \n F2 Para operacoes com Conta Bancaria \n F3 Para operacoes com Agencia \n F4 Para operacoes com Funcionario \n F5 para listar as Operacoes \n F12 para sair");
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
                    case ConsoleKey.F6:
                        Console.Clear();
                        _viewSaque.RealizaSaque(_relatorioDao, _contaDao, _viewConta);
                        break;
                    case ConsoleKey.F7:
                        Console.Clear();
                        _viewDeposito.RealizaDeposito(_contaDao, _viewConta, _relatorioDao);
                        break;
                    case ConsoleKey.F8:
                        Console.Clear();
                        _viewTransferencia.RealizaTransferencia(_viewConta, _relatorioDao, _contaDao);
                        break;
                    case ConsoleKey.F9:
                        Console.Clear();
                        _viewRelatorio.VisualizaRelatorioDeOperacoes(_relatorioDao);
                        break;
                    case ConsoleKey.F10:
                        Console.Clear();
                        _viewPessoa.MostraSaldo(_contaDao);
                        break;
                }
            } while (_opcao.Key != ConsoleKey.F12);
        }
    }
}
