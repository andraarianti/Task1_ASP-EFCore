﻿using APISolution.BLL.DTOs;

namespace MyWebFormApp.BLL.Interfaces
{
    public interface IRoleBLL
    {
        Task<IEnumerable<RoleDTO>> GetAllRoles();
        Task<Task> AddRole(string roleName);
        Task<Task> AddUserToRole(string username, int roleId);
    }
}
