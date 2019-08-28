﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using hobby.Models;

namespace hobby.Migrations
{
    [DbContext(typeof(MyContext))]
    partial class MyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("hobby.Models.Hobby", b =>
                {
                    b.Property<int>("HobbyId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("Description")
                        .IsRequired();

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<int>("UserId");

                    b.HasKey("HobbyId");

                    b.HasIndex("UserId");

                    b.ToTable("Hobbies");
                });

            modelBuilder.Entity("hobby.Models.Join", b =>
                {
                    b.Property<int>("JoinId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("HobbyId");

                    b.Property<int>("UserId");

                    b.HasKey("JoinId");

                    b.HasIndex("HobbyId");

                    b.HasIndex("UserId");

                    b.ToTable("Joins");
                });

            modelBuilder.Entity("hobby.Models.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("Password")
                        .IsRequired();

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("Username")
                        .IsRequired();

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("hobby.Models.Hobby", b =>
                {
                    b.HasOne("hobby.Models.User", "Creator")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("hobby.Models.Join", b =>
                {
                    b.HasOne("hobby.Models.Hobby", "hobby")
                        .WithMany("joinList")
                        .HasForeignKey("HobbyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("hobby.Models.User", "User")
                        .WithMany("JoinList")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
