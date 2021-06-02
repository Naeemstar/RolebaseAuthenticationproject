namespace authentication_and_authorization.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class classnoadded : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.users", "classsno", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.users", "classsno");
        }
    }
}
