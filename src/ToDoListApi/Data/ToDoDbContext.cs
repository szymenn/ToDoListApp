using Microsoft.EntityFrameworkCore;
using ToDoListApi.Entities;

namespace ToDoListApi.Data
{
    public class ToDoDbContext : DbContext
    {
        public ToDoDbContext(DbContextOptions<ToDoDbContext> options)
            : base(options)
        {
            Database.Migrate();
        }
        
        public DbSet<ToDo> ToDos { get; set; }
    }
}