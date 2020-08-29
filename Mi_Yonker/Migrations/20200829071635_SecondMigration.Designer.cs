﻿// <auto-generated />
using Mi_Yonker.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Mi_Yonker.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20200829071635_SecondMigration")]
    partial class SecondMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Mi_Yonker.Modelos.Brands", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("brands");
                });

            modelBuilder.Entity("Mi_Yonker.Modelos.Models", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("model")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("models");
                });

            modelBuilder.Entity("Mi_Yonker.Modelos.Partlist", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("partlist");
                });

            modelBuilder.Entity("Mi_Yonker.Modelos.Partlist_details", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("detail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("idpart")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("idpart");

                    b.ToTable("partlist_Details");
                });

            modelBuilder.Entity("Mi_Yonker.Modelos.Parts_vehicle", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("partId")
                        .HasColumnType("int");

                    b.Property<int>("vehicleId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("partId");

                    b.HasIndex("vehicleId");

                    b.ToTable("parts_Vehicles");
                });

            modelBuilder.Entity("Mi_Yonker.Modelos.Stores", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("contact_person")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("facebook")
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("latitue")
                        .HasColumnType("real");

                    b.Property<float>("longitude")
                        .HasColumnType("real");

                    b.Property<string>("name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("owner")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("owner_id")
                        .HasColumnType("int");

                    b.Property<string>("phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("rtn")
                        .HasColumnType("int");

                    b.Property<string>("website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("stores");
                });

            modelBuilder.Entity("Mi_Yonker.Modelos.Users", b =>
                {
                    b.Property<int>("iduser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("storeId")
                        .HasColumnType("int");

                    b.Property<int>("usertype")
                        .HasColumnType("int");

                    b.HasKey("iduser");

                    b.HasIndex("storeId");

                    b.ToTable("users");
                });

            modelBuilder.Entity("Mi_Yonker.Modelos.Vehicles", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("brandId")
                        .HasColumnType("int");

                    b.Property<int>("modelId")
                        .HasColumnType("int");

                    b.Property<int>("year")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("brandId");

                    b.HasIndex("modelId");

                    b.ToTable("vehicles");
                });

            modelBuilder.Entity("Mi_Yonker.Modelos.Vehicles_stores", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("storeId")
                        .HasColumnType("int");

                    b.Property<int>("vehicleId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("storeId");

                    b.HasIndex("vehicleId");

                    b.ToTable("vehicles_Stores");
                });

            modelBuilder.Entity("Mi_Yonker.Modelos.Partlist_details", b =>
                {
                    b.HasOne("Mi_Yonker.Modelos.Partlist", "Partlist")
                        .WithMany()
                        .HasForeignKey("idpart")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Mi_Yonker.Modelos.Parts_vehicle", b =>
                {
                    b.HasOne("Mi_Yonker.Modelos.Partlist", "Partlist")
                        .WithMany()
                        .HasForeignKey("partId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mi_Yonker.Modelos.Vehicles", "Vehicles")
                        .WithMany()
                        .HasForeignKey("vehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Mi_Yonker.Modelos.Users", b =>
                {
                    b.HasOne("Mi_Yonker.Modelos.Stores", "Stores")
                        .WithMany()
                        .HasForeignKey("storeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Mi_Yonker.Modelos.Vehicles", b =>
                {
                    b.HasOne("Mi_Yonker.Modelos.Brands", "Brands")
                        .WithMany()
                        .HasForeignKey("brandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mi_Yonker.Modelos.Models", "Models")
                        .WithMany()
                        .HasForeignKey("modelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Mi_Yonker.Modelos.Vehicles_stores", b =>
                {
                    b.HasOne("Mi_Yonker.Modelos.Stores", "Stores")
                        .WithMany()
                        .HasForeignKey("storeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Mi_Yonker.Modelos.Vehicles", "Vehicles")
                        .WithMany()
                        .HasForeignKey("vehicleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
