using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoDominio;
using TreinamentoInfra.Interface;

namespace TreinamentoInfra.DaoSql
{
    public class RelatorioOperacaoDaoSql : IDao<Operacao>
    {
        public Operacao BuscaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void CadastraDados(Operacao obj)
        {
            throw new NotImplementedException();
        }

        public List<Operacao> ListaDados()
        {
            return new List<Operacao>();
        }

        public int PegaUltimoId()
        {
            throw new NotImplementedException();
        }
    }
}
