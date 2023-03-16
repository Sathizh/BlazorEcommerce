﻿// <auto-generated />
using BlazorEcommerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    [DbContext(typeof(DataCongtext))]
    [Migration("20230316073232_ProductSeeding")]
    partial class ProductSeeding
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageURL")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "An apple mobile which is nothing like apple",
                            ImageURL = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/refurb-iphone11-purple-2019?wid=572&hei=572&fmt=jpeg&qlt=95&.v=1611169055000",
                            Price = 549m,
                            Title = "New Apple iPhone 11 (64GB) - Purple"
                        },
                        new
                        {
                            Id = 2,
                            Description = "An apple mobile which is nothing like apple",
                            ImageURL = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/refurb-iphone11-black-2019?wid=572&hei=572&fmt=jpeg&qlt=95&.v=1611169026000",
                            Price = 549m,
                            Title = "New Apple iPhone 11 (64GB) - Black"
                        },
                        new
                        {
                            Id = 3,
                            Description = "An apple mobile which is nothing like apple",
                            ImageURL = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/refurb-iphone11-white-2019?wid=572&hei=572&fmt=jpeg&qlt=95&.v=1611169090000",
                            Price = 549m,
                            Title = "New Apple iPhone 11 (64GB) - White"
                        },
                        new
                        {
                            Id = 4,
                            Description = "An apple mobile which is nothing like apple",
                            ImageURL = "https://store.storeimages.cdn-apple.com/4982/as-images.apple.com/is/refurb-iphone11-green-2019?wid=572&hei=572&fmt=jpeg&qlt=95&.v=1611169038000",
                            Price = 549m,
                            Title = "New Apple iPhone 11 (64GB) - Green"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}