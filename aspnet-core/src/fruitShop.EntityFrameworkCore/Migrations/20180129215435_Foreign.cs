using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace fruitShop.Migrations
{
    public partial class Foreign : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "supplierId",
                table: "dFruit",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "supplierRefId",
                table: "dFruit",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_dFruit_supplierId",
                table: "dFruit",
                column: "supplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_dFruit_dSuppliers_supplierId",
                table: "dFruit",
                column: "supplierId",
                principalTable: "dSuppliers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_dFruit_dSuppliers_supplierId",
                table: "dFruit");

            migrationBuilder.DropIndex(
                name: "IX_dFruit_supplierId",
                table: "dFruit");

            migrationBuilder.DropColumn(
                name: "supplierId",
                table: "dFruit");

            migrationBuilder.DropColumn(
                name: "supplierRefId",
                table: "dFruit");
        }
    }
}
