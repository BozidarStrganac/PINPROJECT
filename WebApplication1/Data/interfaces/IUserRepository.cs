using WebApplication1.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Data.Models;

namespace WebApplication1.Data.interfaces
{
    public interface IUserRepository
    {
        User GetUserByID(int userID);
        IEnumerable<User> Users { get; }
    }
}
