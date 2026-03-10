using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using UniBet.DTOs;
using UniBet.Entites;
using UniBet.Interfaces.IServices;
using UniBet.Services;



namespace Unibett.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class GamesController : ControllerBase
    {
        private readonly IGameService _service;
        public GamesController(IGameService service)
        {
            _service = service;
        }
        [HttpGet]
        public IActionResult Listar()
        {
            return Ok(_service.ListarJogos());
        }

        [HttpPost]

        public IActionResult Cadastrar(GameDTO jogo)
        {
            _service.CadastrarJogo(jogo);
            return Ok("Jogo cadastrado!!!!");

        }

        [HttpPut]
        public IActionResult Editar(GameDTO jogo)
        {
            _service.EditarJogo(jogo);
            return Ok("Jogo editado!!!!");
        }

        [HttpDelete]
        public IActionResult Remover(GameDTO jogo)
        {
            _service.RemoverJogo(jogo.Id);
            return Ok("Jogo removido!!!!");
        }
    }
}
