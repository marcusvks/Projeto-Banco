using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento._3___DAO.DAOSQL
{
    public class AgenciaDaoSql : IDao<Agencia>
    {
        public Agencia BuscaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void CadastraDados(Agencia agencia)
        {

            string abobrinha = $"INSERT INTO PessoaFisicaJuridica (Codigo, Nome, Nome_cidade, UF) VALUES (@codigo, @nome, @nome_cidade);
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
