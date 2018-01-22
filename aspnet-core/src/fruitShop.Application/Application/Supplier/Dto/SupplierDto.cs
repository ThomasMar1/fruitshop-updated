using System;
using System.Collections.Generic;
using System.Text;
using Abp.AutoMapper;
using fruitShop.Domain;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace fruitShop.Application.Supplier.Dto
{
    [AutoMap(typeof(supplier))]
    public class SupplierDto: AuditedEntityDto<Int32>
    {
        public string supplierName { get; set; }
        public string supplierContact { get; set; }
        public string supplierPhoneNumber { get; set; }
        public string supplierEmail { get; set; }
    }
}
