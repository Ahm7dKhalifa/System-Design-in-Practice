using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Database.SqlServer.Migrations
{
    public partial class AlterColumns_From_NVarcharMax_To_Nvarchar255 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                    name: "Name",
                    table: "Products",
                    maxLength:255
               );
            migrationBuilder.AlterColumn<string>(
                    name: "Description",
                    table: "Products",
                    maxLength: 255
               );
            migrationBuilder.AlterColumn<string>(
                    name: "Name",
                    table: "ProductAttributes",
                    maxLength: 255
               );
            migrationBuilder.AlterColumn<string>(
                  name: "Value",
                  table: "ProductAttributes",
                  maxLength: 255
             );

            migrationBuilder.AlterColumn<string>(
                   name: "FileName",
                   table: "ProductFiles",
                   maxLength: 255
              );
            migrationBuilder.AlterColumn<string>(
                  name: "FileTypeName",
                  table: "ProductFileTypes",
                  maxLength: 255
             );

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
