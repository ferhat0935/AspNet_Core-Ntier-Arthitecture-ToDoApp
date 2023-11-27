using Microsoft.EntityFrameworkCore;
using System;
using ToDoAppNtierDataAccess.Configuration;
using ToDoAppNtierEntities.Domains;

namespace ToDoAppNtierDataAccess.Context
{
    public class ToDoContext:DbContext 
    {
        public ToDoContext(DbContextOptions<ToDoContext>options):base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new WorkConfiguration());
          
           
        }
        public DbSet<Work> Works { get; set; }
    }
}
