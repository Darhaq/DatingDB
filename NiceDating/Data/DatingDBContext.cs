﻿using Microsoft.EntityFrameworkCore;
using DatingDB.Models;

namespace DatingDB.Data
{
    public class DatingDBContext : DbContext
    {
        //public DbSet<Customer> Customers { get; set; } = null!;
        //public DbSet<Order> Orders { get; set; } = null!;
        //public DbSet<Product> Products { get; set; } = null!;
        //public DbSet<OrderDetail> OrderDetails { get; set; } = null!;

        public DatingDBContext(DbContextOptions<DatingDBContext> options)
            : base(options)
        {

        }
        public DbSet<City> Cities { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<Person> Persons { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=NiceDating;Integrated Security=True;");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Person>()
                .Property(e => e.CreateDate)
                .HasDefaultValueSql("GETDATE()"); // or .HasDefaultValue(DateTime.Now) for non-SQL Server databases

            //modelBuilder.Entity<Like>()
            //   .Property(e => e.Status)
            //   .HasDefaultValueSql("0");

            //modelBuilder.Entity<Message>()
            //   .Property(e => e.Status)
            //   .HasDefaultValueSql("0");

            modelBuilder.Entity<City>()
                .HasIndex(b => b.CityName)
                .IsUnique()
                .HasFilter(null);

            //modelBuilder.Entity<City>()
            //.Property(et => et.Id)
            //.ValueGeneratedNever();

            // Configure the many-to-many relationship between UserProfile and Like
            //modelBuilder.Entity<Like>()
            //    .HasKey(l => l.Id);

            //modelBuilder.Entity<Like>()
            //    .HasOne(l => l.Liker)
            //    .WithMany(u => u.LikedUsers)
            //    .HasForeignKey(l => l.LikerId)
            //    .OnDelete(DeleteBehavior.Restrict); // Set the appropriate delete behavior

            //modelBuilder.Entity<Like>()
            //    .HasOne(l => l.Likee)
            //    .WithMany(u => u.LikedByUsers)
            //    .HasForeignKey(l => l.LikeeId)
            //    .OnDelete(DeleteBehavior.Restrict); // Set the appropriate delete behavior

            // Additional configurations for UserProfile entity if needed
            //modelBuilder.Entity<UserProfile>()
            //    .HasMany(u => u.LikedUsers)
            //    .WithOne(l => l.Liker)
            //    .HasForeignKey(l => l.LikerId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<UserProfile>()
            //    .HasMany(u => u.LikedByUsers)
            //    .WithOne(l => l.Likee)
            //    .HasForeignKey(l => l.LikeeId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //-------------
            // Configure the many-to-many relationship between UserProfile and Message
            //modelBuilder.Entity<Message>()
            //    .HasKey(l => l.Id);

            //modelBuilder.Entity<Message>()
            //    .HasOne(l => l.Sender)
            //    .WithMany(u => u.ReceivedByUsers)
            //    .HasForeignKey(l => l.SenderId)
            //    .OnDelete(DeleteBehavior.Restrict); // Set the appropriate delete behavior

            //modelBuilder.Entity<Message>()
            //    .HasOne(l => l.Receiver)
            //    .WithMany(u => u.SentByUsers)
            //    .HasForeignKey(l => l.ReceiverId)
            //    .OnDelete(DeleteBehavior.Restrict); // Set the appropriate delete behavior

            //// Additional configurations for UserProfile entity if needed
            //modelBuilder.Entity<UserProfile>()
            //    .HasMany(u => u.LikedUsers)
            //    .WithOne(l => l.Liker)
            //    .HasForeignKey(l => l.LikerId)
            //    .OnDelete(DeleteBehavior.Restrict);

            //modelBuilder.Entity<UserProfile>()
            //    .HasMany(u => u.LikedByUsers)
            //    .WithOne(l => l.Likee)
            //    .HasForeignKey(l => l.LikeeId)
            //    .OnDelete(DeleteBehavior.Restrict);



            //modelBuilder.Entity<Gender>()
            //    .HasIndex(b => b.GenderName)
            //    .IsUnique()
            //    .HasFilter(null);
        }
    }
}
