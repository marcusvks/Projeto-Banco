using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento._1___VIEW
{
    public class ViewRelatorio
    {
        public string Id { get; set; }
        public ContaBancaria ContaMovimentada { get; private set; }
        public ContaBancaria ContaOrigem { get; private set; }
        public string OperacaoVinculada { get; private set; }
        public string DataOperacao { get; private set; }

    }
}
