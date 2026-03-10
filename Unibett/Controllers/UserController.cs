using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using UniBet.DTOs;
using UniBet.Entites;  
using UniBet.Interfaces.IServices;



namespace Unibett.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class UserController : ControllerBase
    {

        private readonly IUserService _service;

        public UserController(IUserService service)
        {
            _service = service;
        }

        [HttpGet]

        public IActionResult GetUserData(Guid Id)
        {
            var userResponse = _service.GetUserData(Id);

            if (userResponse == null) return NotFound("Usuário não encontrado");

            return Ok(userResponse);
        }

        [HttpPost]

        public IActionResult Deposit(DepositDTO depositDTO)
        {
            try
            {
                
                _service.Deposit(depositDTO);
                return Created();
            }

            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }



        }

    }
}
            