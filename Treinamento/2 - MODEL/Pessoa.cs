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
        private int _id { get; set; }
        private string _nome { get; set; }
        private string _tipoPessoa { get; set; }
        private string _cpf { get; set; }
        private string _cnpj { get; set; }
        private string _nomeCidade { get; set; }
        private string _dataNasc{ get; set; }
        private int _numeroEndereco { get; set; }
        private string _uf { get; set; }

        public Pessoa(string nome, string nomecidade, string datanasc, int numendereco, string tipopessoa, string estado, string cpfCnpj, PessoaDao ultimoId)
        {
            _nome = nome;
            _dataNasc = datanasc;
            _numeroEndereco = numendereco;
            _tipoPessoa = (tipopessoa.ToUpper() == "F") ? "Pessoa Fisica" : "Pessoa Juridica";
            _nomeCidade = nomecidade;
            _uf = estado;
            GravaCpfOuCnpj(cpfCnpj);
        }

        public int RetornaId()
        {
            return _id;
        }

        public string RetornaNome()
        {
            return _nome;
        }
        public string RetornaCpf()
        {
            return _cpf;
        }
        public string RetornaCnpj()
        {
            return _cnpj;
        }

        public string RetornaNomeCidade()
        {
            return _nomeCidade;
        }

        public string RetornaDataNasc()
        {
            return _dataNasc;
        }

        public int RetornaNumeroEndereco()
        {
            return _numeroEndereco;
        }

        public string RetornaTipoPessoa()
        {
            return _tipoPessoa;
        }

        public string RetornaUf()
        {
            return _uf;
        }

        public void SetaId(int id)
        {
            _id = id;
        }

        public void GravaCpfOuCnpj(string cpfCnpj)
        {
            if (cpfCnpj.Length > 11)
                _cnpj = cpfCnpj;
            else
                _cpf = cpfCnpj;
        }
    }
}
