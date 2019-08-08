using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento._3___DAO;

namespace Treinamento._1___VIEW.VIEW_MENU
{
    public class ViewMenuOperacoes
    {
        public void StartMenuOperacoes(ViewContaBancaria viewConta, ViewRelatorioOperacoes viewRelatorioOperacoes,ViewTransferencia viewTransferencia, ViewDeposito viewDeposito,ViewSaque viewSaque, RelatorioOperacaoDao relatorioDao, ContaBancariaDao contaDao)
        {
            ConsoleKeyInfo _opcao;
            ViewMenu viewMenu = new ViewMenu();

            Console.WriteLine("\n PRESSIONE: \n\n F1 Para realizar um saque \n F2 Para fazer um deposito \n F3 Para fazer uma transferencia \n F4 Para exibir o relatorio de operacoes \n F12 para voltar ao menu principal");
            _opcao = Console.ReadKey();
            switch (_opcao.Key)
            {
                case ConsoleKey.F1:
                    Console.Clear();
                    viewSaque.RealizaSaque(relatorioDao, contaDao, viewConta);
                    break;

                case ConsoleKey.F2:
                    Console.Clear();
                    viewDeposito.RealizaDeposito(contaDao, viewConta, relatorioDao);
                    break;

                case ConsoleKey.F3:
                    Console.Clear();
                    viewTransferencia.RealizaTransferencia(viewConta, relatorioDao, contaDao);
                    break;

                case ConsoleKey.F4:
                    Console.Clear();
                    viewRelatorioOperacoes.VisualizaRelatorioDeOperacoes(relatorioDao);
                    break;

                case ConsoleKey.F12:
                    Console.Clear();
                    viewMenu.IniciaMenu();
                    break;
            }
        }

    }
}
