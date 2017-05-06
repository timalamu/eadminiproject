namespace MiniProject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        BookingID = c.Int(nullable: false, identity: true),
                        AccountID = c.Int(nullable: false),
                        DateOfBooking = c.DateTime(nullable: false),
                        PassengerName = c.String(nullable: false, maxLength: 60),
                        DepartureDate = c.DateTime(nullable: false),
                        ReturnDate = c.DateTime(nullable: false),
                        NumberOfPassengers = c.Int(nullable: false),
                        PointOfOrigin = c.String(nullable: false),
                        Destination = c.String(nullable: false),
                        FlightDuration = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BookingID)
                .ForeignKey("dbo.Customers", t => t.AccountID, cascadeDelete: true)
                .Index(t => t.AccountID);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        AccountID = c.Int(nullable: false, identity: true),
                        FirstMidName = c.String(nullable: false, maxLength: 30),
                        PassengerName = c.String(nullable: false, maxLength: 30),
                        Address = c.String(nullable: false),
                        DepartureDate = c.DateTime(nullable: false),
                        PhoneNo = c.String(nullable: false),
                        NumberOfPassengers = c.Int(nullable: false),
                        FrequentDestination = c.String(),
                        DestinationZone = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.AccountID);
            
            CreateTable(
                "dbo.CustomerBookings",
                c => new
                    {
                        TableID = c.Int(nullable: false, identity: true),
                        BookingID = c.Int(nullable: false),
                        AccountID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.TableID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bookings", "AccountID", "dbo.Customers");
            DropIndex("dbo.Bookings", new[] { "AccountID" });
            DropTable("dbo.CustomerBookings");
            DropTable("dbo.Customers");
            DropTable("dbo.Bookings");
        }
    }
}
