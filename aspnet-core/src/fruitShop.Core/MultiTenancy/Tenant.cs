using Abp.MultiTenancy;
using fruitShop.Authorization.Users;

/*Represents a tenant in the appliation*/

namespace fruitShop.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}

/*
 *tenancyName: unique tenant in the application.
 *name: readable name of the tenant. Long string.
 */


 
