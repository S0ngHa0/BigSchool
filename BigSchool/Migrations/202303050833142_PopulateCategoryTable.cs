﻿namespace BigSchool.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (1, 'Development')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (1, 'Busines')");
            Sql("INSERT INTO CATEGORIES (ID, NAME) VALUES (1, 'Maketing')");
        }
        
        public override void Down()
        {
        }
    }
}
