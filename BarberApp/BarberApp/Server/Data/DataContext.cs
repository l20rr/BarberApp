using BarberApp.Shared;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BarberApp.Server.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
