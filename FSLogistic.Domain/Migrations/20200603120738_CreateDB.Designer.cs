﻿// <auto-generated />
using System;
using FSLogistic.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace FSLogistic.Domain.Migrations
{
    [DbContext(typeof(FreeShipLogisticResourceContext))]
    [Migration("20200603120738_CreateDB")]
    partial class CreateDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FSLogistic.Domain.Models.Account", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthenId")
                        .HasColumnType("int");

                    b.Property<string>("CodeStaff")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Account");
                });

            modelBuilder.Entity("FSLogistic.Domain.Models.Autocomplete", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Data")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Enum")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Autocomplete");
                });

            modelBuilder.Entity("FSLogistic.Domain.Models.Bill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AccountId")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AdvanceMoney")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<string>("CustomerNote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("District")
                        .HasColumnType("int");

                    b.Property<DateTime>("DoneDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NameReceiver")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShippingFee")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StaffNote")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("TotalPrice")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("AccountId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Bill");
                });

            modelBuilder.Entity("FSLogistic.Domain.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodeCustomer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NameCustomer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Q1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Q10")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Q11")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Q12")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Q2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Q3")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Q4")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Q5")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Q6")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Q7")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Q8")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Q9")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QBC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QBTH")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QBTN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QCG")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QGV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QHM")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QNB")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QPN")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QTB")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QTD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QTP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Qcc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpdatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("FSLogistic.Domain.Models.Summary", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Note")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherPay")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TotalPrice")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UpdateBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Summary");
                });

            modelBuilder.Entity("FSLogistic.Domain.Models.Bill", b =>
                {
                    b.HasOne("FSLogistic.Domain.Models.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId");

                    b.HasOne("FSLogistic.Domain.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId");
                });
#pragma warning restore 612, 618
        }
    }
}
