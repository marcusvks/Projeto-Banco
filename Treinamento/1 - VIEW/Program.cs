using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento._1___VIEW;
using Treinamento._3___DAO.DAOSQL;

namespace Treinamento
{
    public class Program
    {

        static void Main(string[] args)
        {
            Pessoa p = new Pessoa("marcaum", "lajaica", "1992-05-01", 666, "F", "brasiliao", "99999999999");
            p.Id = 1;

            PessoaDaoSql pd = new PessoaDaoSql();
            pd.CadastraDados(p);

            ViewMenu menu = new ViewMenu();
            menu.IniciaMenu();
        }
    }
}
