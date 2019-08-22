using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model;
using Repository;

namespace WebService.Controllers
{
    [Route("api/pessoas")]
    public class PessoaController : Controller
    {
        private IPessoaRepository repository;

        public PessoaController(IPessoaRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet, Route("obtertodos")]
        public JsonResult ObterTodos()
        {
            return Json(repository.ObterTodos());
        }

        [HttpGet, Route("obterpeloid")]
        public JsonResult ObterTodos(int id)
        {
            return Json(repository.ObterPeloId(id));
        }

        [HttpPost, Route("adicionar")]
        public JsonResult Adicionar(Pessoa pessoa)
        {
            var id = repository.Adicionar(pessoa);
            return Json(new { id = id });
        }

        [HttpPut, Route("alterar")]
        public JsonResult Alterar(Pessoa pessoa)
        {
            var alterou = repository.Alterar(pessoa);
            return Json(new { status = alterou });
        }

        [HttpDelete, Route("apagar")]
        public JsonResult Apagar(int id)
        {
            var apagou = repository.Apagar(id);
            return Json(new { status = apagou });
        }
    }
}