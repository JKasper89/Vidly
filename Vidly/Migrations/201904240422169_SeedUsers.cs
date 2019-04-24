namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'0dc7f082-bbde-47dc-acda-f7a281a45e7d', N'admin@vidly.com', 0, N'AIlgUW5F3awp5ay78iyMSpKZNzuq5rt4yLJAWzBi0xBga/Xyx6Ut/joWItPn0dh8TQ==', N'4595baa9-34a5-4679-a11d-f6250f921c25', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')
                INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'4106072c-9b85-4c30-9a27-f45f7632f02e', N'guest@vidly.com', 0, N'ACAcA+LK8Bkh2MyJErvLonE1l4UIxw/8g6esvPeOiRnEhKoDJelMkpPafeicf0RPHA==', N'e814c9c0-60ba-4090-8dc9-ffdfb523a28d', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
                INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a410a54d-1de2-46c1-8666-693b8cbe0303', N'CanManageMovies')
                INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'0dc7f082-bbde-47dc-acda-f7a281a45e7d', N'a410a54d-1de2-46c1-8666-693b8cbe0303')
                ");
        }
        
        public override void Down()
        {
        }
    }
}
