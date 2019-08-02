using System;

namespace Treinamento._1___VIEW
{
    public class ViewAgencia
    {

        public void CadastraAgencia(AgenciaDao _agenciaDao)
        {
            Console.WriteLine("Digite o codigo da agencia");
            string CodAgencia = Console.ReadLine();

            Console.WriteLine("Digite o nome da agencia");
            string NomeAgencia = Console.ReadLine();

            Console.WriteLine("Digite o nome da cidade");
            string NomeCidade = Console.ReadLine();

            Console.WriteLine("Digite o estado");
            string Estado = Console.ReadLine();

            Agencia agencia = new Agencia(CodAgencia, NomeAgencia, NomeCidade, Estado);

            _agenciaDao.CadastraAgencia(agencia);

            Console.Clear();
            Console.WriteLine("Agencia cadastrada com sucesso \n Pressione qualquer tecla para voltar ao menu");
            Console.ReadKey();
            Console.Clear();
        }

        public void FormataListaAgencias(AgenciaDao _agenciaDao)
        {
            Console.Clear();

            foreach (var agencia in _agenciaDao.ListaAgencias())
            {
                Console.WriteLine("\n ID: {0} Nome: {1} Codigo: {2} Cidade: {3} Estado: {4} \n",
                    agencia.Id, agencia.Nome, agencia.Codigo, agencia.NomeCidade, agencia.Uf);
            }
        }
    }
}
