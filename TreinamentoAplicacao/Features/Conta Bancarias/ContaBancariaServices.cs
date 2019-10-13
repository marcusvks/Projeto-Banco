using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoDominio;
using TreinamentoDominio.Interfaces;
using TreinamentoInfra;
using TreinamentoInfra.DaoSql;

namespace TreinamentoAplicacao.Features.ContaBancariaServices
{
    public class ContaBancariaServices : IServices<ContaBancaria>
    {
        ContaBancariaDaoSql _contaDaoSql = new ContaBancariaDaoSql();
        ContaBancariaDao _contaDao = new ContaBancariaDao();

        public ContaBancaria BuscaPorId(int id)
        {
            return _contaDao.BuscaPorId(id);
        }

        public void CadastraDados(ContaBancaria obj)
        {
            _contaDao.CadastraDados(obj);
        }

        public List<ContaBancaria> ListaDados()
        {
            return _contaDao.ListaDados();
        }

        public int PegaUltimoId()
        {
            return _contaDao.PegaUltimoId();
        }
    }
}
