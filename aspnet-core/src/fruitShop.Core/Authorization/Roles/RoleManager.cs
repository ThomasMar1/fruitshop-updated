using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Logging;
using Abp.Authorization;
using Abp.Authorization.Roles;
using Abp.Domain.Uow;
using Abp.Runtime.Caching;
using Abp.Zero.Configuration;
using fruitShop.Authorization.Users;

/*
 * Roles within the application
 * Static Roles: Pre-defined roles that can not be deleted. Eg. Admin
 * Dynamic Roles: Roles that are created once the application has been reployed. The roles can then be assigned or deleted. Eg. Intern
 */

namespace fruitShop.Authorization.Roles
{
    public class RoleManager : AbpRoleManager<Role, User>
    {
        public RoleManager(
            RoleStore store, 
            IEnumerable<IRoleValidator<Role>> roleValidators, 
            ILookupNormalizer keyNormalizer, 
            IdentityErrorDescriber errors, 
            ILogger<AbpRoleManager<Role, User>> logger,
            IPermissionManager permissionManager, 
            ICacheManager cacheManager, 
            IUnitOfWorkManager unitOfWorkManager,
            IRoleManagementConfig roleManagementConfig)
            : base(
                  store,
                  roleValidators, 
                  keyNormalizer, 
                  errors, logger, 
                  permissionManager,
                  cacheManager, 
                  unitOfWorkManager,
                  roleManagementConfig)
        {
        }
    }
}
