using System;
using ToHModels;
using ToHBL;
using ToHDL;
using ToHDL.Entities;
using Microsoft.Extensions.Configuration;
using System.IO;
using Microsoft.EntityFrameworkCore;

namespace ToHUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get the config file
            var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

            //Setting up db connection
            string connectionString =  configuration.GetConnectionString("HeroDB");
            DbContextOptions<BatchDBContext> options = new DbContextOptionsBuilder<BatchDBContext>()
            .UseSqlServer(connectionString).Options;

            //using statement used to dispose of the context when it is no longer used.
            using var context = new BatchDBContext(options);

            IMenu menu = new HeroMenu(new HeroBL(new HeroRepoDB(context, new HeroMapper())));
            menu.Start();
        }
    }
}
