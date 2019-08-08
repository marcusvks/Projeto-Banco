using System.Collections.Generic;
using System.Linq;

namespace Treinamento
{
    public class AgenciaDao
    {
        private List<Agencia> listaDeAgencias = new List<Agencia>();

        public void CadastraAgencia(Agencia agencia)
        {
            agencia.Id = PegaUltimoId() + 1;
            listaDeAgencias.Add(agencia);
        }
        public List<Agencia> ListaAgencias()
        {
            return listaDeAgencias;
        }

        public Agencia BuscaAgenciaPorId(int id)
        {
            return listaDeAgencias.Find(a => a.Id  == id);
        }

        public int PegaUltimoId()
        {
            Agencia ultimoId = listaDeAgencias.LastOrDefault();

            if (ultimoId != null)
                return ultimoId.Id;

            return 0;
        }
    }
}
