using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento
{
    public class ContaBancaria
    {
        public int Id { get; set; }
        public string Conta { get; private set; }
        public Agencia Agencia { get; private set; }
        public Pessoa DonoDaConta { get; private set; }
        public double Saldo { get; private set; }
        public string DataAbertura { get; private set; }

        public ContaBancaria(string conta, Agencia agencia, Pessoa donodaconta)
        {
            Conta = conta;
            Agencia = agencia;
            DonoDaConta = donodaconta;
            DataAbertura = DateTime.Now.ToString();
        }
    }
}
