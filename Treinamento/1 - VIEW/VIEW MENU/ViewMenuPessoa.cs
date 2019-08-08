using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento._1___VIEW
{
    public class ViewMenuPessoa
    {
        public void StartMenuPessoa(ViewPessoa viewPessoa,PessoaDao pessoaDao)
        {
            ConsoleKeyInfo _opcao;
            ViewMenu viewMenu = new ViewMenu();

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
                    viewPessoa.ListaEFormata();
                    break;

                case ConsoleKey.F12:
                    Console.Clear();
                    viewMenu.IniciaMenu();
                    break;
            }
        }

    }
}
