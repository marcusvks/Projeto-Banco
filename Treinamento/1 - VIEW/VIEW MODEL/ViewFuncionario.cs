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

            Console.WriteLine("Digite a funçao do funcionario");
            string funcao = Console.ReadLine();

            Console.WriteLine("Digite o salario do funcionario");
            double salario = Convert.ToDouble(Console.ReadLine());

            string _cpfCnpj = LerCPFCNPJ();

            string _tipoPessoa = PedeCpfOuCnpj(ref _cpfCnpj);

            novoFuncionario = new Funcionario(nome, cidade, dataNasc, numEndereco, _tipoPessoa, estado, _cpfCnpj, funcao, salario);
            _funcionarioDao.CadastraFuncionarios(novoFuncionario);

            Console.Clear();
            Console.WriteLine("Funcionario cadastrado com sucesso \n Pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
        }

        public void FormataListaDadosFuncionario(FuncionarioDao funcionarioDao)
        {
            Console.Clear();

            if (funcionarioDao.ListaFuncionarios().Count != 0)
            {
                foreach (var funcionario in funcionarioDao.ListaFuncionarios())
                {
                    Console.WriteLine($"\nID: {funcionario.Id}" +
                        $" \n Nome: {funcionario.Nome} \n Cpf: {funcionario.Cpf} \n Cnpj: {funcionario.Cnpj}" +
                        $" \n Cidade: {funcionario.NomeCidade} \n DataNascimento: {funcionario.DataNasc} " +
                        $"\n NumEndereço: {funcionario.NumeroEndereco} \n Funcao do Funcionario: {funcionario.Funcao} \n Salario do Funcionario: {funcionario.Salario}");
                }

                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal\n");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\n Nao foi encontrado nenhuma pessoa cadastrada");
            }

        }
    }
}
