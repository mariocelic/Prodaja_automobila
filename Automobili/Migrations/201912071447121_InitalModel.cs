namespace Automobili.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitalModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Buyers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Adress = c.String(),
                        Kontakt = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sales",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CarName = c.String(),
                        Price = c.Single(nullable: false),
                        SalesmenName = c.String(),
                        BuyerName = c.String(),
                        Buyer_Id = c.Int(),
                        Car_Id = c.Int(),
                        Salesmen_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Buyers", t => t.Buyer_Id)
                .ForeignKey("dbo.Cars", t => t.Car_Id)
                .ForeignKey("dbo.Salesmen", t => t.Salesmen_Id)
                .Index(t => t.Buyer_Id)
                .Index(t => t.Car_Id)
                .Index(t => t.Salesmen_Id);
            
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CarMaker = c.String(),
                        CarModel = c.String(),
                        YearManufacture = c.Int(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Salesmen",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        PhoneNumber = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sales", "Salesmen_Id", "dbo.Salesmen");
            DropForeignKey("dbo.Sales", "Car_Id", "dbo.Cars");
            DropForeignKey("dbo.Sales", "Buyer_Id", "dbo.Buyers");
            DropIndex("dbo.Sales", new[] { "Salesmen_Id" });
            DropIndex("dbo.Sales", new[] { "Car_Id" });
            DropIndex("dbo.Sales", new[] { "Buyer_Id" });
            DropTable("dbo.Salesmen");
            DropTable("dbo.Cars");
            DropTable("dbo.Sales");
            DropTable("dbo.Buyers");
        }
    }
}
