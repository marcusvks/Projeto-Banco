using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento._3___DAO;

namespace Treinamento._1___VIEW
{
    public class ViewMenuConta
    {
        public void IniciaMenuConta(ViewContaBancaria viewConta, ViewPessoa viewPessoa, ViewAgencia viewAgencia, AgenciaDao agenciaDao, ContaBancariaDao contaDao, PessoaDao pessoaDao)
        {
            ConsoleKeyInfo _opcao;
            ViewMenu viewMenu = new ViewMenu();

            Console.WriteLine("\n PRESSIONE: \n\n F1 Para cadastrar uma conta bancaria \n F2 Para mostrar o saldo \n F12 para voltar ao menu principal");
            _opcao = Console.ReadKey();
            switch (_opcao.Key)
            {
                case ConsoleKey.F1:
                    Console.Clear();
                    viewConta.CadastraDados();
                    break;

                case ConsoleKey.F2:
                    Console.Clear();
                    viewConta.MostraSaldo(contaDao);
                    break;

                case ConsoleKey.F12:
                    Console.Clear();
                    viewMenu.IniciaMenu();
                    break;
            }
        }

    }
}
