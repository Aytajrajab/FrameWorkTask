﻿// <auto-generated />
using System;
using FrameWorkTask.DAL;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FrameWorkTask.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FrameWorkTask.Models.Baskets", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("userIdId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("userIdId");

                    b.ToTable("Basket");
                });

            modelBuilder.Entity("FrameWorkTask.Models.Categories", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("FrameWorkTask.Models.Favorites", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("userIdId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("userIdId");

                    b.ToTable("Favorite");
                });

            modelBuilder.Entity("FrameWorkTask.Models.Orders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("productIdId")
                        .HasColumnType("int");

                    b.Property<int?>("userIdId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("productIdId");

                    b.HasIndex("userIdId");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("FrameWorkTask.Models.Products", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("categoryIdId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("categoryIdId");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("FrameWorkTask.Models.Roles", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Role")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("FrameWorkTask.Models.Users", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("userRoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("userRoleId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("FrameWorkTask.Models.Baskets", b =>
                {
                    b.HasOne("FrameWorkTask.Models.Users", "userId")
                        .WithMany()
                        .HasForeignKey("userIdId");

                    b.Navigation("userId");
                });

            modelBuilder.Entity("FrameWorkTask.Models.Favorites", b =>
                {
                    b.HasOne("FrameWorkTask.Models.Users", "userId")
                        .WithMany()
                        .HasForeignKey("userIdId");

                    b.Navigation("userId");
                });

            modelBuilder.Entity("FrameWorkTask.Models.Orders", b =>
                {
                    b.HasOne("FrameWorkTask.Models.Products", "productId")
                        .WithMany()
                        .HasForeignKey("productIdId");

                    b.HasOne("FrameWorkTask.Models.Users", "userId")
                        .WithMany()
                        .HasForeignKey("userIdId");

                    b.Navigation("productId");

                    b.Navigation("userId");
                });

            modelBuilder.Entity("FrameWorkTask.Models.Products", b =>
                {
                    b.HasOne("FrameWorkTask.Models.Categories", "categoryId")
                        .WithMany()
                        .HasForeignKey("categoryIdId");

                    b.Navigation("categoryId");
                });

            modelBuilder.Entity("FrameWorkTask.Models.Users", b =>
                {
                    b.HasOne("FrameWorkTask.Models.Roles", "userRole")
                        .WithMany()
                        .HasForeignKey("userRoleId");

                    b.Navigation("userRole");
                });
#pragma warning restore 612, 618
        }
    }
}
