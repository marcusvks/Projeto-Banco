using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoDominio;
using TreinamentoInfra.Interface;

namespace TreinamentoInfra.DaoSql
{
    public class AgenciaDaoSql : IDao<Agencia>
    {
        private DaoManager _daoManager = new DaoManager();
        IEnumerable<SqlParameter> parameters;

        public Agencia BuscaPorId(int id)
        {
            string commandText = "SELECT * FROM AGENCIA where id = @id";

            parameters = new List<SqlParameter>()
            {
                new SqlParameter("@id", id),
            };

            _daoManager.SetConnectionString();

            var ds = _daoManager.SelectRegisters(commandText, parameters);

            Agencia result = new Agencia(ds.Tables[0].Rows[0].ItemArray[1].ToString(), 
                ds.Tables[0].Rows[0].ItemArray[2].ToString(),
                ds.Tables[0].Rows[0].ItemArray[3].ToString(),
                ds.Tables[0].Rows[0].ItemArray[4].ToString());

                return result;
        }

        public void CadastraDados(Agencia agencia)
        {

            string commandText = "INSERT INTO Agencia (Codigo, Nome, Nome_cidade, UF) VALUES (@codigo, @nome, @nome_cidade, @uf)";

            parameters = new List<SqlParameter>()
            {
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
            string commandText = "SELECT * FROM AGENCIA";

            parameters = new List<SqlParameter>();

            _daoManager.SetConnectionString();
            var ds = _daoManager.SelectRegisters(commandText, parameters);

            List<Agencia> results = new List<Agencia>();

            for (int i = 0; i <= ds.Tables[0].Rows[0].ItemArray.Length; i++)
            {
                results.Add(new Agencia(ds.Tables[0].Rows[i].ItemArray[0].ToString(),
                    ds.Tables[0].Rows[i].ItemArray[1].ToString(),
                    ds.Tables[0].Rows[i].ItemArray[2].ToString(),
                    ds.Tables[0].Rows[i].ItemArray[3].ToString()));
            }

            return results;
        }

        public void UpdateDados(Agencia agencia)
        {
            string commandText = "update agencia set codigo = @codigo, nome = @nome, Nome_cidade = @nome_cidade, UF = @uf where id = @id";

            parameters = new List<SqlParameter>()
            {
                new SqlParameter("@codigo", agencia.Codigo),
                new SqlParameter("@nome", agencia.Nome),
                new SqlParameter("@nome_cidade", agencia.NomeCidade),
                new SqlParameter("@uf", agencia.Uf),
                new SqlParameter("@id", agencia.Id),
            };

            _daoManager.SetConnectionString();
            _daoManager.ExecuteCommand(commandText, parameters);
        }

        public void DeleteDados(int id)
        {
            string commandText = "delete from agencia where id = @id";

            parameters = new List<SqlParameter>()
            {
                new SqlParameter("@id", id),
            };

            _daoManager.SetConnectionString();
            _daoManager.ExecuteCommand(commandText, parameters);
        }

        public int PegaUltimoId()
        {
            throw new NotImplementedException();
        }
    }
}
