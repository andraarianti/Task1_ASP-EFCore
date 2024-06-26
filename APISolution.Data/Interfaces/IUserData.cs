﻿using APISolution.Domain;
using System.Collections.Generic;

namespace APISolution.Data;

public interface IUserData : ICrud<User>
{
    Task<IEnumerable<User>> GetAllWithRoles();
    Task<User> GetUserWithRoles(string username);
    Task<User> GetByUsername(string username);
    Task<User> Login(string username, string password);
    Task<Task> ChangePassword(string username, string newPassword);
}
