using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoDominio;
using TreinamentoInfra.Interface;

namespace TreinamentoInfra
{
    public class PessoaDao : IDao<Pessoa>
    {
        private List<Pessoa> listaDePessoas = new List<Pessoa>();

        public int PegaUltimoId()
        {
            Pessoa ultimoId = listaDePessoas.LastOrDefault();

            if (ultimoId != null)
                return ultimoId.Id;

            return 0;
        }

        public void CadastraDados(Pessoa pessoa)
        {
            pessoa.Id = PegaUltimoId() + 1;
            listaDePessoas.Add(pessoa);
        }

        public List<Pessoa> ListaDados()
        {
            return listaDePessoas;
        }

        public Pessoa BuscaPorId(int id)
        {
            foreach (var pessoa in listaDePessoas)
            {
                if (pessoa.Id == id)
                    return pessoa;
            }

            return null;
        }
    }
}
