using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using ProjetoProgrammers.Domain.Entities;
using ProjetoProgrammers.Data.Mappings;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoProgrammers.Data.Context
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public ApplicationContext( DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new UserMap());
        }
    }
}
