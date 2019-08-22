using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class PessoaRepository : IPessoaRepository
    {
        private SistemaContexto context;

        public PessoaRepository(SistemaContexto context)
        {
            this.context = context;
        }

        public int Adicionar(Pessoa pessoa)
        {
            pessoa.RegistroAtivo = true;
            context.Pessoas.Add(pessoa);
            context.SaveChanges();
            return pessoa.Id;
        }

        public bool Alterar(Pessoa pessoa)
        {
            context.Pessoas.Update(pessoa);
            return context.SaveChanges() == 1;
        }

        public bool Apagar(int id)
        {
            var pessoa = context.Pessoas.FirstOrDefault(x => x.Id == id);
            pessoa.RegistroAtivo = false;
            context.Pessoas.Update(pessoa);
            return context.SaveChanges() == 1;
        }

        public List<Pessoa> ObterTodos()
        {
            return context.Pessoas.Where(x => x.RegistroAtivo).ToList();
        }

        public Pessoa ObterPeloId(int id)
        {
            return context.Pessoas.FirstOrDefault(x => x.RegistroAtivo && x.Id == id);
        }
    }
}
