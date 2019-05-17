using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using ParqueBLL;
using System;
using System.Collections.Generic;
using System.Text;

namespace ParqueDAL
{
    class ParqueContext
    {
        public static readonly LoggerFactory FabricaLogger = new LoggerFactory(new[] { new ConsoleLoggerProvider((_, __) => true, true) });
        public DbSet<IPassaporte> Passaportes { get; set; }
        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Entrada> Entradas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
           // .UseLoggerFactory(FabricaLogger)

           .UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=DBMovieCF;Trusted_Connection=True;");
        }
    }
}
