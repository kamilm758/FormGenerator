using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace FormGenerator.Models
{
    public class FormGeneratorContext : DbContext
    {
        public FormGeneratorContext(DbContextOptions<FormGeneratorContext> options)
               : base(options)
        {

        }

        public FormGeneratorContext() { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }

        public DbSet<Field> Field { get; set; }
        public DbSet<Forms> Froms { get; set; }
        public DbSet<FormField> FormField { get; set; }
    }
}
