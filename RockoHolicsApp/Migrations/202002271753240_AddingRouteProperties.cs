namespace RockoHolicsApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddingRouteProperties : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.City",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                        CountryID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Country", t => t.CountryID)
                .Index(t => t.CountryID);
            
            CreateTable(
                "dbo.Country",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Sector",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        CityID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.City", t => t.CityID)
                .Index(t => t.CityID);
            
            CreateTable(
                "dbo.Route",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 50),
                        Meters = c.Byte(nullable: false),
                        GradeID = c.Int(nullable: false),
                        SectionID = c.Int(nullable: false),
                        Sector_ID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Grade", t => t.GradeID)
                .ForeignKey("dbo.Sector", t => t.Sector_ID)
                .Index(t => t.GradeID)
                .Index(t => t.Sector_ID);
            
            CreateTable(
                "dbo.Grade",
                c => new
                    {
                        ID = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 10),
                        Points = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Route", "Sector_ID", "dbo.Sector");
            DropForeignKey("dbo.Route", "GradeID", "dbo.Grade");
            DropForeignKey("dbo.Sector", "CityID", "dbo.City");
            DropForeignKey("dbo.City", "CountryID", "dbo.Country");
            DropIndex("dbo.Route", new[] { "Sector_ID" });
            DropIndex("dbo.Route", new[] { "GradeID" });
            DropIndex("dbo.Sector", new[] { "CityID" });
            DropIndex("dbo.City", new[] { "CountryID" });
            DropTable("dbo.Grade");
            DropTable("dbo.Route");
            DropTable("dbo.Sector");
            DropTable("dbo.Country");
            DropTable("dbo.City");
        }
    }
}
