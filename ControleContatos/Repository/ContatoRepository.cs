using System;
using ControleContatos.Data;
using ControleContatos.Models;

namespace ControleContatos.Repository
{
	public class ContatoRepository : IContatoRepository
	{
        private readonly BancoContext _bancoContext;

		public ContatoRepository(BancoContext bancoContext)
		{
            _bancoContext = bancoContext;
		}

        public ContatoModel Adicionar(ContatoModel contato)
        {
            //Gravar no banco de dados
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }
    }
}

