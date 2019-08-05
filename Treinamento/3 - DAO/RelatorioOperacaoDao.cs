using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento._2___MODEL;

namespace Treinamento._3___DAO
{
    public class RelatorioOperacaoDao
    {
        private List<Operacao> _listaOperacoes = new List<Operacao>();

        public void AdicionaNovaOperacao(Operacao operacao)
        {
            _listaOperacoes.Add(operacao);
        }

        public List<Operacao> RetornaOperacoes()
        {
            return _listaOperacoes;
        }
    }
}
