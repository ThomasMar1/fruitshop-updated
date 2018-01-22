using System;
using System.Collections.Generic;
using System.Text;
using fruitShop.Application.Supplier.Dto;
using Abp.Application.Services;
using Abp.Domain.Repositories;
using Abp.EntityFramework.Repositories;
using Microsoft.EntityFrameworkCore;
using fruitShop.Domain;

namespace fruitShop.Application.Supplier
{
    public class SupplierAppService : AsyncCrudAppService<supplier, SupplierDto, Int32, SupplierDto, addSupplier, updateSupplier>, ISupplierAppService
    {
        public SupplierAppService(IRepository<supplier, Int32> Repo): base(Repo)
        {

        }
    }
}
