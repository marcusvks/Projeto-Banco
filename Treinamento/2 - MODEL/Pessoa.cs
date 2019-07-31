using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Treinamento
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; private set; }
        public string TipoPessoa { get; private set; }
        public string Cpf { get; private set; }
        public string Cnpj { get; private set; }
        public string NomeCidade { get; private set; }
        public string DataNasc{ get; private set; }
        public int NumeroEndereco { get; private set; }
        public string Uf { get; private set; }

        public Pessoa(string nome, string nomecidade, string datanasc, int numendereco, string tipopessoa, string estado, string cpfCnpj, PessoaDao ultimoId)
        {
            Nome = nome;
            DataNasc = datanasc;
            NumeroEndereco = numendereco;
            TipoPessoa = tipopessoa;
            NomeCidade = nomecidade;
            Uf = estado;
            GravaCpfOuCnpj(cpfCnpj);
        }

        public void GravaCpfOuCnpj(string cpfCnpj)
        {
            if (cpfCnpj.Length > 11)
                Cnpj = cpfCnpj;
            else
                Cpf = cpfCnpj;
        }
    }
}
