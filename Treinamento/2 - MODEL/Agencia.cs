using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento
{
    public class Agencia
    {
        public int Id { get; private set; }
        public string Codigo { get; private set; }
        public string Nome { get; private set; }
        public string NomeCidade { get; private set; }
        public string Uf { get; private set; }

        public Agencia(string codigo, string nome, string nomecidade, string uf)
        {
            Codigo = codigo;
            Nome = nome;
            NomeCidade = nomecidade;
            Uf = uf;
        }
    }
}
