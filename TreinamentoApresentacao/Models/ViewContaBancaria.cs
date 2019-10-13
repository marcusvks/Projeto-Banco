using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento._1___VIEW.VIEW_MODEL;
using TreinamentoAplicacao.Features.ContaBancariaServices;
using TreinamentoAplicacao.Features.PessoasServices;
using TreinamentoDominio;
using TreinamentoDominio.Interfaces;
using TreinamentoInfra;
using TreinamentoInfra.Interface;

namespace TreinamentoApresentacao.Models
{
    public class ViewContaBancaria : IViewModel<ContaBancaria>
    {
        private ContaBancariaServices _contaServices;
        private PessoasServices _pessoaServices;
        private IServices<Agencia> _agenciaServices;
        private ViewPessoa _pessoaView;
        private ViewAgencia _viewAgencia;

        public ViewContaBancaria(ContaBancariaServices contaServices, PessoasServices pessoaServices, IServices<Agencia> agenciaServices, ViewPessoa viewPessoa, ViewAgencia viewAgencia)
        {
            _contaServices = _contaServices;
            _pessoaServices = _pessoaServices;
            _agenciaServices = _agenciaServices;
            _pessoaView = viewPessoa;
            _viewAgencia = viewAgencia;
        }

        public void CadastraDados()
        {
            Console.WriteLine("Digite o numero da conta bancaria");
            string NumContaBancaria = Console.ReadLine();

            _viewAgencia.ListaEFormata();

            Console.WriteLine("Selecione uma agencia acima digitando o numero do seu ID\n");
            int agenciaId = Convert.ToInt16(Console.ReadLine());

            Agencia retornoAgencia = _agenciaServices.BuscaPorId(agenciaId);

            if (retornoAgencia != null)
            {
                Console.Clear();

                Console.WriteLine("\nInforme o dono da conta pelo ID:\n");
                int idDonoDaConta = Convert.ToInt16(Console.ReadLine());

                Pessoa donodaConta = _pessoaServices.BuscaPorId(idDonoDaConta);

                if (donodaConta != null)
                {
                    ContaBancaria novaConta = new ContaBancaria(NumContaBancaria, retornoAgencia, donodaConta);

                    _contaServices.CadastraDados(novaConta);
                    Console.WriteLine("\n {0} cadastrado com sucesso \n Pressione qualquer tecla para voltar ao menu", donodaConta.Nome);
                }
                else
                {
                    Console.WriteLine("Pessoa nao encontrada \n Pressione qualquer tecla para voltar ao menu");
                }
            }
            else
            {
                Console.WriteLine("Agencia nao encontrada \n Pressione qualquer tecla para voltar ao menu");
            }

            Console.ReadKey();
            Console.Clear();
        }
        public void ListaEFormata()
        {
            Console.Clear();

            if (_contaServices.ListaDados().Count != 0)
            {
                foreach (var conta in _contaServices.ListaDados())
                {
                    Console.WriteLine($"\nID: {conta.Id}" +
                        $" \n Conta: {conta.Conta} \n Agencia: {conta.Agencia.Nome} \n Dono da Conta: {conta.DonoDaConta.Nome}");
                }
            }
            else
            {
                Console.WriteLine("\nNão foi encontrado nenhuma conta bancaria\n");
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }

        }
        public void MostraSaldo(ContaBancariaServices contaServices)
        {
            Console.WriteLine("\nInforme o Id da conta para verificar o saldo");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n O saldo desta conta é: {0}", contaServices.BuscaPorId(id).Saldo);

        }
    }
}
