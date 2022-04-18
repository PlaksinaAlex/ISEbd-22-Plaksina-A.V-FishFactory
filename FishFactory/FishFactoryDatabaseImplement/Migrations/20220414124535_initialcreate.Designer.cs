﻿// <auto-generated />
using System;
using FishFactoryDatabaseImplement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FishFactoryDatabaseImplement.Migrations
{
    [DbContext(typeof(FishFactoryDatabase))]
    [Migration("20220414124535_initialcreate")]
    partial class initialcreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FishFactoryDatabaseImplement.Models.Canned", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CannedName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Canneds");
                });

            modelBuilder.Entity("FishFactoryDatabaseImplement.Models.CannedComponent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CannedId")
                        .HasColumnType("int");

                    b.Property<int>("ComponentId")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CannedId");

                    b.HasIndex("ComponentId");

                    b.ToTable("CannedComponents");
                });

            modelBuilder.Entity("FishFactoryDatabaseImplement.Models.Component", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ComponentName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Components");
                });

            modelBuilder.Entity("FishFactoryDatabaseImplement.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CannedId")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateImplement")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<decimal>("Sum")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("CannedId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("FishFactoryDatabaseImplement.Models.WareHouse", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateCreate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ResponsibleFace")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WareHouseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WareHouses");
                });

            modelBuilder.Entity("FishFactoryDatabaseImplement.Models.WareHouseComponent", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ComponentId")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<int>("WareHouseId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ComponentId");

                    b.HasIndex("WareHouseId");

                    b.ToTable("WareHouseComponents");
                });

            modelBuilder.Entity("FishFactoryDatabaseImplement.Models.CannedComponent", b =>
                {
                    b.HasOne("FishFactoryDatabaseImplement.Models.Canned", "Canned")
                        .WithMany("CannedComponents")
                        .HasForeignKey("CannedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FishFactoryDatabaseImplement.Models.Component", "Component")
                        .WithMany("CannedComponents")
                        .HasForeignKey("ComponentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Canned");

                    b.Navigation("Component");
                });

            modelBuilder.Entity("FishFactoryDatabaseImplement.Models.Order", b =>
                {
                    b.HasOne("FishFactoryDatabaseImplement.Models.Canned", "Canned")
                        .WithMany("Orders")
                        .HasForeignKey("CannedId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Canned");
                });

            modelBuilder.Entity("FishFactoryDatabaseImplement.Models.WareHouseComponent", b =>
                {
                    b.HasOne("FishFactoryDatabaseImplement.Models.Component", "Component")
                        .WithMany("WareHouseComponents")
                        .HasForeignKey("ComponentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FishFactoryDatabaseImplement.Models.WareHouse", "WareHouse")
                        .WithMany("WareHouseComponents")
                        .HasForeignKey("WareHouseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Component");

                    b.Navigation("WareHouse");
                });

            modelBuilder.Entity("FishFactoryDatabaseImplement.Models.Canned", b =>
                {
                    b.Navigation("CannedComponents");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("FishFactoryDatabaseImplement.Models.Component", b =>
                {
                    b.Navigation("CannedComponents");

                    b.Navigation("WareHouseComponents");
                });

            modelBuilder.Entity("FishFactoryDatabaseImplement.Models.WareHouse", b =>
                {
                    b.Navigation("WareHouseComponents");
                });
#pragma warning restore 612, 618
        }
    }
}
