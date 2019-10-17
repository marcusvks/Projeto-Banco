using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoDominio;
using TreinamentoDominio.Interfaces;
using TreinamentoInfra;
using TreinamentoInfra.DaoSql;
using TreinamentoInfra.Interface;

namespace TreinamentoAplicacao.Features.OperacoesServices
{
    public class OperacoesServices : IServices<Operacao>
    {
        private IDao<Operacao> _operacaoDao;

        public Operacao BuscaPorId(int id)
        {
            return _operacaoDao.BuscaPorId(id);
        }

        public void CadastraDados(Operacao obj)
        {
            _operacaoDao.CadastraDados(obj);
        }

        public List<Operacao> ListaDados()
        {
            return _operacaoDao.ListaDados();
        }

        public int PegaUltimoId()
        {
            return _operacaoDao.PegaUltimoId();
        }

        public void AdicionaNovaOperacao(Operacao operacao)
        {
            _operacaoDao.CadastraDados(operacao);
        }

        public List<Operacao> RetornaOperacoes()
        {
            return _operacaoDao.ListaDados();
        }
    }
}
