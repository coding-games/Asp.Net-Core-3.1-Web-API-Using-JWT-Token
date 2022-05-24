using API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Services
{
    public interface IJWTManagerRepository
    {
        Tokens Authenticate(Users users);
    }
}
