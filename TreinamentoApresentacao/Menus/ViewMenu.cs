using System;
using System.Text;
using TreinamentoAplicacao.Features.AgenciasServices;
using TreinamentoAplicacao.Features.ContaBancariaServices;
using TreinamentoAplicacao.Features.FuncionariosServices;
using TreinamentoAplicacao.Features.OperacoesServices;
using TreinamentoAplicacao.Features.PessoasServices;
using TreinamentoApresentacao.Models;
using TreinamentoDominio;
using TreinamentoDominio.Interfaces;
using TreinamentoInfra.Interface;
using TreinamentoInfra.Operaçoes;

namespace TreinamentoApresentacao.Menus
{
    public class ViewMenu
    {
        private static ConsoleKeyInfo _opcao;

        private static readonly IDao<Pessoa> _pessoaDao;
        private static readonly IDao<Funcionario> _funcionarioDao;
        private static readonly IDao<ContaBancaria> _contaDao;
        private static readonly IDao<Agencia> _agenciaDao;
        private static readonly IDao<Operacao> _operacaoDao;

        private static readonly IServices<Pessoa> _pessoaServices;
        private static readonly IServices<Funcionario> _funcionarioServices;
        private static readonly IServices<ContaBancaria> _contaServices;
        private static readonly IServices<Agencia> _agenciaServices;
        private static readonly IServices<Operacao> _operacaoServices;


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
