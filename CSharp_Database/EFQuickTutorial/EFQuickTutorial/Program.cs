using EFQuickTutorial.DBContext;
using EFQuickTutorial.Model;
using System;
using System.Linq;

namespace EFQuickTutorial
{
    internal class Program
    {
        // Short Demo for Entity Framework Core 
        // Needs an existing sqlite database.
        private static void Main()
        {
            // Creates an instance of the important context class. 
            // It works as session to make queries against the database and will
            // be destroyed after the queries are done.
            using var db = new BloggingContext();

            // CRUD Operations
            // Create
            Console.WriteLine("Inserting a new blog");
            db.Add(new Blog { Url = "http://blogs.msdn.com/adonet" });
            db.SaveChanges();

            // Read
            Console.WriteLine("Quering for a blog");
            var blog = db.Blogs
                .OrderBy(b => b.BlogId)
                .First();
            

            // Update
            Console.WriteLine("Updating the blog and adding a post");
            blog.Url = "https://devblogs.microsoft.com/dotnet";
            blog.Posts.Add(
                new Post { Title = "Hello Universe", Content = "Just some Random Content" });
            db.SaveChanges();

            // Delete
            Console.WriteLine("Delete the blog again");
            db.Remove(blog);
            db.SaveChanges();
        }
    }
}
