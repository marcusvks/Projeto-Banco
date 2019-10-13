using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento;
using TreinamentoAplicacao.Features.ContaBancariaServices;
using TreinamentoAplicacao.Features.OperacoesServices;
using TreinamentoApresentacao.Models;
using TreinamentoInfra;
using TreinamentoInfra.Operaçoes;

namespace TreinamentoApresentacao.Menus
{
    public class ViewMenuOperacoes
    {
        public void StartMenuOperacoes(ViewContaBancaria viewConta, ViewRelatorioOperacoes viewRelatorioOperacoes, ViewMenu viewMenu, ViewTransferencia viewTransferencia, ViewDeposito viewDeposito,ViewSaque viewSaque, OperacoesServices operacoeServices, ContaBancariaServices contaServices)
        {
            ConsoleKeyInfo _opcao;

            Console.WriteLine("\n PRESSIONE: \n\n F1 Para realizar um saque \n F2 Para fazer um deposito \n F3 Para fazer uma transferencia \n F4 Para exibir o relatorio de operacoes \n F12 para voltar ao menu principal");
            _opcao = Console.ReadKey();
            switch (_opcao.Key)
            {
                case ConsoleKey.F1:
                    Console.Clear();
                    viewSaque.RealizaSaque(operacoeServices, contaServices, viewConta);
                    break;

                case ConsoleKey.F2:
                    Console.Clear();
                    viewDeposito.RealizaDeposito(contaServices, viewConta, operacoeServices);
                    break;

                case ConsoleKey.F3:
                    Console.Clear();
                    viewTransferencia.RealizaTransferencia(viewConta, operacoeServices, contaServices);
                    break;

                case ConsoleKey.F4:
                    Console.Clear();
                    viewRelatorioOperacoes.VisualizaRelatorioDeOperacoes(operacoeServices);
                    break;

                case ConsoleKey.F12:
                    Console.Clear();
                    viewMenu.IniciaMenu();
                    break;
            }
        }

    }
}
