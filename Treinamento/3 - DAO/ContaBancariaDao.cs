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
            listaDeContaBancarias.Add(contaBancaria);
        }

        public List<ContaBancaria> ListaContaBancarias()
        {
            return listaDeContaBancarias;
        }
    }
}
