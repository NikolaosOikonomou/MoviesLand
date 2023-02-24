namespace MoviesLand.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class seedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'1b3d414e-e3fe-4375-a21f-6237be58c395', N'nikosoikonomou88@gmail.com', 0, N'AM41ei7oXBsoGnbUT7AX4toua9awl95aKxl4qghSDQkIXoh3n/7OUHsdT8uDfMcQPA==', N'3bc3bff2-e517-4e93-bed3-c325353f5b70', NULL, 0, 0, NULL, 1, 0, N'nikosoikonomou88@gmail.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'394ea5db-fec6-47f8-8e14-a9902f9013ae', N'admin@moviesLand.com', 0, N'ABY5+zEJmQUNr/FBHyGH7Njh42obM0NbMI2ncDMR9rUrnhtAEMrUI/VVJLnrqIQvag==', N'c575febe-a2a5-43e6-8347-9a68dc872c63', NULL, 0, 0, NULL, 1, 0, N'admin@moviesLand.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'9adada98-6a91-4cb1-b101-25f3bad21753', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'394ea5db-fec6-47f8-8e14-a9902f9013ae', N'9adada98-6a91-4cb1-b101-25f3bad21753')

");
        }
        
        public override void Down()
        {
        }
    }
}
