using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento;
using TreinamentoAplicacao.Features.PessoasServices;
using TreinamentoApresentacao.Models;
using TreinamentoInfra;

namespace TreinamentoApresentacao.Menus
{
    public class ViewMenuPessoa
    {
        public void StartMenuPessoa(ViewPessoa viewPessoa, ViewMenu viewMenu, PessoasServices pessoaServices)
        {
            ConsoleKeyInfo _opcao;

            Console.WriteLine("\n PRESSIONE: \n\n F1 Para cadastrar uma pessoa \n F2 Para listar todas as pessoas \n F12 para voltar ao menu principal");
            _opcao = Console.ReadKey();
            switch (_opcao.Key)
            {
                case ConsoleKey.F1:
                    Console.Clear();
                    viewPessoa.CadastraDados();
                    break;

                case ConsoleKey.F2:
                    Console.Clear();
                    viewPessoa.ListaEFormata(pessoaServices);
                    break;

                case ConsoleKey.F12:
                    Console.Clear();
                    viewMenu.IniciaMenu();
                    break;
            }
        }

    }
}
