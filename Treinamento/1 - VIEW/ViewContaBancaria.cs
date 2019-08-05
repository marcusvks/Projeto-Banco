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

            foreach (var conta in contaDao.ListaContaBancarias())
            {
                Console.WriteLine($"\nID: {conta.Id}" +
                    $" \n Conta: {conta.Conta} \n Agencia: {conta.Agencia.Nome} \n Dono da Conta: {conta.DonoDaConta.Nome}");
            }
        }
    }
}
