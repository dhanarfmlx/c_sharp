﻿// <auto-generated />
using System;
using ConsoleApp1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace ConsoleApp1.Migrations
{
    [DbContext(typeof(RackContext))]
    partial class RackContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityByDefaultColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("ConsoleApp1.Column", b =>
                {
                    b.Property<int>("ColumnID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.HasKey("ColumnID");

                    b.ToTable("Columns");
                });

            modelBuilder.Entity("ConsoleApp1.Shelf", b =>
                {
                    b.Property<int>("ShelfID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .UseIdentityByDefaultColumn();

                    b.Property<string>("Barcode")
                        .HasColumnType("text");

                    b.Property<int?>("ColumnID")
                        .HasColumnType("integer");

                    b.Property<int>("ShelfSize")
                        .HasColumnType("integer");

                    b.Property<int>("Theta")
                        .HasColumnType("integer");

                    b.HasKey("ShelfID");

                    b.HasIndex("ColumnID");

                    b.ToTable("Shelfs");
                });

            modelBuilder.Entity("ConsoleApp1.Shelf", b =>
                {
                    b.HasOne("ConsoleApp1.Column", "column")
                        .WithMany("Shelfs")
                        .HasForeignKey("ColumnID");

                    b.Navigation("column");
                });

            modelBuilder.Entity("ConsoleApp1.Column", b =>
                {
                    b.Navigation("Shelfs");
                });
#pragma warning restore 612, 618
        }
    }
}
