namespace BookEntity.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class O : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.BookLoans", "Status_Id", "dbo.BookLoanStatus");
            DropIndex("dbo.BookLoans", new[] { "Status_Id" });
            DropPrimaryKey("dbo.BookLoanStatus");
            AlterColumn("dbo.BookLoans", "Status_Id", c => c.Int());
            AlterColumn("dbo.BookLoanStatus", "Id", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.BookLoanStatus", "Id");
            CreateIndex("dbo.BookLoans", "Status_Id");
            AddForeignKey("dbo.BookLoans", "Status_Id", "dbo.BookLoanStatus", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.BookLoans", "Status_Id", "dbo.BookLoanStatus");
            DropIndex("dbo.BookLoans", new[] { "Status_Id" });
            DropPrimaryKey("dbo.BookLoanStatus");
            AlterColumn("dbo.BookLoanStatus", "Id", c => c.Guid(nullable: false, identity: true));
            AlterColumn("dbo.BookLoans", "Status_Id", c => c.Guid());
            AddPrimaryKey("dbo.BookLoanStatus", "Id");
            CreateIndex("dbo.BookLoans", "Status_Id");
            AddForeignKey("dbo.BookLoans", "Status_Id", "dbo.BookLoanStatus", "Id");
        }
    }
}
