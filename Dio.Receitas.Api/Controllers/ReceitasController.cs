using Dio.Receitas.Api.Services;
using Microsoft.AspNetCore.Mvc;
using Receitas.Api.Entities;

namespace Dio.Receitas.Api.Controllers
{
    [ApiController]
    [Route("api/receitas")]
    public class ReceitasController : ControllerBase
    {
        private IReceitaService _receitaService;

        public ReceitasController(IReceitaService receitaRepository)
        {
            _receitaService = receitaRepository;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_receitaService.RecuperarTodas());
        }

        [Route("{id:int}")]
        [HttpGet]
        public Receita Get(int id)
        {
            return _receitaService.RecuperarReceitaPorId(id);
        }

        [HttpPost]
        public void Post([FromBody] Receita receita)
        {
            _receitaService.AdicionarReceita(receita);
        }

        [Route("{id:int}")]
        [HttpDelete]
        public void Delete(int id)
        {
            _receitaService.DeletarReceitaPorId(id);
        }

        [HttpPut]
        public void Put([FromBody] Receita receita)
        {
            _receitaService.AtualizarReceita(receita);
        }
    }
}