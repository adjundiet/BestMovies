namespace BestMovies.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMembershipTypes : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO MembershipTypes(Name,Fee,Discount) VALUES ('Pay as You Go',0,0)");
            Sql("INSERT INTO MembershipTypes(Name,Fee,Discount) VALUES ('Monthly',30,10)");
            Sql("INSERT INTO MembershipTypes(Name,Fee,Discount) VALUES ('Qarterly',90,15)");
            Sql("INSERT INTO MembershipTypes(Name,Fee,Discount) VALUES ('Annual',300,20)");
        }
        
        public override void Down()
        {
            Sql("DELETE FROM MembershipTypes ");
        }
    }
}
