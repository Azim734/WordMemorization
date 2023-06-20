using WordMemorization.Entities_Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordMemorization.Interfaces.Users;

public interface IUsersRepository : IRepository<User>
{
    public Task<int> CountAsync();
}
