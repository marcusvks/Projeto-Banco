using System;

namespace Treinamento._1___VIEW
{
    public class ViewPessoa
    {

        public void CadastraPessoa(PessoaDao _pessoaDao)
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
         
            string _cpfCnpj = LerCPFCNPJ();
        
            string _tipoPessoa = PedeCpfOuCnpj(ref _cpfCnpj);

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
        }

        public string PedeCpfOuCnpj(ref string _cpfCnpj)
        {
            do
            {
                string RetornoValidacao = _cpfCnpj.ValidaCpfCnpj();

                if (RetornoValidacao == "cpf")
                    return "Pessoa Fisica";

                else if (RetornoValidacao == "cnpj")
                    return "Pessoa Juridica";
                else
                {
                    Console.Clear();
                    Console.WriteLine("Cpf ou Cnpj invalido");
                }

                _cpfCnpj = LerCPFCNPJ();

            } while (true);

        }

        private string LerCPFCNPJ()
        {
            string _cpfCnpj;
            Console.WriteLine("\nDigite seu CPJ ou CNPJ: \n");
            _cpfCnpj = Console.ReadLine();
            return _cpfCnpj;
        }

        public void MostraSaldo(ContaBancariaDao contaDao)
        {
            Console.WriteLine("\nInforme o Id da conta para verificar o saldo");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n O saldo desta conta é: {0}", contaDao.BuscaContaPorId(id).Saldo);
            
        }
    }
}
