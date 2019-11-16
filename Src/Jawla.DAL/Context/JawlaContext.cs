using Jawla.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Jawla.Context
{
    public class JawlaContext : DbContext
    {
        public JawlaContext(DbContextOptions<JawlaContext> options)
           : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("Server=MSHARIF\\SQLEXPRESS;Database=JawlaDB;User ID=sa;Password=sql2017;",
                b => b.MigrationsAssembly("Jawla.DAL"));
        }

        public virtual void Commit()
        {
            base.SaveChanges();
        }

        #region Data Set
        public DbSet<Account> Accounts { get; set; }
        #endregion
    }
}
