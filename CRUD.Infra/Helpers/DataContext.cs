using CRUD.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace CRUD.Infra.Helpers
{
    public class DataContext : DbContext
    {
        public DbSet<Users> Users { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
    }
}
