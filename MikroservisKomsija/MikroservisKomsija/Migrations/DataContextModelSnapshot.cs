﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MikroservisKomsija.Data;

#nullable disable

namespace MikroservisKomsija.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MikroservisKomsija.Models.Clan", b =>
                {
                    b.Property<int>("IDClan")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IDClan"));

                    b.Property<string>("DatumRodjenja")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImeClana")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mjesto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PrezimeClana")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDClan");

                    b.ToTable("Clans");
                });

            modelBuilder.Entity("MikroservisKomsija.Models.Komisija", b =>
                {
                    b.Property<Guid>("IDKomsije")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ImeKomisije")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ovlascenje")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OznakaKomisije")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IDKomsije");

                    b.ToTable("Koms");
                });

            modelBuilder.Entity("MikroservisKomsija.Models.KomisijaClan", b =>
                {
                    b.Property<Guid>("IDKomsije")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("IDClan")
                        .HasColumnType("int");

                    b.Property<bool>("IsPredsjednik")
                        .HasColumnType("bit");

                    b.HasKey("IDKomsije", "IDClan");

                    b.ToTable("KCs");
                });
#pragma warning restore 612, 618
        }
    }
}
