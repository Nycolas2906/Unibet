using UniBet.Entites;
using UniBet.DTOs;

namespace UniBet.Interfaces.IServices
{
    public interface IUserService
    {
        public User GetUserData(Guid Id);
        public void Deposit(DepositDTO depositDTO);
    }
}
