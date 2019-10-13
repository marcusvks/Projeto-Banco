using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoDominio;
using TreinamentoDominio.Interfaces;
using TreinamentoInfra;
using TreinamentoInfra.DaoSql;

namespace TreinamentoAplicacao.Features.OperacoesServices
{
    public class OperacoesServices : IServices<Operacao>
    {
        RelatorioOperacaoDaoSql _operacaoDaoSql = new RelatorioOperacaoDaoSql();
        RelatorioOperacaoDao _operacaoDao = new RelatorioOperacaoDao();

        public Operacao BuscaPorId(int id)
        {
            return _operacaoDaoSql.BuscaPorId(id);
        }

        public void CadastraDados(Operacao obj)
        {
            _operacaoDaoSql.CadastraDados(obj);
        }

        public List<Operacao> ListaDados()
        {
            return _operacaoDaoSql.ListaDados();
        }

        public int PegaUltimoId()
        {
            return _operacaoDaoSql.PegaUltimoId();
        }

        public void AdicionaNovaOperacao(Operacao operacao)
        {
            _operacaoDaoSql.CadastraDados(operacao);
        }

        public List<Operacao> RetornaOperacoes()
        {
            return _operacaoDaoSql.ListaDados();
        }
    }
}
