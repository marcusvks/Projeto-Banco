using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinamentoDominio
{
    public class Agencia
    {
        public int Id { get;  set; }
        public string Codigo { get;  set; }
        public string Nome { get;  set; }
        public string NomeCidade { get; set; }
        public string Uf { get; set; }

        public Agencia()
        {
            
        }
        public Agencia(string codigo, string nome, string nomecidade, string uf)
        {
            Codigo = codigo;
            Nome = nome;
            NomeCidade = nomecidade;
            Uf = uf;
        }
    }
}
