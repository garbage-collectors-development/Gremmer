using Microsoft.EntityFrameworkCore;
using System;
using Gremmer.Server.Services.EntityFramework.Entities;

namespace Gremmer.Server.Services.EntityFramework
{
    public class GremmerContext : DbContext
    {
        public GremmerContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<ApplicationUser> Users { get; set; }
    }
}
