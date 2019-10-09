using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoDominio;
using TreinamentoDominio.Interfaces;
using TreinamentoInfra.Interface;

namespace TreinamentoAplicacao.Features.Agencias
{
    public class AgenciaServices : IServices<Agencia>
    {

        public void CadastraDados(Agencia agencia)
        {

        }

        public List<Agencia> ListaDados()
        {
            throw new NotImplementedException();
        }

        public Agencia BuscaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public int PegaUltimoId()
        {
            throw new NotImplementedException();
        }
    }
}
