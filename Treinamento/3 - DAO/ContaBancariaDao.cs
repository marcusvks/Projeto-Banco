using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento
{
    public class ContaBancariaDao
    {
        private List<ContaBancaria> listaDeContaBancarias = new List<ContaBancaria>();

        public void CadastraContaBancaria(ContaBancaria contaBancaria)
        {
            contaBancaria.Id = PegaUltimoId() + 1;
            listaDeContaBancarias.Add(contaBancaria);
        }

        public List<ContaBancaria> ListaContaBancarias()
        {
            return listaDeContaBancarias;
        }

        public ContaBancaria BuscaContaPorId(int id)
        {
            return listaDeContaBancarias.Find(a => a.Id == id);
        }
        public int PegaUltimoId()
        {
            ContaBancaria ultimoId = listaDeContaBancarias.LastOrDefault();

            if (ultimoId != null)
                return ultimoId.Id;

            return 0;
        }
    }
}
