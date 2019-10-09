using System;
using Treinamento._1___VIEW.VIEW_MODEL;

namespace Treinamento._1___VIEW
{
    public class ViewPessoa
    {
        private PessoaDao _pessoaDao;

        public ViewPessoa(PessoaDao pessoaDao)
        {
            _pessoaDao = pessoaDao;
        }

        public virtual void CadastraDados()
        {
            Pessoa novapessoa;

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

            Docs _docs = new Docs();

            string _cpfCnpj = _docs.LerCPFCNPJ();
        
            string _tipoPessoa = _docs.PedeCpfOuCnpj(ref _cpfCnpj);

            novapessoa = new Pessoa(nome, cidade, dataNasc, numEndereco, _tipoPessoa, estado, _cpfCnpj);
            _pessoaDao.CadastraDados(novapessoa);

            Console.Clear();
            Console.WriteLine("Pessoa cadastrada com sucesso \n Pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
        }

        public void ListaEFormata(PessoaDao pessoaDao)
        {
            Console.Clear();
            _pessoaDao = pessoaDao;

            if (_pessoaDao.ListaDados().Count != 0)
            {
                foreach (var pessoa in _pessoaDao.ListaDados())
                {
                    Console.WriteLine($"\nID: {pessoa.Id}" +
                        $" \n Nome: {pessoa.Nome} \n Cpf: {pessoa.Cpf} \n Cnpj: {pessoa.Cnpj}" +
                        $" \n Cidade: {pessoa.NomeCidade} \n DataNascimento: {pessoa.DataNasc} " +
                        $"\n NumEndereço: {pessoa.NumeroEndereco} \n Tipo de Pessoa: {pessoa.TipoPessoa}");
                }
            }
            else
            {
                Console.WriteLine("\nNao foi encontrado nenhuma pessoa cadastrada\n");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal\n");
                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
