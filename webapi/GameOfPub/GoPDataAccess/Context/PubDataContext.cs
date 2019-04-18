using GoPDataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoPDataAccess.Context
{
    public class PubDataContext : DbContext
    {
        public DbSet<Pub> Pubs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"CONNECTION_STRING");
        }
    }
}
