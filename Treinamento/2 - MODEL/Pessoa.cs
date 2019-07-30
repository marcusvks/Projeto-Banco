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

        public Pessoa(string nome, string nomecidade, string datanasc, int numendereco, string tipopessoa, string estado, string cpfCnpj)
        {
            _nome = nome;
            _dataNasc = datanasc;
            _numeroEndereco = numendereco;
            _tipoPessoa = (tipopessoa.ToUpper() == "F") ? "Pessoa Fisica" : "Pessoa Juridica";
            _nomeCidade = nomecidade;
            _uf = estado;
            _id += 1;

            if (cpfCnpj.Length > 11)
            {
                _cnpj = cpfCnpj;
            }
            else
            {
                _cpf = cpfCnpj;
            }
        }

        public int GetId()
        {
            return _id;
        }

        public string GetNome()
        {
            return _nome;
        }
        public string GetCpf()
        {
            return _cpf;
        }
        public string GetCnpj()
        {
            return _cnpj;
        }

        public string GetNomeCidade()
        {
            return _nomeCidade;
        }

        public string GetDataNasc()
        {
            return _dataNasc;
        }

        public int GetNumeroEndereco()
        {
            return _numeroEndereco;
        }

        public string GetTipoPessoa()
        {
            return _tipoPessoa;
        }

        public string GetUf()
        {
            return _uf;
        }
    }
}
