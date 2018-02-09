using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace fruitShop.Migrations
{
    public partial class SupplierFruit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "supplierId",
                table: "dSuppliers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "fruitId",
                table: "dFruit",
                newName: "Id");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "dSupplierFruit",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "dSupplierFruit");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "dSuppliers",
                newName: "supplierId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "dFruit",
                newName: "fruitId");
        }
    }
}
