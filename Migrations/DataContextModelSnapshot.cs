﻿// <auto-generated />
using System;
using AppRestaurant.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AppRestaurant.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("AppRestaurant.Models.Restaurant", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("address");

                    b.Property<string>("city");

                    b.Property<string>("name");

                    b.Property<int>("number");

                    b.Property<string>("state");

                    b.HasKey("id");

                    b.ToTable("restaurant");
                });

            modelBuilder.Entity("AppRestaurant.Models.RestaurantConsumption", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("date");

                    b.Property<int?>("restaurantid");

                    b.Property<double>("value");

                    b.HasKey("id");

                    b.HasIndex("restaurantid");

                    b.ToTable("restaurantConsumption");
                });

            modelBuilder.Entity("AppRestaurant.Models.RestaurantConsumption", b =>
                {
                    b.HasOne("AppRestaurant.Models.Restaurant", "restaurant")
                        .WithMany()
                        .HasForeignKey("restaurantid");
                });
#pragma warning restore 612, 618
        }
    }
}
