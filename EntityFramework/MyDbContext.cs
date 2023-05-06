using System;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework
{
    public class MyDbContext : DbContext
    {
        
        public DbSet<Person> Persons { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>

            optionsBuilder.UseSqlServer(
                "Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=LibraryDB; Integrated Security=True;");
    }
}
