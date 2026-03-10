using UniBet.DTOs;

namespace UniBet.Interfaces.IServices
{
    public interface IGameService
    {
        List<GameDTO> ListarJogos();
        GameDTO BuscarJogo ( Guid id );
        void CadastrarJogo ( GameDTO gameDTO );
        void EditarJogo ( GameDTO gameDTO );
        void RemoverJogo ( Guid id );
    }
}
