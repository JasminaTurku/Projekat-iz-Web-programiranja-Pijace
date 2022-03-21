﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Models;

namespace Proba.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220310210732_V2")]
    partial class V2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.12")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Models.Korisnik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("KorisnickoIme")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Lozinka")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Korisnik");
                });

            modelBuilder.Entity("Models.Pijaca", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Pijaca");
                });

            modelBuilder.Entity("Models.PijacaTipProizvoda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("PijacaId")
                        .HasColumnType("int");

                    b.Property<int?>("TipProizvodaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PijacaId");

                    b.HasIndex("TipProizvodaId");

                    b.ToTable("PijacaTipProizvoda");
                });

            modelBuilder.Entity("Models.Proizvod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Cena")
                        .HasColumnType("int");

                    b.Property<bool>("Dostupan")
                        .HasColumnType("bit");

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int?>("PijacaId")
                        .HasColumnType("int");

                    b.Property<string>("Putanja")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TipProizvodaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PijacaId");

                    b.HasIndex("TipProizvodaId");

                    b.ToTable("Proizvod");
                });

            modelBuilder.Entity("Models.TipProizvoda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Naziv")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("TipProizvoda");
                });

            modelBuilder.Entity("Models.PijacaTipProizvoda", b =>
                {
                    b.HasOne("Models.Pijaca", "Pijaca")
                        .WithMany("PijacaTipProizvoda")
                        .HasForeignKey("PijacaId");

                    b.HasOne("Models.TipProizvoda", "TipProizvoda")
                        .WithMany("PijacaTipProizvoda")
                        .HasForeignKey("TipProizvodaId");

                    b.Navigation("Pijaca");

                    b.Navigation("TipProizvoda");
                });

            modelBuilder.Entity("Models.Proizvod", b =>
                {
                    b.HasOne("Models.Pijaca", "Pijaca")
                        .WithMany("Proizvodi")
                        .HasForeignKey("PijacaId");

                    b.HasOne("Models.TipProizvoda", "TipProizvoda")
                        .WithMany("Proizvodi")
                        .HasForeignKey("TipProizvodaId");

                    b.Navigation("Pijaca");

                    b.Navigation("TipProizvoda");
                });

            modelBuilder.Entity("Models.Pijaca", b =>
                {
                    b.Navigation("PijacaTipProizvoda");

                    b.Navigation("Proizvodi");
                });

            modelBuilder.Entity("Models.TipProizvoda", b =>
                {
                    b.Navigation("PijacaTipProizvoda");

                    b.Navigation("Proizvodi");
                });
#pragma warning restore 612, 618
        }
    }
}
