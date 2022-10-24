using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Delivery.Migrations
{
    public partial class Migration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_FruitProviderId",
                table: "Products");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegistrationDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 24, 8, 23, 29, 198, DateTimeKind.Local).AddTicks(6170),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 24, 2, 11, 40, 549, DateTimeKind.Local).AddTicks(4928));

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_FruitProviderId",
                table: "Products",
                column: "FruitProviderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Products_CategoryId",
                table: "Products");

            migrationBuilder.DropIndex(
                name: "IX_Products_FruitProviderId",
                table: "Products");

            migrationBuilder.AlterColumn<DateTime>(
                name: "RegistrationDate",
                table: "Orders",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 10, 24, 2, 11, 40, 549, DateTimeKind.Local).AddTicks(4928),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 10, 24, 8, 23, 29, 198, DateTimeKind.Local).AddTicks(6170));

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_FruitProviderId",
                table: "Products",
                column: "FruitProviderId",
                unique: true);
        }
    }
}
