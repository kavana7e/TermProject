﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TermProject.Models;

#nullable disable

namespace TermProject.Migrations
{
    [DbContext(typeof(ProductContext))]
    partial class ProductContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.33")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("TermProject.Models.Designer", b =>
                {
                    b.Property<int>("DesignerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DesignerId"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DesignerId");

                    b.ToTable("Designers");

                    b.HasData(
                        new
                        {
                            DesignerId = 1,
                            Name = "Elia Schall"
                        },
                        new
                        {
                            DesignerId = 2,
                            Name = "Romy Linder"
                        },
                        new
                        {
                            DesignerId = 3,
                            Name = "Hugo Karlen"
                        },
                        new
                        {
                            DesignerId = 4,
                            Name = "Elinora Felix"
                        },
                        new
                        {
                            DesignerId = 5,
                            Name = "Tessa Abeline"
                        });
                });

            modelBuilder.Entity("TermProject.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProductId"), 1L, 1);

                    b.Property<int>("DesignerId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SeasonId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Year")
                        .IsRequired()
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.HasIndex("DesignerId");

                    b.HasIndex("SeasonId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            DesignerId = 3,
                            Name = "Caviar Dreams Asymmetrical",
                            SeasonId = "S",
                            Type = "Skirt",
                            Year = 2022
                        },
                        new
                        {
                            ProductId = 2,
                            DesignerId = 2,
                            Name = "Effervescent Halter Wrap",
                            SeasonId = "F",
                            Type = "Top",
                            Year = 2022
                        },
                        new
                        {
                            ProductId = 3,
                            DesignerId = 5,
                            Name = "Nephilim Winged Bomber",
                            SeasonId = "F",
                            Type = "Jacket",
                            Year = 2023
                        },
                        new
                        {
                            ProductId = 4,
                            DesignerId = 1,
                            Name = "Counterculture Bootcut",
                            SeasonId = "S",
                            Type = "Pants",
                            Year = 2024
                        });
                });

            modelBuilder.Entity("TermProject.Models.Season", b =>
                {
                    b.Property<string>("SeasonId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SeasonId");

                    b.ToTable("Seasons");

                    b.HasData(
                        new
                        {
                            SeasonId = "S",
                            Name = "Spring/Summer"
                        },
                        new
                        {
                            SeasonId = "F",
                            Name = "Fall/Winter"
                        });
                });

            modelBuilder.Entity("TermProject.Models.Product", b =>
                {
                    b.HasOne("TermProject.Models.Designer", "Designer")
                        .WithMany()
                        .HasForeignKey("DesignerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TermProject.Models.Season", "Season")
                        .WithMany()
                        .HasForeignKey("SeasonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Designer");

                    b.Navigation("Season");
                });
#pragma warning restore 612, 618
        }
    }
}
