using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento._2___MODEL;
using Treinamento._3___DAO;

namespace Treinamento._1___VIEW
{
    public class ViewFuncionario : ViewPessoa
    {
        public void CadastraFuncionario(FuncionarioDao _funcionarioDao)
        {
            Funcionario novoFuncionario;

            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua Cidade");
            string cidade = Console.ReadLine();

            Console.WriteLine("Digite sua data de nascimento");
            string dataNasc = Console.ReadLine();

            Console.WriteLine("Digite seu estado");
            string estado = Console.ReadLine();

            Console.WriteLine("Digite o numero do endereço");
            int numEndereco = Convert.ToInt32(Console.ReadLine());

            string _cpfCnpj = LerCPFCNPJ();

            string _tipoPessoa = PedeCpfOuCnpj(ref _cpfCnpj);

            //novoFuncionario = new Funcionario(nome, cidade, dataNasc, numEndereco, _tipoPessoa, estado, _cpfCnpj, _funcionarioDao);

            //_funcionarioDao.CadastraFuncionarios(novoFuncionario);

            //Console.Clear();
            //Console.WriteLine("Funcionario cadastrado com sucesso \n Pressione qualquer tecla para voltar ao menu");
            //Console.ReadKey();
            //Console.Clear();
        }
    }
}
