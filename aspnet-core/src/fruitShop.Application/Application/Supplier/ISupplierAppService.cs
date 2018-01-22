using System;
using System.Collections.Generic;
using System.Text;
using fruitShop.Domain;
using fruitShop.Application.Supplier.Dto;
using Abp.Application.Services;

namespace fruitShop.Application.Supplier
{
    interface ISupplierAppService : IAsyncCrudAppService<SupplierDto, Int32, SupplierDto, addSupplier, updateSupplier>
    {
    }
}
