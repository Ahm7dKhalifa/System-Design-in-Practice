using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Database.SqlServer.Migrations
{
    public partial class SeedData_Products : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"

DELETE FROM [dbo].[ProductAttributes];
DELETE FROM [dbo].[ProductFiles];
DELETE FROM [dbo].[ProductLikes];
DELETE FROM [dbo].[ProductViewers];
DELETE FROM [dbo].[Products];

DBCC CHECKIDENT (Products, RESEED, 0);
DBCC CHECKIDENT (ProductAttributes, RESEED, 0);
DBCC CHECKIDENT (ProductFiles, RESEED, 0);
DBCC CHECKIDENT (ProductLikes, RESEED, 0);
DBCC CHECKIDENT (ProductViewers, RESEED, 0);

DECLARE @LikeCounter INT;
DECLARE @ViewCounter INT;

SET IDENTITY_INSERT Products ON;

/*Nokia 3310 */
INSERT INTO [dbo].[Products]
           ([Id]
		   ,[Name]
           ,[Description]
           ,[Price]
           ,[TotalCountOfViewers]
           ,[TotalCountOfLikes]
           ,[Deleted])
     VALUES
           (1
		   ,N'Nokia 3310'
           ,N'Nokia 3310 Dual Sim - 16 MB 3G,Blue'
           ,200
           ,3
           ,5
		   ,0);

INSERT INTO [dbo].[ProductAttributes]
           ([ProductId]
           ,[Name]
           ,[Value]
           ,[Deleted])
     VALUES
           (1
           ,N'Colour'
           ,N'Blue'
           ,0)

INSERT INTO [dbo].[ProductAttributes]
           ([ProductId]
           ,[Name]
           ,[Value]
           ,[Deleted])
     VALUES
           (1
           ,N'Cellular technology'
           ,N'2G'
           ,0)

INSERT INTO [dbo].[ProductFiles]
           ([ProductId]
           ,[ProductFileTypeId]
           ,[FileName]
           ,[Deleted])
     VALUES
           (1
           ,1
           ,N'1.jpg'
           ,0)

INSERT INTO [dbo].[ProductFiles]
           ([ProductId]
           ,[ProductFileTypeId]
           ,[FileName]
           ,[Deleted])
     VALUES
           (1
           ,1
           ,N'2.jpg'
           ,0)


SET @ViewCounter=1
WHILE ( @ViewCounter <= 3)
BEGIN
    INSERT INTO [dbo].[ProductViewers]
           ([ProductId]
           ,[UserId]
           ,[Deleted])
     VALUES
           (1
           ,NULL
           ,0)
    SET @ViewCounter  = @ViewCounter  + 1
END

SET @LikeCounter=1
WHILE ( @LikeCounter <= 5)
BEGIN
    INSERT INTO [dbo].[ProductLikes]
           ([ProductId]
           ,[UserId]
           ,[Deleted])
     VALUES
           (1
           ,NULL
           ,0)
    SET @LikeCounter  = @LikeCounter  + 1
END

/*Samsung Galaxy A53 */
INSERT INTO [dbo].[Products]
           ([Id]
		   ,[Name]
           ,[Description]
           ,[Price]
           ,[TotalCountOfViewers]
           ,[TotalCountOfLikes]
           ,[Deleted])
     VALUES
           (2
		   ,N'Samsung Galaxy A53'
           ,N'Samsung Galaxy A53 Dual SIM, 8GB RAM, 128GB Storage, SIM Free, Android Smartphone, Black'
           ,1200
           ,11
           ,7
		   ,0);

INSERT INTO [dbo].[ProductAttributes]
           ([ProductId]
           ,[Name]
           ,[Value]
           ,[Deleted])
     VALUES
           (2
           ,N'Memory storage'
           ,N'128 GB'
           ,0)

INSERT INTO [dbo].[ProductAttributes]
           ([ProductId]
           ,[Name]
           ,[Value]
           ,[Deleted])
     VALUES
           (2
           ,N'RAM'
           ,N'8 GB'
           ,0)

INSERT INTO [dbo].[ProductFiles]
           ([ProductId]
           ,[ProductFileTypeId]
           ,[FileName]
           ,[Deleted])
     VALUES
           (2
           ,1
           ,N'1.jpg'
           ,0)

INSERT INTO [dbo].[ProductFiles]
           ([ProductId]
           ,[ProductFileTypeId]
           ,[FileName]
           ,[Deleted])
     VALUES
           (2
           ,1
           ,N'2.jpg'
           ,0)


SET @ViewCounter=1
WHILE ( @ViewCounter <= 11)
BEGIN
    INSERT INTO [dbo].[ProductViewers]
           ([ProductId]
           ,[UserId]
           ,[Deleted])
     VALUES
           (2
           ,NULL
           ,0)
    SET @ViewCounter  = @ViewCounter  + 1
END

SET @LikeCounter=1
WHILE ( @LikeCounter <= 7)
BEGIN
    INSERT INTO [dbo].[ProductLikes]
           ([ProductId]
           ,[UserId]
           ,[Deleted])
     VALUES
           (2
           ,NULL
           ,0)
    SET @LikeCounter  = @LikeCounter  + 1
END

/*Apple iPhone 14 Pro */
INSERT INTO [dbo].[Products]
           ([Id]
		   ,[Name]
           ,[Description]
           ,[Price]
           ,[TotalCountOfViewers]
           ,[TotalCountOfLikes]
           ,[Deleted])
     VALUES
           (3
		   ,N'Apple iPhone 14 Pro'
           ,N'Apple iPhone 14 Pro (256 GB) - Space Black'
           ,1800
           ,8
           ,10
		   ,0);

INSERT INTO [dbo].[ProductAttributes]
           ([ProductId]
           ,[Name]
           ,[Value]
           ,[Deleted])
     VALUES
           (3
           ,N'Memory'
           ,N'256 GB'
           ,0)

INSERT INTO [dbo].[ProductAttributes]
           ([ProductId]
           ,[Name]
           ,[Value]
           ,[Deleted])
     VALUES
           (3
           ,N'Colour'
           ,N'Black'
           ,0)

INSERT INTO [dbo].[ProductAttributes]
           ([ProductId]
           ,[Name]
           ,[Value]
           ,[Deleted])
     VALUES
           (3
           ,N'Screen size'
           ,N'6.1 Inches'
           ,0)

INSERT INTO [dbo].[ProductFiles]
           ([ProductId]
           ,[ProductFileTypeId]
           ,[FileName]
           ,[Deleted])
     VALUES
           (3
           ,1
           ,N'1.jpg'
           ,0)

INSERT INTO [dbo].[ProductFiles]
           ([ProductId]
           ,[ProductFileTypeId]
           ,[FileName]
           ,[Deleted])
     VALUES
           (3
           ,1
           ,N'2.jpg'
           ,0)

INSERT INTO [dbo].[ProductFiles]
           ([ProductId]
           ,[ProductFileTypeId]
           ,[FileName]
           ,[Deleted])
     VALUES
           (3
           ,1
           ,N'3.jpg'
           ,0)

SET @ViewCounter=1
WHILE ( @ViewCounter <= 8)
BEGIN
    INSERT INTO [dbo].[ProductViewers]
           ([ProductId]
           ,[UserId]
           ,[Deleted])
     VALUES
           (3
           ,NULL
           ,0)
    SET @ViewCounter  = @ViewCounter  + 1
END

SET @LikeCounter=1
WHILE ( @LikeCounter <= 10)
BEGIN
    INSERT INTO [dbo].[ProductLikes]
           ([ProductId]
           ,[UserId]
           ,[Deleted])
     VALUES
           (3
           ,NULL
           ,0)
    SET @LikeCounter  = @LikeCounter  + 1
END

SET IDENTITY_INSERT Products OFF;

");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
