using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento
{
    public class PessoaDao
    {
        private List<Pessoa> listaDePessoas = new List<Pessoa>();

        public void CadastraPessoas(Pessoa pessoa)
        {
            pessoa.Id = (PegaUltimoId()+1);
            listaDePessoas.Add(pessoa);
        }

        public List<Pessoa> ListaPessoas()
        {
            return listaDePessoas;
        }

        public Pessoa BuscaPessoaPorId(int id)
        {
            foreach (var pessoa in listaDePessoas)
            {
                if (pessoa.Id == id)
                    return pessoa;
            }

            return null;
        }

        public int PegaUltimoId()
        {
            Pessoa ultimoId = listaDePessoas.LastOrDefault();

            if (ultimoId != null)
                return ultimoId.Id;

            return 0;
        }
    }
}
