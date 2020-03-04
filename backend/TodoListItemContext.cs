using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace backend
{
    public class TodoListItemContext : DbContext
    {
        public DbSet<TodoListItem> TodoListItems { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=TodoSqlite.db;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoListItem>().ToTable("TodoListItem");
        }
    }

}