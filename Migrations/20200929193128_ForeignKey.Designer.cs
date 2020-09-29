﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Term_Project_Version_1.Models;

namespace Term_Project_Version_1.Migrations
{
    [DbContext(typeof(SeekingAllahContext))]
    [Migration("20200929193128_ForeignKey")]
    partial class ForeignKey
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Term_Project_Version_1.Models.Members", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("ID");

                    b.ToTable("Membership");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            email = "michelle@vanwetteregroup.com",
                            name = "Michelle Vanwettere"
                        },
                        new
                        {
                            ID = 2,
                            email = "tito.nugaily@gmail.com",
                            name = "Tito Nugauily"
                        },
                        new
                        {
                            ID = 3,
                            email = "david.wood@acts17.com",
                            name = "David Wood"
                        },
                        new
                        {
                            ID = 4,
                            email = "mgibson@makeitrain.com",
                            name = "Matthew Gibson"
                        },
                        new
                        {
                            ID = 5,
                            email = "mohamedayew@gmail.com",
                            name = "Mohamed Ayew"
                        },
                        new
                        {
                            ID = 6,
                            email = "mayadamohamed@gmail.com",
                            name = "Meda Doyle"
                        });
                });

            modelBuilder.Entity("Term_Project_Version_1.Models.Purchases", b =>
                {
                    b.Property<string>("ID")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("MembersID")
                        .HasColumnType("int");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("MembersID");

                    b.ToTable("Purchases");

                    b.HasData(
                        new
                        {
                            ID = "SA",
                            MembersID = 1,
                            Price = "$19.99"
                        },
                        new
                        {
                            ID = "FS",
                            MembersID = 6,
                            Price = "$79.99"
                        },
                        new
                        {
                            ID = "FA",
                            MembersID = 5,
                            Price = "$109.99"
                        });
                });

            modelBuilder.Entity("Term_Project_Version_1.Models.Purchases", b =>
                {
                    b.HasOne("Term_Project_Version_1.Models.Members", "Members")
                        .WithMany()
                        .HasForeignKey("MembersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
