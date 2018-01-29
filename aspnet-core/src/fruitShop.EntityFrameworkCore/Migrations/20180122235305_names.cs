using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace fruitShop.Migrations
{
    public partial class names : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "supplierPhoneNumber",
                table: "dSuppliers",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "supplierName",
                table: "dSuppliers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "supplierEmail",
                table: "dSuppliers",
                newName: "Email");

            migrationBuilder.RenameColumn(
                name: "supplierContact",
                table: "dSuppliers",
                newName: "Contact");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "dSuppliers",
                newName: "supplierPhoneNumber");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "dSuppliers",
                newName: "supplierName");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "dSuppliers",
                newName: "supplierEmail");

            migrationBuilder.RenameColumn(
                name: "Contact",
                table: "dSuppliers",
                newName: "supplierContact");
        }
    }
}
