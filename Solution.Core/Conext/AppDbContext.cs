using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using Solution.Core.Models.Entities;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Solution.Core.Conext
{
    public class AppDbContext : DbContext
    {
        public DbSet<Fruit> Fruits { get; set; }
        public DbSet<NutritionInfo> NutritionInfos { get; set; }

        public AppDbContext() : base()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(LocalDB)\\MSSQLLocalDB;Database=Fruits;Trusted_Connection=True");
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Fruit>()
            //                          .HasOne(x => x.NutritionInfo);

            //modelBuilder.Entity<NutritionInfo>()
            //                                       .HasData(new NutritionInfo(1, "Spiker"));
            //modelBuilder.Entity<NutritionInfo>()
            //                                       .HasData(new NutritionInfo(2, "Setter"));
            //modelBuilder.Entity<NutritionInfo>()
            //                                       .HasData(new NutritionInfo(3, "Libero"));
            //modelBuilder.Entity<NutritionInfo>()
            //                                       .HasData(new NutritionInfo(4, "Opposite"));
            //modelBuilder.Entity<NutritionInfo>()
            //                                       .HasData(new NutritionInfo(5, "Center"));

            //List<Fruit> Fruits = null;

            //using (FileStream fs = new FileStream("data.json", FileMode.Open, FileAccess.Read, FileShare.None))
            //{
            //    using (StreamReader sr = new StreamReader(fs, Encoding.UTF8))
            //    {
            //        string jsonData = sr.ReadToEnd();

            //        Fruits = JsonConvert.DeserializeObject<List<Fruit>>(jsonData);

            //        foreach (Fruit Fruit in Fruits)
            //        {
            //            modelBuilder.Entity<Fruit>()
            //                                       .HasData(Fruit);
            //        }
            //    }
            //}
        }
    }
}
