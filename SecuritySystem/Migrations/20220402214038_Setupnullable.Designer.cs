﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SecuritySystem.Models;

#nullable disable

namespace SecuritySystem.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20220402214038_Setupnullable")]
    partial class Setupnullable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("SecurityDataModel.OfficerData", b =>
                {
                    b.Property<int>("OfficerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OfficerId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OfficerGender")
                        .HasColumnType("int");

                    b.Property<string>("OfficerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OfficerRegistrationTime")
                        .HasColumnType("datetime2");

                    b.HasKey("OfficerId");

                    b.ToTable("OfficerDatas");
                });

            modelBuilder.Entity("SecurityDataModel.SecurityData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DOB")
                        .HasColumnType("datetime2");

                    b.Property<int?>("GetOfficersOfficerId")
                        .HasColumnType("int");

                    b.Property<int?>("GetStoresStoreId")
                        .HasColumnType("int");

                    b.Property<int>("IcCode")
                        .HasColumnType("int");

                    b.Property<string>("IncidentDetails")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Officer_Id")
                        .HasColumnType("int");

                    b.Property<int>("PoilceBadgeNumber")
                        .HasColumnType("int");

                    b.Property<string>("PoliceName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("RegDateTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("Sex")
                        .HasColumnType("int");

                    b.Property<int>("Store_Id")
                        .HasColumnType("int");

                    b.Property<string>("SuspectName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GetOfficersOfficerId");

                    b.HasIndex("GetStoresStoreId");

                    b.ToTable("SecurityDatas");
                });

            modelBuilder.Entity("SecurityDataModel.StoresData", b =>
                {
                    b.Property<int>("StoreId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StoreId"), 1L, 1);

                    b.Property<string>("PostCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StoreAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StoreName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StorePhone")
                        .HasColumnType("int");

                    b.Property<DateTime>("StoreRegistrationTime")
                        .HasColumnType("datetime2");

                    b.HasKey("StoreId");

                    b.ToTable("StoresDatas");
                });

            modelBuilder.Entity("SecurityDataModel.SecurityData", b =>
                {
                    b.HasOne("SecurityDataModel.OfficerData", "GetOfficers")
                        .WithMany()
                        .HasForeignKey("GetOfficersOfficerId");

                    b.HasOne("SecurityDataModel.StoresData", "GetStores")
                        .WithMany()
                        .HasForeignKey("GetStoresStoreId");

                    b.Navigation("GetOfficers");

                    b.Navigation("GetStores");
                });
#pragma warning restore 612, 618
        }
    }
}
