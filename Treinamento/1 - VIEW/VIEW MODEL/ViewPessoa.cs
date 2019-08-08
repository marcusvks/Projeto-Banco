using System;

namespace Treinamento._1___VIEW
{
    public class ViewPessoa
    {

        public virtual void CadastraPessoa(PessoaDao _pessoaDao)
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

            novapessoa = new Pessoa(nome, cidade, dataNasc, numEndereco, _tipoPessoa, estado, _cpfCnpj);
            _pessoaDao.CadastraPessoas(novapessoa);

            Console.Clear();
            Console.WriteLine("Pessoa cadastrada com sucesso \n Pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
        }

        public void FormataListaDadosPessoa(PessoaDao pessoaDao)
        {
            Console.Clear();

            if (pessoaDao.ListaPessoas().Count != 0)
            {
                foreach (var pessoa in pessoaDao.ListaPessoas())
                {
                    Console.WriteLine($"\nID: {pessoa.Id}" +
                        $" \n Nome: {pessoa.Nome} \n Cpf: {pessoa.Cpf} \n Cnpj: {pessoa.Cnpj}" +
                        $" \n Cidade: {pessoa.NomeCidade} \n DataNascimento: {pessoa.DataNasc} " +
                        $"\n NumEndereço: {pessoa.NumeroEndereco} \n Tipo de Pessoa: {pessoa.TipoPessoa}");
                }
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal\n");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\nNao foi encontrado nenhuma pessoa cadastrada\n");
                Console.WriteLine("\nPressione qualquer tecla para voltar ao menu principal\n");
                Console.ReadKey();
                Console.Clear();
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

        public string LerCPFCNPJ()
        {
            string _cpfCnpj;
            Console.WriteLine("\nDigite seu CPJ ou CNPJ: \n");
            _cpfCnpj = Console.ReadLine();
            return _cpfCnpj;
        }
    }
}
