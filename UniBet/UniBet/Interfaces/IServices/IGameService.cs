using System;
using System.Collections.Generic;
using UniBet.DTOs;

namespace UniBet.Interfaces.IServices
{
    public interface IGameService
    {
        GameDTO CadastrarJogo(CreateGameDTO dto);
        GameDTO BuscarJogo(Guid id);
        List<GameDTO> ListarJogos();
        GameDTO EditarJogo(Guid id, CreateGameDTO dto);
        bool RemoverJogo(Guid id);
    }
}