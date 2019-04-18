using GoPDataAccess.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace GoPDataAccess.Context
{
    public class PubDataContext : DbContext
    {
        public PubDataContext() : base()
        {
            this.Database.EnsureCreated();
        }

        public DbSet<Pub> Pubs { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Image> Images { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-FIRM\SQLEXPRESS;Initial Catalog=GoPubs;Integrated Security=True").EnableSensitiveDataLogging();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Image>().HasData(
                new { Id = 1, ImageUrl = "https://media-cdn.tripadvisor.com/media/photo-s/15/4b/fd/3d/gotta-love-that-monster.jpg", PubId = 1 },
                new { Id = 2, ImageUrl = "https://img.grouponcdn.com/deal/iAwMo3Nro6CReRkvnkj7/jL-2048x1229/v1/c700x420.jpg", CommentId = 1 },
                new { Id = 3, ImageUrl = "http://streetfoodpolska.pl/web/wp-content/uploads/2017/07/blu-przekr%C4%98j.jpg", CommentId = 1 },

                new { Id = 4, ImageUrl = "https://www.likealocalguide.com/media/cache/1e/52/1e52677c916d0d345e0897a5455d80a6.jpg", CommentId = 2 },
                new { Id = 5, ImageUrl = "http://wroclawskiejedzenie.pl/wp-content/uploads/2015/10/IMG_3731.jpg", PubId = 2 }

                );

            var pubs = new List<Pub>
            {
                new Pub(){Id = 1, Rate = 10, Name="M22",CreationDate = new DateTime(2017,11,11),Description = "Miejsce gdzie mozna zjesc dobrego burgera", Street="Marka"},
                new Pub(){Id = 2, Rate = 4, Name="Moa",CreationDate = new DateTime(2017,05,26),Description = "Miejsce gdzie mozna zjesc burgera", Street="Mikołajska"}
            };
            modelBuilder.Entity<Pub>().HasData(pubs.ToArray());

            modelBuilder.Entity<Comment>().HasData(
                new { PubId = 1, Id = 1, CreationDate = new DateTime(2018, 11, 1), Rate = 10, Text = "Najlepsze burgery w miescie" },
                new { PubId = 1, Id = 3, CreationDate = new DateTime(2018, 11, 21), Rate = 10, Text = "Najlepsza taksańska masakra!" },
                new { PubId = 2, Id = 2, CreationDate = DateTime.Now, Rate = 10, Text = "Nie polecam" }
            );

        }
    }
}
