using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento._3___DAO.DAOSQL
{
    public class PessoaDaoSql : IDao<Pessoa>
    {
        private DaoManager _daoManager = new DaoManager();
        IEnumerable<SqlParameter> parameters;

        public Pessoa BuscaPorId(int id)
        {
            string commandText = "SELECT * FROM PessoaFisicaJuridica where id = @id";

            parameters = new List<SqlParameter>()
            {
                new SqlParameter("@id", id),
            };

            _daoManager.SetConnectionString();

            var ds = _daoManager.SelectRegisters(commandText, parameters);

            Pessoa result = new Pessoa(ds.Tables[0].Rows[0].ItemArray[1].ToString(),
                ds.Tables[0].Rows[0].ItemArray[2].ToString(),
                ds.Tables[0].Rows[0].ItemArray[3].ToString(),
                Convert.ToInt32(ds.Tables[0].Rows[0].ItemArray[4]),
                ds.Tables[0].Rows[0].ItemArray[5].ToString(),
                ds.Tables[0].Rows[0].ItemArray[6].ToString(),
                ds.Tables[0].Rows[0].ItemArray[7].ToString());

            return result;
        }

        public void CadastraDados(Pessoa pessoa)
        {

            string commandText = "INSERT INTO PessoaFisicaJuridica (Nome, FisJur, CPF_CNPJ, CEP, DataNascOp, Endereco, Numero_endereco, Nome_cidade, UF) " +
                                 "VALUES (@nome, @fisjur, @cpf_cnpj, @cep, convert(date, @datanascop, 103), @endereco, @numero_endereco, @nome_cidade, @uf)";

            
            int cpfcnpj = Convert.ToInt32(pessoa.Cnpj == "" ? pessoa.Cpf : pessoa.Cnpj);
            string datanasc = "'"+Convert.ToDateTime(pessoa.DataNasc).ToString("yyyy-dd-MM")+"'";
            
            parameters = new List<SqlParameter>()
            {
                new SqlParameter("@nome", pessoa.Nome),
                new SqlParameter("@fisjur", pessoa.TipoPessoa),
                new SqlParameter("@cpf_cnpj", cpfcnpj),
                new SqlParameter("@cep", ""),
                new SqlParameter("@datanascop", datanasc),
                new SqlParameter("@endereco", ""),
                new SqlParameter("@numero_endereco", pessoa.NumeroEndereco),
                new SqlParameter("@nome_cidade", pessoa.NomeCidade),
                new SqlParameter("@uf", pessoa.Uf),
            };
            _daoManager.SetConnectionString();
            _daoManager.ExecuteCommand(commandText, parameters);
        }

        public List<Pessoa> ListaDados()
        {
            throw new NotImplementedException();
        }

        public int PegaUltimoId()
        {
            throw new NotImplementedException();
        }
    }
}
