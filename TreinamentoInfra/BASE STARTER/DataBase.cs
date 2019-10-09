﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Treinamento._3___DAO;

namespace Treinamento._1___VIEW.BASE
{
    public static class DataBase
    {
        public static Pessoa pessoa(string nome, string tipo)
        {
            return new Pessoa(nome, "Cidade", DateTime.Now.AddYears(-27).ToString(), 12, tipo, "SC", "07846379976");
        }

        public static Agencia agencia(string nome)
        {
            return new Agencia("7", nome, "Lages", "SC");
        }

        public static void CadastraAgencias(IDao<Agencia> agenciaDao, int quantidade)
        {
            for (int i = 0; i < quantidade; i++)
            {
                agenciaDao.CadastraDados(agencia("Agencia - "+i));
            }
        }

        public static void CadastrarPessoasFisicas(PessoaDao pessoaDao,int quantidade)
        {
            for (int i = 0; i < quantidade; i++)
                pessoaDao.CadastraDados(pessoa("Pessoa - " + i, "FISICA"));
        }
        public static void CadastrarPessoasJuridica(PessoaDao pessoaDao, int quantidade)
        {
            for (int i = 0; i < quantidade; i++)
                pessoaDao.CadastraDados(pessoa("Pessoa - " + i, "JURIDICA"));
        }
    }
}
