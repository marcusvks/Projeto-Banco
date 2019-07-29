using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento
{
    public class Program
    {
        public static string Cpf, Cnpj;
        public static string TipoPessoa;
        public static AgenciaDao agenciaDao = new AgenciaDao();
        public static ContaBancariaDao contaDao = new ContaBancariaDao();
        public static PessoaDao pessoaDao = new PessoaDao();
        public static int OpcaoMenu;
        static void Main(string[] args)
        {
            Console.WriteLine("\n É PRECISO PRIMEIRO TER PESSOA E AGENCIA PRA FUNGA \n");
            while (OpcaoMenu != 9)
            {
                Console.WriteLine("\n Digite: \n 1 para cadastrar uma pessoa fisica ou jurídica \n 2 para cadastrar uma conta bancaria \n 3 para cadastrar uma agencia \n 4 para listar as pessoas \n 5 para listar as agencias \n 9 para sair");
                OpcaoMenu = Convert.ToInt16(Console.ReadLine());

                switch (OpcaoMenu)
                {
                    case 1:
                        CadastraPessoa();
                        break;
                    case 2:
                        CadastraContaBancaria();
                        break;
                    case 3:
                        CadastraAgencia();
                        break;
                    case 4:
                        ListaPessoas();
                        break;
                    case 5:
                        ListaAgencias();
                        break;
                }
            }

        }

        public static bool VerificaCpf(string cpf)
        {
            return ValidadorDePessoa.ValidaCpf(cpf);

        }

        public static bool VerificaCnpj(string cnpj)
        {
            return ValidadorDePessoa.ValidaCpf(cnpj);
        }

        public static void ListaDadosPessoa(Pessoa pessoa)
        {
            Console.WriteLine("\nID: {0} \n Nome: {1} \n Cpf: {2} \n Cnpj: {3} \n Cidade: {4} \n DataNascimento: {5} \n NumEndereço: {6} \n Tipo de Pessoa: {7}", pessoa.GetId(), pessoa.GetNome(), pessoa.Cpf, pessoa.Cnpj, pessoa.GetNomeCidade(), pessoa.GetDataNasc(), pessoa.GetNumeroEndereco(), pessoa.GetTipoPessoa());
        }

        public static void CadastraPessoa()
        {
            Pessoa novapessoa;

            Console.WriteLine("Digite seu nome");
            string Nome = Console.ReadLine();

            Console.WriteLine("Digite sua Cidade");
            string Cidade = Console.ReadLine();

            Console.WriteLine("Digite sua data de nascimento");
            string DataNasc = Console.ReadLine();

            Console.WriteLine("Digite seu estado");
            string Estado = Console.ReadLine();

            Console.WriteLine("Digite o numero do endereço");
            int Numendereco = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Se for pessoa fisica digite F se for juridica J");
            string TipoPessoa = Console.ReadLine();

            novapessoa = new Pessoa(Nome, Cidade, DataNasc, Numendereco, TipoPessoa, Estado);

            if (TipoPessoa.ToUpper() == "F")
            {
                Console.WriteLine("Digite seu cpf");
                Cpf = Console.ReadLine();

                if (VerificaCpf(Cpf) != false)
                {
                    novapessoa.Cpf = Cpf;
                }
                else
                {
                    Console.WriteLine("Cpf invalido");
                    throw new ApplicationException("Cpf invalido");
                }
            }
            else if (TipoPessoa.ToUpper() == "J")
            {
                Console.WriteLine("Digite seu cnpj");
                Cnpj = Console.ReadLine();

                if (VerificaCnpj(Cnpj) != false)
                {
                    novapessoa.Cnpj = Cnpj;
                }
                else
                {
                    Console.WriteLine("Cnpj invalido");
                    throw new ApplicationException("Cnpj invalido");
                }
            }
            else
            {
                Console.WriteLine("Tipo de pessoa invalido");
            }

            pessoaDao.CadastraPessoas(novapessoa);
            Console.WriteLine("Pessoa cadastrada com sucesso");
        }

        public static void CadastraContaBancaria()
        {
            Console.WriteLine("Digite o numero da conta bancaria");
            string NumContaBancaria = Console.ReadLine();

            Console.WriteLine("Selecione a agencia digitando o numero do seu ID \n");
            ListaAgencias();
            int agenciaId = Convert.ToInt16(Console.ReadLine());

            Agencia retornoAgencia = agenciaDao.BuscaAgenciaPorId(agenciaId);

            if (retornoAgencia != null)
            {
                Console.WriteLine("Informe o dono da conta pelo ID:");
                ListaPessoas();
                int idDonoDaConta = Convert.ToInt16(Console.ReadLine());

                Pessoa donodaConta = pessoaDao.BuscaPessoaPorId(idDonoDaConta);

                if (donodaConta != null)
                {
                    ContaBancaria novaConta = new ContaBancaria(NumContaBancaria, retornoAgencia, donodaConta);

                    contaDao.CadastraContaBancaria(novaConta);
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
        public static void CadastraAgencia()
        {
            Console.WriteLine("Digite o codigo da agencia");
            string CodAgencia = Console.ReadLine();

            Console.WriteLine("Digite o nome da agencia");
            string NomeAgencia = Console.ReadLine();

            Console.WriteLine("Digite o nome da cidade");
            string NomeCidade = Console.ReadLine();

            Console.WriteLine("Digite o estado");
            string Estado = Console.ReadLine();

            Agencia agencia = new Agencia(CodAgencia, NomeAgencia, NomeCidade, Estado);

            agenciaDao.CadastraAgencia(agencia);
            Console.WriteLine("Agencia cadastrada com sucesso");
        }

        public static void ListaAgencias()
        {
            foreach (var agencia in agenciaDao.ListaAgencias())
            {
                Console.WriteLine("\n ID: {0} Nome: {1} Codigo: {2} Cidade: {3} Estado: {4} \n",
                    agencia.GetId(), agencia.GetNome(), agencia.GetCodigo(), agencia.GetNomeCidade(), agencia.GetUf());
            }

        }

        public static void ListaPessoas()
        {
            foreach (var pessoa in pessoaDao.ListaPessoas())
            {
                Console.WriteLine("\n ID: {0} Nome: {1} Data Nasc: {2} Numero Endereco: {3} Tipo de Pessoa: {4} Cidade: {5} Estado: {6}",
                    pessoa.GetId(), pessoa.GetNome(), pessoa.GetDataNasc(), pessoa.GetNumeroEndereco(), pessoa.GetTipoPessoa(), pessoa.GetNomeCidade(), pessoa.GetUf());
            }
        }
    }
}
