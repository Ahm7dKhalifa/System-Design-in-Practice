using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Database.SqlServer.Migrations
{
    public partial class SeedData_ProductFileTypes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"

                  DELETE FROM [dbo].[ProductFileTypes];
                  
                  DBCC CHECKIDENT (ProductFileTypes, RESEED, 0);
   
                  SET IDENTITY_INSERT ProductFileTypes ON;

                  INSERT INTO [dbo].[ProductFileTypes]([Id],[FileTypeName],[Deleted])
                  VALUES(1,N'Image' , 0);

                  INSERT INTO [dbo].[ProductFileTypes]([Id],[FileTypeName],[Deleted])
                  VALUES(2,N'Video' , 0);

                  INSERT INTO [dbo].[ProductFileTypes]([Id],[FileTypeName],[Deleted])
                  VALUES(3,N'PDF' , 0);

                  SET IDENTITY_INSERT ProductFileTypes OFF


            ");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
