using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento._2___MODEL;

namespace Treinamento._4___UTIL
{
    public class CriaListaCompleta
    {
        StringBuilder listaCompleta;

        public CriaListaCompleta(List<Pessoa> listaPessoas, List<Agencia> listaAgencias, List<Funcionario> listaFuncionario)
        {
            listaCompleta = new StringBuilder();

            listaCompleta.Append(listaPessoas);

            foreach (var item in listaPessoas)
            {
                Console.WriteLine(item.Id);
                
            }

        }

    }
}
