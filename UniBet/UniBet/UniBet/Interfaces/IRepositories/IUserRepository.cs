using UniBet.Entities;

namespace UniBet.Interfaces.IRepositories
{
    public interface IUserRepository
    {
        public User FindById(Guid userId);
    }
}