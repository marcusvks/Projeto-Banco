using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoDominio;
using TreinamentoInfra.Interface;

namespace TreinamentoInfra.DaoSql
{
    public class FuncionarioDaoSql : IDao<Funcionario>
    {
        public Funcionario BuscaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void CadastraDados(Funcionario obj)
        {
            throw new NotImplementedException();
        }

        public List<Funcionario> ListaDados()
        {
            throw new NotImplementedException();
        }

        public int PegaUltimoId()
        {
            throw new NotImplementedException();
        }
    }
}
