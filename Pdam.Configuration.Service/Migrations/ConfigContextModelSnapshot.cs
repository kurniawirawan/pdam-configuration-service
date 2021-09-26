﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using Pdam.Configuration.Service.DataContext;

namespace Pdam.Configuration.Service.Migrations
{
    [DbContext(typeof(ConfigContext))]
    partial class ConfigContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("Pdam.Configuration.Service.DataContext.Branch", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("BranchCode")
                        .HasColumnType("text");

                    b.Property<string>("BranchHeadName")
                        .HasColumnType("text");

                    b.Property<string>("BranchName")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("CompanyCode")
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CompanyCode");

                    b.HasIndex("BranchCode", "CompanyCode")
                        .IsUnique();

                    b.ToTable("Branches");
                });

            modelBuilder.Entity("Pdam.Configuration.Service.DataContext.Company", b =>
                {
                    b.Property<string>("CompanyCode")
                        .HasColumnType("text");

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .HasColumnType("text");

                    b.Property<string>("CompanyLegalName")
                        .HasColumnType("text");

                    b.Property<string>("CompanyName")
                        .HasColumnType("text");

                    b.Property<string>("CompanyWeb")
                        .HasColumnType("text");

                    b.Property<string>("DirectorName")
                        .HasColumnType("text");

                    b.Property<string>("FinanceHead")
                        .HasColumnType("text");

                    b.Property<string>("Logo")
                        .HasColumnType("text");

                    b.Property<string>("PaymentEndPoint")
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<int>("Subscription")
                        .HasColumnType("integer");

                    b.HasKey("CompanyCode");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Pdam.Configuration.Service.DataContext.CustomerGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CompanyCode")
                        .HasColumnType("text");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("CustomerGroupCode")
                        .HasColumnType("text");

                    b.Property<string>("CustomerGroupName")
                        .HasColumnType("text");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("CustomerGroupCode", "CompanyCode")
                        .IsUnique();

                    b.ToTable("CustomerGroups");
                });

            modelBuilder.Entity("Pdam.Configuration.Service.DataContext.CustomerGroupPricing", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("CustomerGroupId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("EndActive")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Notes")
                        .HasColumnType("text");

                    b.Property<string>("PriceName")
                        .HasColumnType("text");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uuid");

                    b.Property<DateTime>("StartActive")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("CustomerGroupId");

                    b.HasIndex("ProductId");

                    b.ToTable("CustomerGroupPricings");
                });

            modelBuilder.Entity("Pdam.Configuration.Service.DataContext.CustomerGroupPricingDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<Guid>("CustomerGroupPricingId")
                        .HasColumnType("uuid");

                    b.Property<decimal>("EndUnit")
                        .HasColumnType("numeric");

                    b.Property<bool>("IsFixedPrice")
                        .HasColumnType("boolean");

                    b.Property<string>("MappingColumn")
                        .HasColumnType("text");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("PriceName")
                        .HasColumnType("text");

                    b.Property<decimal>("SalesPrice")
                        .HasColumnType("numeric");

                    b.Property<decimal>("StartUnit")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.HasIndex("CustomerGroupPricingId");

                    b.ToTable("CustomerGroupPricingDetails");
                });

            modelBuilder.Entity("Pdam.Configuration.Service.DataContext.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("CompanyCode")
                        .HasColumnType("text");

                    b.Property<string>("CompanyCode1")
                        .HasColumnType("text");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("MarketName")
                        .HasColumnType("text");

                    b.Property<string>("MethodValuating")
                        .HasColumnType("text");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("text");

                    b.Property<DateTime?>("ModifiedDate")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("PricingMethod")
                        .HasColumnType("text");

                    b.Property<string>("ProductCode")
                        .HasColumnType("text");

                    b.Property<string>("ProductName")
                        .HasColumnType("text");

                    b.Property<string>("Uom")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CompanyCode1");

                    b.HasIndex("ProductCode", "CompanyCode")
                        .IsUnique();

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Pdam.Configuration.Service.DataContext.Branch", b =>
                {
                    b.HasOne("Pdam.Configuration.Service.DataContext.Company", "Company")
                        .WithMany("Branches")
                        .HasForeignKey("CompanyCode");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Pdam.Configuration.Service.DataContext.CustomerGroupPricing", b =>
                {
                    b.HasOne("Pdam.Configuration.Service.DataContext.CustomerGroup", "CustomerGroup")
                        .WithMany("CustomerGroupPricings")
                        .HasForeignKey("CustomerGroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Pdam.Configuration.Service.DataContext.Product", "Product")
                        .WithMany("CustomerGroupPricings")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerGroup");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Pdam.Configuration.Service.DataContext.CustomerGroupPricingDetail", b =>
                {
                    b.HasOne("Pdam.Configuration.Service.DataContext.CustomerGroupPricing", "CustomerGroupPricing")
                        .WithMany("CustomerGroupPricingDetails")
                        .HasForeignKey("CustomerGroupPricingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerGroupPricing");
                });

            modelBuilder.Entity("Pdam.Configuration.Service.DataContext.Product", b =>
                {
                    b.HasOne("Pdam.Configuration.Service.DataContext.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyCode1");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Pdam.Configuration.Service.DataContext.Company", b =>
                {
                    b.Navigation("Branches");
                });

            modelBuilder.Entity("Pdam.Configuration.Service.DataContext.CustomerGroup", b =>
                {
                    b.Navigation("CustomerGroupPricings");
                });

            modelBuilder.Entity("Pdam.Configuration.Service.DataContext.CustomerGroupPricing", b =>
                {
                    b.Navigation("CustomerGroupPricingDetails");
                });

            modelBuilder.Entity("Pdam.Configuration.Service.DataContext.Product", b =>
                {
                    b.Navigation("CustomerGroupPricings");
                });
#pragma warning restore 612, 618
        }
    }
}
