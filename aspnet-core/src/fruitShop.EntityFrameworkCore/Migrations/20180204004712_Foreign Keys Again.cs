using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace fruitShop.Migrations
{
    public partial class ForeignKeysAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "supplierId",
                table: "dSuppliers",
                nullable: true);

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
                name: "IX_dSuppliers_supplierId",
                table: "dSuppliers",
                column: "supplierId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_dSuppliers_dSuppliers_supplierId",
                table: "dSuppliers",
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

            migrationBuilder.DropForeignKey(
                name: "FK_dSuppliers_dSuppliers_supplierId",
                table: "dSuppliers");

            migrationBuilder.DropIndex(
                name: "IX_dSuppliers_supplierId",
                table: "dSuppliers");

            migrationBuilder.DropIndex(
                name: "IX_dFruit_supplierId",
                table: "dFruit");

            migrationBuilder.DropColumn(
                name: "supplierId",
                table: "dSuppliers");

            migrationBuilder.DropColumn(
                name: "supplierId",
                table: "dFruit");

            migrationBuilder.DropColumn(
                name: "supplierRefId",
                table: "dFruit");
        }
    }
}
