﻿using Microsoft.EntityFrameworkCore;
using MovieApi.Models;

namespace MovieApi.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //To Create Foreing Key
            modelBuilder.Entity<Movie>()
                .HasOne(movie => movie.Director)
                .WithMany(director => director.Movies)
                .HasForeignKey(movie => movie.DirectorId);
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Director> Directors { get; set; }
    }
}