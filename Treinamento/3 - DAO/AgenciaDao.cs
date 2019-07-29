using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento
{
    public class AgenciaDao
    {
        public List<Agencia> listaDeAgencias = new List<Agencia>();
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
            foreach (var agencia in listaDeAgencias)
            {
                if (agencia.GetId() == id)
                    return agencia;
            }

            return null;
        }
    }
}
