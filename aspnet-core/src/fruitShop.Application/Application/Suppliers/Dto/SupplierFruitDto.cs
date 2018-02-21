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
    public class SupplierFruitDto
    {
        public decimal Price { get; set; }

    }
}
