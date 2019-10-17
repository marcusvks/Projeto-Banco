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
        private IDao<Agencia> _agenciaDao;

        public void CadastraDados(Agencia agencia) => _agenciaDao.CadastraDados(agencia);

        public List<Agencia> ListaDados() => _agenciaDao.ListaDados();

        public Agencia BuscaPorId(int id) => _agenciaDao.BuscaPorId(id);

        public int PegaUltimoId() => _agenciaDao.PegaUltimoId();

        public void CadastraAgencias() => DataBase.CadastraAgencias(_agenciaDao, 10);

    }
}
