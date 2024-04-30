using DigitalPolitechnicMobile.Repository.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace DigitalPolitechnicMobile.Repository
{
    internal class PolitechnicDBContext : DbContext
    {

        public PolitechnicDBContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<User> Users { get; set; }
        public DbSet<News> News { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<Map> Maps { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=politech.db");
        }
                
    }
}
