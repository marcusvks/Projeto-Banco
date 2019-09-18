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
            AgenciaDaoSql a = new AgenciaDaoSql();
            a.ListaDados();

            ViewMenu menu = new ViewMenu();
            menu.IniciaMenu();
        }
    }
}
