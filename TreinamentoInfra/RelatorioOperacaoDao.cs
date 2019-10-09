﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoDominio;

namespace TreinamentoInfra
{
    public class RelatorioOperacaoDao
    {
        private List<Operacao> _listaOperacoes = new List<Operacao>();

        public void AdicionaNovaOperacao(Operacao operacao)
        {
            operacao.Id = PegaUltimoId() + 1;
            _listaOperacoes.Add(operacao);
        }

        public List<Operacao> RetornaOperacoes()
        {
            return _listaOperacoes;
        }
        public int PegaUltimoId()
        {
            Operacao ultimoId = _listaOperacoes.LastOrDefault();

            if (ultimoId != null)
                return ultimoId.Id;

            return 0;
        }
    }
}
