namespace EnkuDesigns.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class thirdcommit : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Transactions", "Date", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Transactions", "Date", c => c.DateTime(nullable: false));
        }
    }
}
