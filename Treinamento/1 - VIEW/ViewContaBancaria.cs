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

            Console.WriteLine("Selecione a agencia digitando o numero do seu ID \n");
            _agenciaView.FormataListaAgencias(_agenciaDao);

            int agenciaId = Convert.ToInt16(Console.ReadLine());

            Agencia retornoAgencia = _agenciaDao.BuscaAgenciaPorId(agenciaId);

            if (retornoAgencia != null)
            {
                Console.WriteLine("Informe o dono da conta pelo ID:");
                _pessoaView.FormataListaDadosPessoa(_pessoaDao);

                int idDonoDaConta = Convert.ToInt16(Console.ReadLine());

                Pessoa donodaConta = _pessoaDao.BuscaPessoaPorId(idDonoDaConta);

                if (donodaConta != null)
                {
                    ContaBancaria novaConta = new ContaBancaria(NumContaBancaria, retornoAgencia, donodaConta);

                    _contaDao.CadastraContaBancaria(novaConta);
                    Console.WriteLine("Conta cadastrada com sucesso \n Pressione qualquer tecla para voltar ao menu");
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
    }
}
