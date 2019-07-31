using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento
{
    public class ContaBancaria
    {
        private int _id { get; set; }
        private string _conta { get; set; }
        public Agencia Agencia { get; set; }
        private Pessoa _donoDaConta { get; set; }
        private double _saldo { get; set; }
        private string _dataAbertura { get; set; }

        public ContaBancaria(string conta, Agencia agencia, Pessoa donodaconta)
        {
            _id += 1;
            _conta = conta;
            Agencia = agencia;
            _donoDaConta = donodaconta;
            _dataAbertura = DateTime.Now.ToString();
        }

        public int RetornaId()
        {
            return _id;
        }

        public string RetornaConta()
        {
            return _conta;
        }

        public Pessoa RetornaDonoDaConta()
        {
            return _donoDaConta;
        }

        public double PegaSaldo()
        {
            return _saldo;
        }

        public string RetornaDataAbertura()
        {
            return _dataAbertura;
        }
    }
}
