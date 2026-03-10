using UniBet.DTOs;
using UniBet.Entites;
using UniBet.Interfaces.IServices;

namespace UniBet.Services
{
    public class GameService : IGameService
    {
        private static List<GameDTO> _jogos = new List<GameDTO>();
        public List<GameDTO> ListarJogos()
        {
            return _jogos;
        }

        public GameDTO BuscarJogo(Guid id)
        {
            return _jogos.FirstOrDefault(jogo => jogo.Id == id);
        }

        public void CadastrarJogo(GameDTO gameDTO)
        {
            gameDTO.Id = Guid.NewGuid();
            _jogos.Add(gameDTO);
        }

        public void EditarJogo (GameDTO gameDTO)
        {
            var jogoExistente = _jogos.FirstOrDefault(jogo => jogo.Id == gameDTO.Id);
            if (jogoExistente != null)
            {
                jogoExistente.Name = gameDTO.Name;
                jogoExistente.Image = gameDTO.Image;
                jogoExistente.Description = gameDTO.Description;
            }
        }

        public void RemoverJogo(Guid id)
        {
            var jogoExistente = _jogos.FirstOrDefault(jogo => jogo.Id == id);
            if (jogoExistente != null)
            {
                _jogos.Remove(jogoExistente);
            }
        }

        internal List<Game> BuscarJogo()
        {
            throw new NotImplementedException();
        }
    }
}
