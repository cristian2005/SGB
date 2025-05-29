using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Security.Permissions;
using SGB.Entidades;

namespace SGB
{
    public class BibliotecaBDContext : DbContext
    {
        #region Entidades inizializacion 
        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Libros> Libros { get; set; }
        public DbSet<Prestamos> Prestamos { get; set; }
        #endregion
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                 .SetBasePath(Directory.GetCurrentDirectory())
                 .AddJsonFile("appsettings.json")
                 .Build();

            var connectionString = config.GetConnectionString("DefaultConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
