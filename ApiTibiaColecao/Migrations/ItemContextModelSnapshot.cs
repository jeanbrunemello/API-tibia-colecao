﻿// <auto-generated />
using ApiTibiaColecao.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ApiTibiaColecao.Migrations
{
    [DbContext(typeof(ItemContext))]
    partial class ItemContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ApiTibiaColecao.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("categoria")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("imagem")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<bool>("possui")
                        .HasColumnType("tinyint(1)");

                    b.HasKey("Id");

                    b.ToTable("Items");
                });
#pragma warning restore 612, 618
        }
    }
}
