using System;
using System.Collections.Generic;
using System.Text;
using Abp.AutoMapper;
using fruitShop.Domain;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace fruitShop.Application.Suppliers.Dto
{
    [AutoMapTo(typeof(SupplierFruit))]
    public class deleteFruitDto
    {
        public int supplierId { get; set; }
        public int fruitId { get; set; }

    }
}
