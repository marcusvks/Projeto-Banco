using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento._1___VIEW
{
    public class ViewContaBancaria
    {

        public void CadastraContaBancaria(ContaBancariaDao _contaDao, PessoaDao _pessoaDao, AgenciaDao _agenciaDao, ViewPessoa _pessoaView, ViewAgencia _agenciaView)
        {
            Console.WriteLine("Digite o numero da conta bancaria");
            string NumContaBancaria = Console.ReadLine();

            _agenciaView.FormataListaAgencias(_agenciaDao);

            Console.WriteLine("Selecione uma agencia acima digitando o numero do seu ID\n");
            int agenciaId = Convert.ToInt16(Console.ReadLine());

            Agencia retornoAgencia = _agenciaDao.BuscaAgenciaPorId(agenciaId);

            if (retornoAgencia != null)
            {
                Console.Clear();

                Console.WriteLine("\nInforme o dono da conta pelo ID:\n");
                int idDonoDaConta = Convert.ToInt16(Console.ReadLine());

                Pessoa donodaConta = _pessoaDao.BuscaPessoaPorId(idDonoDaConta);

                if (donodaConta != null)
                {
                    ContaBancaria novaConta = new ContaBancaria(NumContaBancaria, retornoAgencia, donodaConta);

                    _contaDao.CadastraContaBancaria(novaConta);
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
        public void FormataListaContaBancaria(ContaBancariaDao contaDao)
        {
            Console.Clear();

            if (contaDao.ListaContaBancarias().Count != 0)
            {
                foreach (var conta in contaDao.ListaContaBancarias())
                {
                    Console.WriteLine($"\nID: {conta.Id}" +
                        $" \n Conta: {conta.Conta} \n Agencia: {conta.Agencia.Nome} \n Dono da Conta: {conta.DonoDaConta.Nome}");
                }

                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal\n");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\nNão foi encontrado nenhuma conta bancaria\n");
                Console.WriteLine("Pressione qualquer tecla para voltar ao menu principal");
                Console.ReadKey();
                Console.Clear();
            }

        }
        public void MostraSaldo(ContaBancariaDao contaDao)
        {
            Console.WriteLine("\nInforme o Id da conta para verificar o saldo");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n O saldo desta conta é: {0}", contaDao.BuscaContaPorId(id).Saldo);

        }
    }
}
