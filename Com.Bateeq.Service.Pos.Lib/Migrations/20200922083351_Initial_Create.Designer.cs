﻿// <auto-generated />
using System;
using Com.Danliris.Service.Inventory.Lib;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Com.Bateeq.Service.Pos.Lib.Migrations
{
    [DbContext(typeof(PosDbContext))]
    [Migration("20200922083351_Initial_Create")]
    partial class Initial_Create
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Com.Bateeq.Service.Pos.Lib.Models.Discount.Discount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("Code")
                        .HasMaxLength(255);

                    b.Property<int>("DiscountOne");

                    b.Property<int>("DiscountTwo");

                    b.Property<DateTimeOffset>("EndDate");

                    b.Property<string>("Information")
                        .HasMaxLength(255);

                    b.Property<DateTimeOffset>("StartDate");

                    b.Property<string>("StoreCategory")
                        .HasMaxLength(255);

                    b.Property<string>("StoreCode")
                        .HasMaxLength(255);

                    b.Property<int>("StoreId");

                    b.Property<string>("StoreName")
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.ToTable("Discounts");
                });

            modelBuilder.Entity("Com.Bateeq.Service.Pos.Lib.Models.Discount.DiscountDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("ArticleRealizationOrder")
                        .HasMaxLength(255);

                    b.Property<string>("Code")
                        .HasMaxLength(255);

                    b.Property<int>("DiscountItemId");

                    b.Property<float>("DomesticCOGS");

                    b.Property<float>("DomesticRetail");

                    b.Property<float>("DomesticSale");

                    b.Property<float>("DomesticWholesale");

                    b.Property<float>("InternationalCOGS");

                    b.Property<float>("InternationalRetail");

                    b.Property<float>("InternationalSale");

                    b.Property<float>("InternationalWholesale");

                    b.Property<int>("ItemId");

                    b.Property<string>("Name")
                        .HasMaxLength(255);

                    b.Property<string>("Size")
                        .HasMaxLength(255);

                    b.Property<string>("Uid")
                        .HasMaxLength(255);

                    b.Property<string>("Uom")
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.HasIndex("DiscountItemId");

                    b.ToTable("DiscountDetails");
                });

            modelBuilder.Entity("Com.Bateeq.Service.Pos.Lib.Models.Discount.DiscountItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<int>("DiscountId");

                    b.Property<string>("RealizationOrder")
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_CreatedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_CreatedUtc");

                    b.Property<string>("_DeletedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_DeletedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_DeletedUtc");

                    b.Property<bool>("_IsDeleted");

                    b.Property<string>("_LastModifiedAgent")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<string>("_LastModifiedBy")
                        .IsRequired()
                        .HasMaxLength(255);

                    b.Property<DateTime>("_LastModifiedUtc");

                    b.HasKey("Id");

                    b.HasIndex("DiscountId");

                    b.ToTable("DiscountItems");
                });

            modelBuilder.Entity("Com.Bateeq.Service.Pos.Lib.Models.Discount.DiscountDetail", b =>
                {
                    b.HasOne("Com.Bateeq.Service.Pos.Lib.Models.Discount.DiscountItem", "DiscountItem")
                        .WithMany("Details")
                        .HasForeignKey("DiscountItemId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Com.Bateeq.Service.Pos.Lib.Models.Discount.DiscountItem", b =>
                {
                    b.HasOne("Com.Bateeq.Service.Pos.Lib.Models.Discount.Discount", "Discount")
                        .WithMany("Items")
                        .HasForeignKey("DiscountId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
