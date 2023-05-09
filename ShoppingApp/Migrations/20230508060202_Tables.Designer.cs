﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShoppingApp.Data;

#nullable disable

namespace ShoppingApp.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230508060202_Tables")]
    partial class Tables
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ShoppingApp.Models.Bed", b =>
                {
                    b.Property<int>("BedId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BedId"));

                    b.Property<string>("BedName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("StockStatus")
                        .HasColumnType("int");

                    b.HasKey("BedId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Beds");
                });

            modelBuilder.Entity("ShoppingApp.Models.Bill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BillDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DeliveryDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("TotalPrice")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("ShoppingApp.Models.Buyer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Buyers");
                });

            modelBuilder.Entity("ShoppingApp.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ShoppingApp.Models.Chair", b =>
                {
                    b.Property<int>("ChairId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ChairId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("ChairImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChairName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("StockStatus")
                        .HasColumnType("int");

                    b.HasKey("ChairId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Chairs");
                });

            modelBuilder.Entity("ShoppingApp.Models.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BedId")
                        .HasColumnType("int");

                    b.Property<int?>("ChairId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int?>("SofaSetSofaId")
                        .HasColumnType("int");

                    b.Property<int?>("TableId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BedId");

                    b.HasIndex("ChairId");

                    b.HasIndex("ProductId");

                    b.HasIndex("SofaSetSofaId");

                    b.HasIndex("TableId");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("ShoppingApp.Models.Product", b =>
                {
                    b.Property<int>("ProdId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProdId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("ProductImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StockStatus")
                        .HasColumnType("int");

                    b.HasKey("ProdId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Productss");
                });

            modelBuilder.Entity("ShoppingApp.Models.Purchase", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("BillId")
                        .HasColumnType("int");

                    b.Property<double?>("Price")
                        .HasColumnType("float");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BillId");

                    b.HasIndex("ProductId");

                    b.ToTable("Purchases");
                });

            modelBuilder.Entity("ShoppingApp.Models.Seller", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sellers");
                });

            modelBuilder.Entity("ShoppingApp.Models.SofaSet", b =>
                {
                    b.Property<int>("SofaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SofaId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("SofaName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StockStatus")
                        .HasColumnType("int");

                    b.HasKey("SofaId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Sofasets");
                });

            modelBuilder.Entity("ShoppingApp.Models.Table", b =>
                {
                    b.Property<int>("TableId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TableId"));

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<int>("StockStatus")
                        .HasColumnType("int");

                    b.Property<string>("TableName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TableId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Tables");
                });

            modelBuilder.Entity("ShoppingApp.Models.Bed", b =>
                {
                    b.HasOne("ShoppingApp.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ShoppingApp.Models.Chair", b =>
                {
                    b.HasOne("ShoppingApp.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ShoppingApp.Models.Feedback", b =>
                {
                    b.HasOne("ShoppingApp.Models.Bed", null)
                        .WithMany("Feedbacks")
                        .HasForeignKey("BedId");

                    b.HasOne("ShoppingApp.Models.Chair", null)
                        .WithMany("Feedbacks")
                        .HasForeignKey("ChairId");

                    b.HasOne("ShoppingApp.Models.Product", "Product")
                        .WithMany("Feedbacks")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ShoppingApp.Models.SofaSet", null)
                        .WithMany("Feedbacks")
                        .HasForeignKey("SofaSetSofaId");

                    b.HasOne("ShoppingApp.Models.Table", null)
                        .WithMany("Feedbacks")
                        .HasForeignKey("TableId");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ShoppingApp.Models.Product", b =>
                {
                    b.HasOne("ShoppingApp.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ShoppingApp.Models.Purchase", b =>
                {
                    b.HasOne("ShoppingApp.Models.Bill", null)
                        .WithMany("Purchases")
                        .HasForeignKey("BillId");

                    b.HasOne("ShoppingApp.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("ShoppingApp.Models.SofaSet", b =>
                {
                    b.HasOne("ShoppingApp.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ShoppingApp.Models.Table", b =>
                {
                    b.HasOne("ShoppingApp.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("ShoppingApp.Models.Bed", b =>
                {
                    b.Navigation("Feedbacks");
                });

            modelBuilder.Entity("ShoppingApp.Models.Bill", b =>
                {
                    b.Navigation("Purchases");
                });

            modelBuilder.Entity("ShoppingApp.Models.Category", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("ShoppingApp.Models.Chair", b =>
                {
                    b.Navigation("Feedbacks");
                });

            modelBuilder.Entity("ShoppingApp.Models.Product", b =>
                {
                    b.Navigation("Feedbacks");
                });

            modelBuilder.Entity("ShoppingApp.Models.SofaSet", b =>
                {
                    b.Navigation("Feedbacks");
                });

            modelBuilder.Entity("ShoppingApp.Models.Table", b =>
                {
                    b.Navigation("Feedbacks");
                });
#pragma warning restore 612, 618
        }
    }
}
