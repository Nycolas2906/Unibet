using System;
using System.Collections.Generic;
using System.Linq;
using UniBet.DTOs;
using UniBet.Entities;
using UniBet.Interfaces.IServices;

namespace UniBet.Services
{
    public class GameService : IGameService
    {
        private static List<Game> _games = new List<Game>();

        public GameDTO CadastrarJogo(CreateGameDTO dto)
        {
            var game = new Game
            {
                Id = Guid.NewGuid(),
                Name = dto.Name,
                Image = dto.Image,
                Description = dto.Description
            };

            _games.Add(game);

            return new GameDTO
            {
                Id = game.Id,
                Name = game.Name,
                Image = game.Image,
                Description = game.Description
            };
        }

        public GameDTO BuscarJogo(Guid id)
        {
            var game = _games.FirstOrDefault(g => g.Id == id);

            if (game == null)
                return null;

            return new GameDTO
            {
                Id = game.Id,
                Name = game.Name,
                Image = game.Image,
                Description = game.Description
            };
        }

        public List<GameDTO> ListarJogos()
        {
            return _games.Select(game => new GameDTO
            {
                Id = game.Id,
                Name = game.Name,
                Image = game.Image,
                Description = game.Description
            }).ToList();
        }

        public GameDTO EditarJogo(Guid id, CreateGameDTO dto)
        {
            var game = _games.FirstOrDefault(g => g.Id == id);

            if (game == null)
                return null;

            game.Name = dto.Name;
            game.Image = dto.Image;
            game.Description = dto.Description;

            return new GameDTO
            {
                Id = game.Id,
                Name = game.Name,
                Image = game.Image,
                Description = game.Description
            };
        }

        public bool RemoverJogo(Guid id)
        {
            var game = _games.FirstOrDefault(g => g.Id == id);

            if (game == null)
                return false;

            _games.Remove(game);
            return true;
        }
    }
}