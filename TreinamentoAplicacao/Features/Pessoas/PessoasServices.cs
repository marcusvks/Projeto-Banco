﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TreinamentoDominio;
using TreinamentoDominio.Interfaces;
using TreinamentoInfra;
using TreinamentoInfra.BaseStarter;
using TreinamentoInfra.DaoSql;
using TreinamentoInfra.Interface;

namespace TreinamentoAplicacao.Features.PessoasServices
{
    public class PessoasServices : IServices<Pessoa>
    {
        private IDao<Pessoa> _pessoaDao;

        public Pessoa BuscaPorId(int id)
        {
            return _pessoaDao.BuscaPorId(id);
        }

        public void CadastraDados(Pessoa obj)
        {
            _pessoaDao.CadastraDados(obj);
        }

        public List<Pessoa> ListaDados()
        {
            return _pessoaDao.ListaDados();
        }

        public int PegaUltimoId()
        {
            return _pessoaDao.PegaUltimoId();
        }

        public void CadastrarPessoasFisicas()
        {
            DataBase.CadastrarPessoasFisicas(_pessoaDao, 10);
        }
    }
}
