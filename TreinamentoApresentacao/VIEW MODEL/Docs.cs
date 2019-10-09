using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Treinamento._1___VIEW.VIEW_MODEL
{
    public class Docs
    {
        public string PedeCpfOuCnpj(ref string _cpfCnpj)
        {
            do
            {
                string RetornoValidacao = _cpfCnpj.ValidaCpfCnpj();

                if (RetornoValidacao == "cpf")
                    return "Pessoa Fisica";

                else if (RetornoValidacao == "cnpj")
                    return "Pessoa Juridica";
                else
                {
                    Console.Clear();
                    Console.WriteLine("Cpf ou Cnpj invalido");
                }

                _cpfCnpj = LerCPFCNPJ();

            } while (true);

        }

        public string LerCPFCNPJ()
        {
            string _cpfCnpj;
            Console.WriteLine("\nDigite seu CPJ ou CNPJ: \n");
            _cpfCnpj = Console.ReadLine();
            return _cpfCnpj;
        }
    }
}
