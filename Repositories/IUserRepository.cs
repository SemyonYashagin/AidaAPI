using System.Threading.Tasks;
using System.Collections.Generic;
using AIDA_API.Models;

namespace AIDA_API.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> Get();
        Task<User> Get(int id);
        Task<User> Create(User user);
        Task Update(User user);
        Task Delete(int id);
    }
}
