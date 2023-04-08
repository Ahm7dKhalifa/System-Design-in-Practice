using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Database.SqlServer.Migrations
{
    public partial class AddColumns_To_ProductTable_TotalNumberOfOrders_TotalMoneyOfSales_Rate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Rate",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalMoneyOfSales",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<long>(
                name: "TotalNumberOfOrders",
                table: "Products",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TotalMoneyOfSales",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "TotalNumberOfOrders",
                table: "Products");
        }
    }
}
