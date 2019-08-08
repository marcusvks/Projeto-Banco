using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento._3___DAO;

namespace Treinamento
{
    public class ContaBancariaDao : IDao<ContaBancaria>
    {
        private List<ContaBancaria> listaDeContaBancarias = new List<ContaBancaria>();

        public int PegaUltimoId()
        {
            ContaBancaria ultimoId = listaDeContaBancarias.LastOrDefault();

            if (ultimoId != null)
                return ultimoId.Id;

            return 0;
        }

        public void CadastraDados(ContaBancaria contaBancaria)
        {
            contaBancaria.Id = PegaUltimoId() + 1;
            listaDeContaBancarias.Add(contaBancaria);
        }

        public List<ContaBancaria> ListaDados()
        {
            return listaDeContaBancarias;
        }

        public ContaBancaria BuscaPorId(int id)
        {
            return listaDeContaBancarias.Find(a => a.Id == id);
        }
    }
}
