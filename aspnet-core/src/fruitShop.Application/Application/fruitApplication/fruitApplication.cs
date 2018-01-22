using System;
using System.Collections.Generic;
using System.Text;
using fruitShop.Application.fruitApplication.dto;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.EntityFramework.Repositories;
using Microsoft.EntityFrameworkCore;
using fruitShop.Domain;


namespace fruitShop.Application.fruitApplication
{
    public class fruitApplication : AsyncCrudAppService<fruit, fruitdto, Int32 , fruitdto, addFruit, updateFruit>, IfruitApplication
    {
        public fruitApplication(IRepository<fruit, Int32> Repo): base(Repo)
        {

        }
            
    }
}
