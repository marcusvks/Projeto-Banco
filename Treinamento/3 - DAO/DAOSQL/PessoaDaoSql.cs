using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento._3___DAO.DAOSQL
{
    public class PessoaDaoSql : IDao<PessoaDao>
    {
        private DaoManager _daoManager = new DaoManager();

        public PessoaDao BuscaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void CadastraDados(PessoaDao pessoa)
        {
            
            _daoManager.OpenConnection();
        }

        public List<PessoaDao> ListaDados()
        {
            throw new NotImplementedException();
        }

        public int PegaUltimoId()
        {
            throw new NotImplementedException();
        }
    }
}
