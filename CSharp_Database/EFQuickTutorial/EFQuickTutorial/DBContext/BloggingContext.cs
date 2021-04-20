using EFQuickTutorial.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFQuickTutorial.DBContext
{
    public class BloggingContext : DbContext
    {
        // Connection String written directly in code like this would be usually considered as bad practice. 
        private const string ConnectionString = @"Data Source = C:\Temp\blogging.db";

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(ConnectionString);
    }
}


// Entity Relationship 1 : N for this example
// 1 blog can contain N posts. 1 post belongs to 1 blog.