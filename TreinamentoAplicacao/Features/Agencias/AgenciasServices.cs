using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoDominio;
using TreinamentoDominio.Interfaces;
using TreinamentoInfra;
using TreinamentoInfra.BaseStarter;
using TreinamentoInfra.DaoSql;
using TreinamentoInfra.Interface;

namespace TreinamentoAplicacao.Features.AgenciasServices
{
    public class AgenciaServices : IServices<Agencia>
    {
        AgenciaDao _agenciaDao = new AgenciaDao();
        AgenciaDaoSql _agenciaDaoSql = new AgenciaDaoSql();

        public void CadastraDados(Agencia agencia)
        {
            _agenciaDao.CadastraDados(agencia);
        }

        public List<Agencia> ListaDados()
        {
            return _agenciaDao.ListaDados();
        }

        public Agencia BuscaPorId(int id)
        {
            return _agenciaDao.BuscaPorId(id);
        }

        public int PegaUltimoId()
        {
            return _agenciaDao.PegaUltimoId();
        }

        public void CadastraAgencias()
        {
            DataBase.CadastraAgencias(_agenciaDao, 10);
        }
    }
}
