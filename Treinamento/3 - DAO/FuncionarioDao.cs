using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento._2___MODEL;

namespace Treinamento._3___DAO
{
    public class FuncionarioDao
    {
        private List<Funcionario> listaDeFuncionarios = new List<Funcionario>();

        public void CadastraFuncionarios(Funcionario funcionario)
        {
            funcionario.Id = PegaUltimoId() + 1;
            listaDeFuncionarios.Add(funcionario);
        }

        public List<Funcionario> ListaFuncionarios()
        {
            return listaDeFuncionarios;
        }

        public Pessoa BuscaFuncionarioPorId(int id)
        {
            foreach (var funcionario in listaDeFuncionarios)
            {
                if (funcionario.Id == id)
                    return funcionario;
            }

            return null;
        }

        public int PegaUltimoId()
        {
            Pessoa ultimoId = listaDeFuncionarios.LastOrDefault();

            if (ultimoId != null)
                return ultimoId.Id;

            return 0;
        }
    }
}
