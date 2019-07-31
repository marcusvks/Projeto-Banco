using System.Collections.Generic;

namespace Treinamento
{
    public class AgenciaDao
    {
        private List<Agencia> listaDeAgencias = new List<Agencia>();

        public void CadastraAgencia(Agencia agencia)
        {
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
    }
}
