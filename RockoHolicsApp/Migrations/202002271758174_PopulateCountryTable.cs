namespace RockoHolicsApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCountryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Country (Name) VALUES ('Greece')");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM Country WHERE ID IN (1)");
        }
    }
}
