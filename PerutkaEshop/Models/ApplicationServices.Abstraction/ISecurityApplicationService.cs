﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Perutka.Eshop.Web.Models.Identity;
using Perutka.Eshop.Web.Models.ViewModels;

namespace Perutka.Eshop.Web.Models.ApplicationServices.Abstraction
{
    public interface ISecurityApplicationService
    {
        Task<string[]> Register(RegisterViewModel vm, Roles role);
        Task<bool> Login(LoginViewModel vm);
        Task Logout();
        Task<User> FindUserByUsername(string username);
        Task<User> FindUserByEmail(string email);
        Task<IList<string>> GetUserRoles(User user);
        Task<User> GetCurrentUser(ClaimsPrincipal principal);

    }
}
