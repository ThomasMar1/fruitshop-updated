
using System;
using System.Collections.Generic;
using System.Text;
using fruitShop.Domain;
using fruitShop.Application.Suppliers.Dto;
using Abp.Application.Services;

namespace fruitShop.Application.Suppliers
{
    public interface ISupplierAppService : IAsyncCrudAppService<SupplierDto, Int32, SupplierDto, addSupplier, updateSupplier>
    {
    }
}