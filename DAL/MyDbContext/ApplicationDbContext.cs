using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.MyDbContext
{
    public  class ApplicationDbContext:DbContext
    {
        internal DbSet<User> Users { get; set; }
        internal DbSet<Debit> Debits { get; set; }
        internal DbSet<UserDebit> UserDebits { get; set; }
        internal DbSet<Product> Products { get; set; }
        internal DbSet<WareHouse> WareHouses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-D9VP0D9\\SQLEXPRESS;database=VarlikDB;trusted_connection=true;trustservercertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Debit>()
               .HasOne(d => d.AssigningUser)
              .WithMany(u => u.DebitsAssigned)
               .HasForeignKey(d => d.AssigninguserId)
                .OnDelete(DeleteBehavior.Restrict); // Eğer bir kullanıcı silinirse, ona bağlı zimmetler silinmesin diye kısıtlama koyuyoruz.
           
            modelBuilder.Entity<Debit>()
                .HasOne(d => d.AssignedUser)
                .WithMany(u => u.DebitsReceived)
                .HasForeignKey(d => d.AssigneduserId)
                .OnDelete(DeleteBehavior.Restrict); //yani kullanıcı silinirse, ona zimmetlenen kayıtlar etkilenmesin.

        }
    }
}
