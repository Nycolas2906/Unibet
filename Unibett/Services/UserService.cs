using UniBet.DTOs;
using UniBet.Entites;
using UniBet.Interfaces.IServices;

namespace UniBet.Services
{
    public class UserService : IUserService
    {
        private static List<User> _users = new List<User>();

        public User GetUserData(Guid id)
        {
            return _users.FirstOrDefault(u => u.Id == id);
        }

        public void Deposit(DepositDTO depositDto)
        {
            var user = _users.FirstOrDefault(u => u.Id == depositDto.UserId);

            if (user == null)
            {
                throw new Exception("Usuário não encontrado.");
            }

            if (depositDto.DepositAmount <= 0)
            {
                throw new Exception("Valor deve ser maior que zero.");
            }

            user.Balance += depositDto.DepositAmount;
        }


    }
}