﻿using System;
using System.Collections.Generic;
using System.Text;
using Abp.AutoMapper;
using fruitShop.Domain;
using Abp.Application.Services.Dto;
using System.ComponentModel.DataAnnotations;

namespace fruitShop.Application.Suppliers.Dto
{
    [AutoMap(typeof(supplier))]
    public class SupplierDto : AuditedEntityDto<Int32>
    {
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

    }
}