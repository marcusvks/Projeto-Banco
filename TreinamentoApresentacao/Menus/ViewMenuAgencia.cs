using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento;
using TreinamentoApresentacao.Models;
using TreinamentoDominio;
using TreinamentoDominio.Interfaces;
using TreinamentoInfra.Interface;

namespace TreinamentoApresentacao.Menus
{
    public class ViewMenuAgencia
    {
        public void IniciaMenuAgencia(ViewAgencia viewAgencia, ViewMenu viewMenu, IServices<Agencia> agenciaServices)
        {
            ConsoleKeyInfo _opcao;
            
            Console.WriteLine("\n PRESSIONE: \n\n F1 Para cadastrar uma agencia \n F2 Para mostrar todas as agencias \n F12 para voltar ao menu principal");
            _opcao = Console.ReadKey();
            switch (_opcao.Key)
            {
                case ConsoleKey.F1:
                    Console.Clear();
                    viewAgencia.CadastraDados();
                    break;

                case ConsoleKey.F2:
                    Console.Clear();
                    viewAgencia.ListaEFormata();
                    break;

                case ConsoleKey.F12:
                    Console.Clear();
                    viewMenu.IniciaMenu();
                    break;
            }
        }
    }
}
