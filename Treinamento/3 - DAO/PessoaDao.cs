using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento
{
    public class PessoaDao
    {
        public List<Pessoa> listaDePessoas = new List<Pessoa>();
        public void CadastraPessoas(Pessoa pessoa)
        {
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
                if (pessoa.GetId() == id)
                    return pessoa;
            }

            return null;
        }
    }
}
