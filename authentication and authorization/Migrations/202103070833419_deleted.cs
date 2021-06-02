namespace authentication_and_authorization.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class deleted : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.users", "classsno");
        }
        
        public override void Down()
        {
            AddColumn("dbo.users", "classsno", c => c.String());
        }
    }
}
