namespace MiniProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initials : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "LastName", c => c.String(nullable: false, maxLength: 30));
            AddColumn("dbo.Customers", "DateOfBirth", c => c.DateTime(nullable: false));
            DropColumn("dbo.Customers", "PassengerName");
            DropColumn("dbo.Customers", "DepartureDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Customers", "DepartureDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Customers", "PassengerName", c => c.String(nullable: false, maxLength: 30));
            DropColumn("dbo.Customers", "DateOfBirth");
            DropColumn("dbo.Customers", "LastName");
        }
    }
}
