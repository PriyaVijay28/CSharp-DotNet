﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebApiWithEF;

#nullable disable

namespace WebApiWithEF.Migrations
{
    [DbContext(typeof(CESDbContext))]
    partial class CESDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WebApiWithEF.Models.CES", b =>
                {
                    b.Property<int>("SId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("SId"));

                    b.Property<string>("SDept")
                        .HasColumnType("text");

                    b.Property<string>("SName")
                        .HasColumnType("text");

                    b.Property<string>("course1")
                        .HasColumnType("text");

                    b.Property<string>("course2")
                        .HasColumnType("text");

                    b.HasKey("SId");

                    b.ToTable("CES");
                });
#pragma warning restore 612, 618
        }
    }
}
