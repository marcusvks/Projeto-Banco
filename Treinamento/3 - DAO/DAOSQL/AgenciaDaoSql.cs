using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento._3___DAO.DAOSQL
{
    public class AgenciaDaoSql : IDao<Agencia>
    {
        private DaoManager _daoManager = new DaoManager();

        public Agencia BuscaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void CadastraDados(Agencia agencia)
        {

            string commandText = "INSERT INTO PessoaFisicaJuridica (Codigo, Nome, Nome_cidade, UF) VALUES (@codigo, @nome, @nome_cidade, uf)";

            SqlCommand comando = new SqlCommand();

            IEnumerable<SqlParameter> parameters;

            parameters = new List<SqlParameter>()
            {
                new SqlParameter("@codigo", agencia.Codigo),
                new SqlParameter("@codigo", agencia.Codigo),
                new SqlParameter("@nome", agencia.Nome),
                new SqlParameter("@nome_cidade", agencia.NomeCidade),
                new SqlParameter("@uf", agencia.Uf),
            };
            _daoManager.SetConnectionString();
            _daoManager.ExecuteCommand(commandText, parameters);

        }

        public List<Agencia> ListaDados()
        {
            throw new NotImplementedException();
        }

        public int PegaUltimoId()
        {
            throw new NotImplementedException();
        }
    }
}
