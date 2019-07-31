using System;

namespace Treinamento._1___VIEW
{
    public class ViewPessoa
    {

        public void CadastraPessoa(PessoaDao _pessoaDao)
        {
            Pessoa novapessoa;
            string CpfCnpj, TipoPessoa = null;

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

            Console.WriteLine("Digite seu CPJ ou CNPJ");
            CpfCnpj = Console.ReadLine();

            string RetornoValidacao = CpfCnpj.ValidaCpfCnpj();

            if (RetornoValidacao == "cpf")
                    TipoPessoa = "Pessoa Fisica";

            else if (RetornoValidacao == "cnpj")
                    TipoPessoa = "Pessoa Juridica";

            else
                Console.WriteLine("Cpf ou Cnpj invalido");

            novapessoa = new Pessoa(nome, cidade, dataNasc, numEndereco, TipoPessoa, estado, CpfCnpj, _pessoaDao);
            _pessoaDao.CadastraPessoas(novapessoa);

            Console.Clear();
            Console.WriteLine("Pessoa cadastrada com sucesso \n Pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
        }

        public void FormataListaDadosPessoa(PessoaDao pessoaDao)
        {
            Console.Clear();

            foreach (var pessoa in pessoaDao.ListaPessoas())
            {
                Console.WriteLine($"\nID: {pessoa.Id}" +
                    $" \n Nome: {pessoa.Nome} \n Cpf: {pessoa.Cpf} \n Cnpj: {pessoa.Cnpj}" +
                    $" \n Cidade: {pessoa.NomeCidade} \n DataNascimento: {pessoa.DataNasc} " +
                    $"\n NumEndereço: {pessoa.NumeroEndereco} \n Tipo de Pessoa: {pessoa.TipoPessoa}");
            }

            Console.WriteLine("\n Pressione qualquer tecla para voltar ao menu inicial");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
