using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento._1___VIEW
{
    public class ViewContaBancaria
    {
        private ContaBancariaDao _contaDao = new ContaBancariaDao();
        private ViewAgencia _agenciaView = new ViewAgencia();
        private ViewPessoa _pessoaView = new ViewPessoa();
        private AgenciaDao _agenciaDao = new AgenciaDao();
        private PessoaDao _pessoaDao = new PessoaDao();

        public void CadastraContaBancaria()
        {
            Console.WriteLine("Digite o numero da conta bancaria");
            string NumContaBancaria = Console.ReadLine();

            Console.WriteLine("Selecione a agencia digitando o numero do seu ID \n");
            _agenciaView.FormataListaAgencias();

            int agenciaId = Convert.ToInt16(Console.ReadLine());

            Agencia retornoAgencia = _agenciaDao.BuscaAgenciaPorId(agenciaId);

            if (retornoAgencia != null)
            {
                Console.WriteLine("Informe o dono da conta pelo ID:");
                _pessoaView.FormataListaDadosPessoa();

                int idDonoDaConta = Convert.ToInt16(Console.ReadLine());

                Pessoa donodaConta = _pessoaDao.BuscaPessoaPorId(idDonoDaConta);

                if (donodaConta != null)
                {
                    ContaBancaria novaConta = new ContaBancaria(NumContaBancaria, retornoAgencia, donodaConta);

                    _contaDao.CadastraContaBancaria(novaConta);
                    Console.WriteLine("Conta cadastrada com sucesso");
                }
                else
                {
                    Console.WriteLine("Pessoa nao encontrada");
                }
            }
            else
            {
                Console.WriteLine("Agencia nao encontrada");
            }
        }
    }
}
