using System;

namespace Treinamento._1___VIEW
{
    public class ViewPessoa
    {
        private string _tipoPessoa, _cpfCnpj = null;

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

            PedeCpfOuCnpj();

            novapessoa = new Pessoa(nome, cidade, dataNasc, numEndereco, _tipoPessoa, estado, _cpfCnpj, _pessoaDao);
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

        public void PedeCpfOuCnpj()
        {
            bool ControlValidacao = false;

            do
            {
                ControlValidacao = false;

                Console.WriteLine("\nDigite seu CPJ ou CNPJ: \n");
                _cpfCnpj = Console.ReadLine();

                string RetornoValidacao = _cpfCnpj.ValidaCpfCnpj();

                if (RetornoValidacao == "cpf")
                    _tipoPessoa = "Pessoa Fisica";

                else if (RetornoValidacao == "cnpj")
                    _tipoPessoa = "Pessoa Juridica";
                else
                {
                    Console.Clear();
                    Console.WriteLine("Cpf ou Cnpj invalido");
                    ControlValidacao = true;
                    
                }

            } while (ControlValidacao == true);

        }
    }
}
