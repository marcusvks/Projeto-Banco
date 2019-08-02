﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Treinamento
{
    public class Pessoa
    {
        public int Id { get;  set; }
        public string Nome { get; protected set; }
        public string TipoPessoa { get; protected set; }
        public string Cpf { get; protected set; }
        public string Cnpj { get; protected set; }
        public string NomeCidade { get; protected set; }
        public string DataNasc{ get; protected set; }
        public int NumeroEndereco { get; protected set; }
        public string Uf { get; protected set; }

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
