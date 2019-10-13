using System;
using TreinamentoAplicacao.Features.PessoasServices;
using TreinamentoDominio;
using TreinamentoInfra;

namespace TreinamentoApresentacao.Models
{
    public class ViewPessoa
    {
        private PessoasServices _pessoaServices;

        public ViewPessoa(PessoasServices pessoaServices)
        {
            _pessoaServices = pessoaServices;
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
            _pessoaServices.CadastraDados(novapessoa);

            Console.Clear();
            Console.WriteLine("Pessoa cadastrada com sucesso \n Pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
        }

        public void ListaEFormata(PessoasServices pessoaServices)
        {
            Console.Clear();
            _pessoaServices = pessoaServices;

            if (_pessoaServices.ListaDados().Count != 0)
            {
                foreach (var pessoa in _pessoaServices.ListaDados())
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
