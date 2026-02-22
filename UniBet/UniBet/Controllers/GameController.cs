using Microsoft.AspNetCore.Mvc;
using System;
using UniBet.DTOs;
using UniBet.Interfaces.IServices;

namespace UniBet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService)
        {
            _gameService = gameService;
        }

        [HttpPost]
        public IActionResult CadastrarJogo([FromBody] CreateGameDTO dto)
        {
            var result = _gameService.CadastrarJogo(dto);
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult BuscarJogo(Guid id)
        {
            var result = _gameService.BuscarJogo(id);
            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpGet]
        public IActionResult ListarJogos()
        {
            var result = _gameService.ListarJogos();
            return Ok(result);
        }

        [HttpPut("{id}")]
        public IActionResult EditarJogo(Guid id, [FromBody] CreateGameDTO dto)
        {
            var result = _gameService.EditarJogo(id, dto);
            if (result == null)
                return NotFound();

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult RemoverJogo(Guid id)
        {
            var result = _gameService.RemoverJogo(id);
            if (!result)
                return NotFound();

            return NoContent();
        }
    }
}