using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public interface IPessoaRepository
    {
        int Adicionar(Pessoa pessoa);

        bool Alterar(Pessoa pessoa);

        bool Apagar(int id);

        List<Pessoa> ObterTodos();

        Pessoa ObterPeloId(int id);
    }
}
