﻿global using Microsoft.EntityFrameworkCore;
namespace MikroservisPrijavaNaLicitaciju.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=.\\SQLExpress;Database=PROJEKATdb;Trusted_Connection=true;TrustServerCertificate=true;");
        }

        public DbSet<PrijavaNaLicitaciju> PLics { get; set; }
    }
}
