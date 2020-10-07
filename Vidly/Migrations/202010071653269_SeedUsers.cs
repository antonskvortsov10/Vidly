namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'14ebc3e0-a55a-42be-a2f5-f12649d97b60', N'guest@vidly.com', 0, N'AMUDeaW4Ws0aVbmPC7R8pJLjXNiqHWpH1u+NSp+FAQ2GvAUQWZOqHBD9ynGemJfXlw==', N'07c00815-1595-4dd7-b61d-5834a6bdf711', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'ef761596-ada2-4895-a501-fd48ac1f0c70', N'admin@vidly.com', 0, N'ABHhX8YsX+wfBZH+3Q6kYGFQu07zhWsfXOoosLYH6aUMmFphxPjSpgxu1gfjohjf2g==', N'3a67bbff-946c-4fe3-96e6-03db32332b07', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'7edfd302-3efa-480e-b878-f4a360dd7fe6', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'ef761596-ada2-4895-a501-fd48ac1f0c70', N'7edfd302-3efa-480e-b878-f4a360dd7fe6')
");
        }
        
        public override void Down()
        {
        }
    }
}
