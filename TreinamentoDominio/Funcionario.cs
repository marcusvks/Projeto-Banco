using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreinamentoDominio
{
    public class Funcionario : Pessoa
    {
        public string DataAdmissao { get; private set; }
        public string Funcao { get; private set; }
        public double Salario { get; private set; }

        public Funcionario (string nome, string nomecidade, string datanasc, int numendereco, string tipopessoa, string estado, string cpfCnpj, string funcao, double salario) : base(nome, nomecidade, datanasc, numendereco, tipopessoa, estado, cpfCnpj) 
        {
            DataAdmissao = DateTime.Now.ToString();
            Funcao = funcao;
            Salario = salario;
        }

    }
}
