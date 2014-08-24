namespace CibraryP_K.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveCategory : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BookCategoryBooks", "Book_Id", "dbo.Books");
            DropForeignKey("dbo.BookCategoryBooks", "BookCategory_Id", "dbo.BookCategories");
            DropIndex("dbo.BookCategoryBooks", new[] { "BookCategory_Id" });
            DropIndex("dbo.BookCategoryBooks", new[] { "Book_Id" });
            DropTable("dbo.BookCategoryBooks");
            DropTable("dbo.BookCategories");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.BookCategoryBooks",
                c => new
                    {
                        BookCategory_Id = c.Int(nullable: false),
                        Book_Id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.BookCategory_Id, t.Book_Id });
            
            CreateTable(
                "dbo.BookCategories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.BookCategoryBooks", "Book_Id");
            CreateIndex("dbo.BookCategoryBooks", "BookCategory_Id");
            AddForeignKey("dbo.BookCategoryBooks", "Book_Id", "dbo.Books", "Id", cascadeDelete: true);
            AddForeignKey("dbo.BookCategoryBooks", "BookCategory_Id", "dbo.BookCategories", "Id", cascadeDelete: true);
        }
    }
}
