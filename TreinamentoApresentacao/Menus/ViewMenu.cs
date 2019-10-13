using System;
using System.Text;
using TreinamentoAplicacao.Features.AgenciasServices;
using TreinamentoAplicacao.Features.ContaBancariaServices;
using TreinamentoAplicacao.Features.FuncionariosServices;
using TreinamentoAplicacao.Features.OperacoesServices;
using TreinamentoAplicacao.Features.PessoasServices;
using TreinamentoApresentacao.Models;
using TreinamentoInfra.Operaçoes;

namespace TreinamentoApresentacao.Menus
{
    public class ViewMenu
    {
        private static ConsoleKeyInfo _opcao;

        //dao
        private static readonly ContaBancariaServices _contaServices = new ContaBancariaServices();
        private static readonly AgenciaServices _agenciaServices = new AgenciaServices();
        private static readonly PessoasServices _pessoaServices = new PessoasServices();
        private static readonly OperacoesServices _relatorioDao = new OperacoesServices();
        private static readonly FuncionariosServices _funcionarioDao = new FuncionariosServices();

        //View Menu
        private static readonly ViewMenuAgencia _viewMenuAgencia = new ViewMenuAgencia();
        private static readonly ViewMenuConta _viewMenuConta = new ViewMenuConta();
        private static readonly ViewMenuFuncionario _viewMenuFuncionario = new ViewMenuFuncionario();
        private static readonly ViewMenuPessoa _viewMenuPessoa = new ViewMenuPessoa();
        private static readonly ViewMenuOperacoes _viewMenuOperacoes = new ViewMenuOperacoes();

        //view
        private static readonly ViewAgencia _viewAgencia = new ViewAgencia(_agenciaServices);
        //private static ViewContaBancaria _viewContaBancaria = new ViewContaBancaria(_contaServices, _pessoaServices, _agenciaServices, _viewPessoa, _viewAgencia);
        private static readonly ViewPessoa _viewPessoa = new ViewPessoa(_pessoaServices);
        private static readonly ViewSaque _viewSaque = new ViewSaque();
        private static readonly ViewDeposito _viewDeposito = new ViewDeposito();
        private static readonly ViewTransferencia _viewTransferencia = new ViewTransferencia();
        private static readonly ViewContaBancaria _viewConta = new ViewContaBancaria(_contaServices, _pessoaServices, _agenciaServices, _viewPessoa, _viewAgencia);
        private static readonly ViewRelatorioOperacoes _viewRelatorio = new ViewRelatorioOperacoes();
        private static readonly ViewFuncionario _viewFuncionario = new ViewFuncionario(_funcionarioDao);

        public ViewMenu()
        {
            _pessoaServices.CadastrarPessoasFisicas();
            _agenciaServices.CadastraAgencias();

            StringBuilder listaCompleta;

            var a = _pessoaServices.ListaDados();

            listaCompleta = new StringBuilder();
            foreach (var item in a)
                listaCompleta.Append(item.ToString());
            
        }
        
        public void IniciaMenu()
        {
            Console.Clear();

            do
            {
                Console.WriteLine("\n PRESSIONE: \n\n F1 Para operacoes com Pessoa \n F2 Para operacoes com Conta Bancaria \n F3 Para operacoes com Agencia \n F4 Para operacoes com Funcionario \n F5 Para fazer as Operacoes \n F12 para sair");
                _opcao = Console.ReadKey();
                switch (_opcao.Key)
                {
                    case ConsoleKey.F1:
                        Console.Clear();
                        _viewMenuPessoa.StartMenuPessoa(_viewPessoa, this, _pessoaServices);
                        break;
                    case ConsoleKey.F2:
                        Console.Clear();
                        _viewMenuConta.IniciaMenuConta(_viewConta,_viewPessoa, _viewAgencia, _agenciaServices, _contaServices, _pessoaServices);
                        break;
                    case ConsoleKey.F3:
                        Console.Clear();
                        _viewMenuAgencia.IniciaMenuAgencia(_viewAgencia, this, _agenciaServices);
                        break;
                    case ConsoleKey.F4:
                        Console.Clear();
                        _viewMenuFuncionario.IniciaMenuFuncionario(_funcionarioDao, this, _viewFuncionario);
                        break;
                    case ConsoleKey.F5:
                        Console.Clear();
                        _viewMenuOperacoes.StartMenuOperacoes(_viewConta, _viewRelatorio, this, _viewTransferencia, _viewDeposito, _viewSaque, _relatorioDao, _contaServices);
                        break;
                }
            } while (_opcao.Key != ConsoleKey.F12);
        }
    }
}
