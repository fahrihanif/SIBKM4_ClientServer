﻿using API.Models;

namespace API.Repositories.Interface;
public interface IAccountRoleRepository : IGeneralRepository<AccountRole, int>
{
    IEnumerable<string> GetRolesByEmail(string email);
}
