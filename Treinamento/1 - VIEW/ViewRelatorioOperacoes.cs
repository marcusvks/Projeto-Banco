using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento._3___DAO;

namespace Treinamento._1___VIEW
{
    public class ViewRelatorioOperacoes
    {
        public void VisualizaRelatorioDeOperacoes(RelatorioOperacaoDao relatorioDao)
        {
            foreach (var operacao in relatorioDao.RetornaOperacoes())
            {
                Console.WriteLine("Id desta operação: ");
            }
        }
    }
}
