using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento._2___MODEL
{
    public class Funcionario : Pessoa
    {
        public string DataAdmissao { get; private set; }
        public string Funcao { get; private set; }
        public double Salario { get; private set; }

        public Funcionario (string nome, string nomecidade, string datanasc, int numendereco, string tipopessoa, string estado, string cpfCnpj, PessoaDao ultimoId) : base(nome, nomecidade, datanasc, numendereco, tipopessoa, estado, cpfCnpj, ultimoId) 
        {
            Nome = nome;
            DataNasc = datanasc;
            NumeroEndereco = numendereco;
            TipoPessoa = tipopessoa;
            NomeCidade = nomecidade;
            Uf = estado;
            GravaCpfOuCnpj(cpfCnpj);
        }

    }
}
