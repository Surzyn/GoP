﻿// <auto-generated />
using System;
using GoPDataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GoPDataAccess.Migrations
{
    [DbContext(typeof(PubDataContext))]
    [Migration("20190417154608_createDB")]
    partial class createDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.8-servicing-32085")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GoPDataAccess.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate");

                    b.Property<int?>("PubId");

                    b.Property<int>("Rate");

                    b.Property<string>("Text");

                    b.HasKey("Id");

                    b.HasIndex("PubId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("GoPDataAccess.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CommentId");

                    b.Property<string>("ImageUrl");

                    b.HasKey("Id");

                    b.HasIndex("CommentId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("GoPDataAccess.Models.Pub", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Description");

                    b.Property<int?>("ImageId");

                    b.Property<string>("Name");

                    b.Property<double>("Rate");

                    b.Property<string>("Street");

                    b.HasKey("Id");

                    b.HasIndex("ImageId");

                    b.ToTable("Pubs");
                });

            modelBuilder.Entity("GoPDataAccess.Models.Comment", b =>
                {
                    b.HasOne("GoPDataAccess.Models.Pub")
                        .WithMany("Comments")
                        .HasForeignKey("PubId");
                });

            modelBuilder.Entity("GoPDataAccess.Models.Image", b =>
                {
                    b.HasOne("GoPDataAccess.Models.Comment")
                        .WithMany("Images")
                        .HasForeignKey("CommentId");
                });

            modelBuilder.Entity("GoPDataAccess.Models.Pub", b =>
                {
                    b.HasOne("GoPDataAccess.Models.Image", "Image")
                        .WithMany()
                        .HasForeignKey("ImageId");
                });
#pragma warning restore 612, 618
        }
    }
}
