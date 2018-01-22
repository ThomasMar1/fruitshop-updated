using System;
using System.Collections.Generic;
using System.Text;
using fruitShop.Domain;
using fruitShop.Application.fruitApplication.dto;
using Abp.Application.Services;

namespace fruitShop.Application.fruitApplication
{
    interface IfruitApplication : IAsyncCrudAppService<fruitdto, Int32, fruitdto, addFruit, updateFruit>
    {
        
    }
}
