using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoDominio;
using TreinamentoDominio.Interfaces;
using TreinamentoInfra;
using TreinamentoInfra.DaoSql;

namespace TreinamentoAplicacao.Features.FuncionariosServices
{
    public class FuncionariosServices : IServices<Funcionario>
    {
        FuncionarioDaoSql _funcionarioDaoSql = new FuncionarioDaoSql();
        FuncionarioDao _funcionarioDao = new FuncionarioDao();

        public Funcionario BuscaPorId(int id)
        {
            return _funcionarioDao.BuscaPorId(id);
        }

        public void CadastraDados(Funcionario obj)
        {
            _funcionarioDao.CadastraDados(obj);
        }

        public List<Funcionario> ListaDados()
        {
            return _funcionarioDao.ListaDados();
        }

        public int PegaUltimoId()
        {
            return _funcionarioDao.PegaUltimoId();
        }
    }
}
