﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using vxTel.Domain.Entities;
using vxTel.Repository.Mapping;

namespace vxTel.Repository.Context
{
    public class VxTelContext : DbContext
    {
        public DbSet<TarifaLigacao> TarifaLigacao { get; set; }
        public DbSet<PlanoTelefonia> PlanoTelefonia { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TarifaLigacaoMapping());
            modelBuilder.ApplyConfiguration(new PlanoTelefoniaMapping());

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {           
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            
            optionsBuilder.UseSqlServer(config.GetConnectionString("DefaultConnection"));
        }
    }
}
