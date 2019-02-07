using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore.Infrastructure;
using ProjetoProgrammers.Data.Context;

namespace ProjetoProgrammers.Data.Core.Context
{
    class ApplicationContextFactory : IDesignTimeDbContextFactory<ApplicationContext>
    {

        public ApplicationContext CreateDbContext(string[] args)
        {
            var connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ProjetoProgrammers;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            var builder = new DbContextOptionsBuilder<ApplicationContext>();
            builder.UseSqlServer(connectionString);

            return new ApplicationContext(builder.Options);
        }
    }
}
