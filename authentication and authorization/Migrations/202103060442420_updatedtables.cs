namespace authentication_and_authorization.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updatedtables : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.users", new[] { "RoleId" });
            CreateIndex("dbo.users", "ROLEID");
        }
        
        public override void Down()
        {
            DropIndex("dbo.users", new[] { "ROLEID" });
            CreateIndex("dbo.users", "RoleId");
        }
    }
}
