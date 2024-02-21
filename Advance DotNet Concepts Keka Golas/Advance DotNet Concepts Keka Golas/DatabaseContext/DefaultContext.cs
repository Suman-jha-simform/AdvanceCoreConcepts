using Advance_DotNet_Concepts_Keka_Goals.Models;
using Microsoft.EntityFrameworkCore;

namespace Advance_DotNet_Concepts_Keka_Goals.DatabaseContext
{
    public class DefaultContext : DbContext
    {
        public DefaultContext(){}
        public DefaultContext(DbContextOptions<DefaultContext> options) : base(options){}

        public DbSet<ToDoItem> ToDoItems { get; set; }
        public DbSet<ToDoItemUpdated> ToDoItemsUpdated { get; set; }
    }
}
