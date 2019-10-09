using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoDominio;
using TreinamentoDominio.Interfaces;

namespace TreinamentoAplicacao.Features.Pessoas
{
    class PessoasServices : IServices<Pessoa>
    {
        public Pessoa BuscaPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void CadastraDados(Pessoa obj)
        {
            throw new NotImplementedException();
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
