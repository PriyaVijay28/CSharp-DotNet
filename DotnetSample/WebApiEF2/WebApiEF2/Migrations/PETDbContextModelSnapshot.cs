﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebApiEF2;

#nullable disable

namespace WebApiEF2.Migrations
{
    [DbContext(typeof(PETDbContext))]
    partial class PETDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WebApiEF2.Models.PET", b =>
                {
                    b.Property<int>("PId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PId"));

                    b.Property<string>("DOB")
                        .HasColumnType("text");

                    b.Property<string>("PName")
                        .HasColumnType("text");

                    b.Property<string>("PType")
                        .HasColumnType("text");

                    b.Property<bool>("isVeg")
                        .HasColumnType("boolean");

                    b.HasKey("PId");

                    b.ToTable("PET");
                });
#pragma warning restore 612, 618
        }
    }
}
