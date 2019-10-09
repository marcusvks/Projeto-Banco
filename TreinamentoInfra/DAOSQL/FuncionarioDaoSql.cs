using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoInfra.Interface;

namespace TreinamentoInfra.DaoSql
{
    public class FuncionarioDaoSql : IDao<FuncionarioDao>
    {
        public FuncionarioDao BuscaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void CadastraDados(FuncionarioDao obj)
        {
            throw new NotImplementedException();
        }

        public List<FuncionarioDao> ListaDados()
        {
            throw new NotImplementedException();
        }

        public int PegaUltimoId()
        {
            throw new NotImplementedException();
        }
    }
}
