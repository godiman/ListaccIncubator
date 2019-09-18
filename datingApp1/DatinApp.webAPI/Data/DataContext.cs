using Microsoft.EntityFrameworkCore;
using System;
using DatinApp.webAPI.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DatinApp.webAPI.Data
{
    public class DataContext : DbContext
    {
        //Constructor of the DataContext class with param
        //DbContextOptions and data type dataContext
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {

        }

         protected override void OnModelCreating (ModelBuilder modelBuilder)
         {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().ToTable("Users");
         }
         //The tables in the database
         public DbSet <User> Users {get; set;}
         public DbSet <Address> Addresses {get; set;}
         public DbSet <Like> Likes {get; set;}
         public DbSet <Message> Messages {get; set;}
         public DbSet <Photo> Photos {get; set;}
         public DbSet <Video> Videos {get; set;}
    }
}