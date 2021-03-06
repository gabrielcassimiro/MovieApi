// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieApi.Data;

namespace MovieApi.Migrations
{
    [DbContext(typeof(MovieContext))]
    [Migration("20220604005815_DirectorIdNotRequired")]
    partial class DirectorIdNotRequired
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("MovieApi.Models.Director", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Directors");
                });

            modelBuilder.Entity("MovieApi.Models.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("DirectorId")
                        .HasColumnType("int");

                    b.Property<int?>("DirectorId1")
                        .HasColumnType("int");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Genre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("DirectorId");

                    b.HasIndex("DirectorId1")
                        .IsUnique();

                    b.ToTable("Movies");
                });

            modelBuilder.Entity("MovieApi.Models.Movie", b =>
                {
                    b.HasOne("MovieApi.Models.Director", "Director")
                        .WithMany("Movies")
                        .HasForeignKey("DirectorId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("MovieApi.Models.Director", null)
                        .WithOne("Movie")
                        .HasForeignKey("MovieApi.Models.Movie", "DirectorId1");

                    b.Navigation("Director");
                });

            modelBuilder.Entity("MovieApi.Models.Director", b =>
                {
                    b.Navigation("Movie");

                    b.Navigation("Movies");
                });
#pragma warning restore 612, 618
        }
    }
}
