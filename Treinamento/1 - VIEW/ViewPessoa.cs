using System;

namespace Treinamento._1___VIEW
{
    public class ViewPessoa
    {
        private string _cpf;
        private string _cnpj;
        private string _cpfCnpj;
        private PessoaDao _pessoaDao = new PessoaDao();
        public void CadastraPessoa()
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

            Console.WriteLine("Se for pessoa fisica digite F se for juridica J");
            string tipoPessoa = Console.ReadLine();

            if (tipoPessoa.ToUpper() == "F")
            {
                Console.WriteLine("Digite seu cpf");
                _cpf = Console.ReadLine();

            }
            else if (tipoPessoa.ToUpper() == "J")
            {
                Console.WriteLine("Digite seu cnpj");
                _cnpj = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Tipo de pessoa invalido");
            }

            if (!string.IsNullOrEmpty(_cpf))
            {
                ValidadorDeDocumento.ValidaCpf(_cpf);
                _cpfCnpj = _cpf;
            }
            else
            {
                ValidadorDeDocumento.ValidaCnpj(_cnpj);
                _cpfCnpj = _cnpj;
            }

            novapessoa = new Pessoa(nome, cidade, dataNasc, numEndereco, tipoPessoa, estado, _cpfCnpj);
            _pessoaDao.CadastraPessoas(novapessoa);

            Console.WriteLine("Pessoa cadastrada com sucesso");
        }

        public bool VerificaCpf(string cpf)
        {
            return ValidadorDeDocumento.ValidaCpf(cpf);

        }

        public bool VerificaCnpj(string cnpj)
        {
            return ValidadorDeDocumento.ValidaCpf(cnpj);
        }

        public void FormataListaDadosPessoa()
        {
            foreach (var pessoa in _pessoaDao.ListaPessoas())
            {
                Console.WriteLine($"\nID: {pessoa.RetornaId()}" +
                    $" \n Nome: {pessoa.RetornaNome()} \n Cpf: {pessoa.RetornaCpf()} \n Cnpj: {pessoa.RetornaCnpj()}" +
                    $" \n Cidade: {pessoa.RetornaNomeCidade()} \n DataNascimento: {pessoa.RetornaDataNasc()} " +
                    $"\n NumEndereço: {pessoa.RetornaNumeroEndereco()} \n Tipo de Pessoa: {pessoa.RetornaTipoPessoa()}");
            }
        }
    }
}
