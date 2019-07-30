using System;

namespace Treinamento._1___VIEW
{
    public class ViewAgencia
    {
        private AgenciaDao _agenciaDao = new AgenciaDao();
        public void CadastraAgencia()
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
            Console.WriteLine("Agencia cadastrada com sucesso");
        }

        public void FormataListaAgencias()
        {
            foreach (var agencia in _agenciaDao.ListaAgencias())
            {
                Console.WriteLine("\n ID: {0} Nome: {1} Codigo: {2} Cidade: {3} Estado: {4} \n",
                    agencia.GetId(), agencia.GetNome(), agencia.GetCodigo(), agencia.GetNomeCidade(), agencia.GetUf());
            }

        }
    }
}
