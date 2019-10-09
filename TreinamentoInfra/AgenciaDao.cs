using System.Collections.Generic;
using System.Linq;
using Treinamento._3___DAO;

namespace Treinamento
{
    public class AgenciaDao : IDao<Agencia>
    {
        private List<Agencia> listaDeAgencias = new List<Agencia>();

        public int PegaUltimoId()
        {
            Agencia ultimoId = listaDeAgencias.LastOrDefault();

            if (ultimoId != null)
                return ultimoId.Id;

            return 0;
        }

        public void CadastraDados(Agencia agencia)
        {
            agencia.Id = PegaUltimoId() + 1;
            listaDeAgencias.Add(agencia);
        }

        public List<Agencia> ListaDados()
        {
            return listaDeAgencias;
        }

        public Agencia BuscaPorId(int id)
        {
            return listaDeAgencias.Find(a => a.Id == id);
        }
    }
}
