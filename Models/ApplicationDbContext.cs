using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tasker.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Task> Tasks { get; set; }
        // Added migrations using ef, dotnet-ef migrations add AddTaskToDatabase -o Migrations
        // Update the migrations file to Db, dotnet-ef database update
    }
}
