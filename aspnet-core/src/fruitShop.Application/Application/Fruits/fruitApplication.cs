using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using fruitShop.Application.fruitApplication.dto; /*Change*/
using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.EntityFramework.Repositories;
using Microsoft.EntityFrameworkCore;
using fruitShop.Domain;
using Abp.Authorization;

namespace fruitShop.Application.fruitApplication
{
    // [AbpAuthorize("Pages.Fruit.Update")]
    public class fruitApplication : AsyncCrudAppService<fruit, fruitdto, Int32, fruitdto, addFruit, updateFruit>, IfruitApplication
    {
        public fruitApplication(IRepository<fruit, Int32> Repo) : base(Repo)
        {
  
        }




    }
}






