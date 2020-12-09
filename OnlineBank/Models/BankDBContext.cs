using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineBank.Models
{
    public class BankDBContext : DbContext
    {
        public BankDBContext(DbContextOptions<BankDBContext> options) : base(options)
        {
            //this.Database.EnsureCreated();
        }

        public virtual DbSet<Registration> RegistrationTable { get; set; }
        public virtual DbSet<Roles> RolesTable { get; set; }
        public virtual DbSet<Benficiarys> Benficiarys { get; set; }
        public virtual DbSet<PaymentHistory> PaymentTable { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlServer(new AppConfiguration(_options).GetPublishingCompanyConn());
            }
        }
    }
}
