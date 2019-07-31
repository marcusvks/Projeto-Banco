using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento
{
    public class Agencia
    {
        private int _id { get; set; }
        private string _codigo { get; set; }
        private string _nome { get; set; }
        private string _nomeCidade { get; set; }
        private string _uf { get; set; }

        public Agencia(string codigo, string nome, string nomecidade, string uf)
        {
            _id += 1;
            _codigo = codigo;
            _nome = nome;
            _nomeCidade = nomecidade;
            _uf = uf;
        }

        public int RetornaId()
        {
            return _id;
        }

        public string RetornaCodigo()
        {
            return _codigo;
        }

        public string RetornaNome()
        {
            return _nome;
        }

        public string RetornaNomeCidade()
        {
            return _nomeCidade;
        }

        public string RetornaUf()
        {
            return _uf;
        }
    }
}
