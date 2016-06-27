namespace MvcMovie.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        Genre = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);

            //this.CreateTable("dbo.Comments",
            //    tbl => new {
            //        CommentId = tbl.Int(nullable: false, identity: true),
            //        MovieId = tbl.Int(nullable: false, identity: false, storeType: )
            //    })
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Movies");
        }
    }
}
