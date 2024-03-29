﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjectZeus.Database;

namespace ProjectZeus.Migrations
{
    [DbContext(typeof(ZeusContext))]
    [Migration("20210514162608_renamed deities to gods")]
    partial class renameddeitiestogods
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ProjectZeus.Database.Model.God", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("MythologyId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MythologyId");

                    b.ToTable("Gods");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            MythologyId = 2,
                            Name = "Odin"
                        },
                        new
                        {
                            Id = 2,
                            MythologyId = 1,
                            Name = "Zeus"
                        },
                        new
                        {
                            Id = 3,
                            MythologyId = 2,
                            Name = "Loki"
                        },
                        new
                        {
                            Id = 4,
                            MythologyId = 2,
                            Name = "Thor"
                        },
                        new
                        {
                            Id = 5,
                            MythologyId = 2,
                            Name = "Freya"
                        },
                        new
                        {
                            Id = 6,
                            MythologyId = 1,
                            Name = "Hera"
                        },
                        new
                        {
                            Id = 7,
                            MythologyId = 1,
                            Name = "Athena"
                        },
                        new
                        {
                            Id = 8,
                            MythologyId = 1,
                            Name = "Achilles"
                        },
                        new
                        {
                            Id = 9,
                            MythologyId = 1,
                            Name = "Hercules"
                        },
                        new
                        {
                            Id = 10,
                            MythologyId = 1,
                            Name = "Hermes"
                        });
                });

            modelBuilder.Entity("ProjectZeus.Database.Model.Mythology", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Mythologies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Greek"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Norse"
                        });
                });

            modelBuilder.Entity("ProjectZeus.Database.Model.God", b =>
                {
                    b.HasOne("ProjectZeus.Database.Model.Mythology", "Mythology")
                        .WithMany()
                        .HasForeignKey("MythologyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Mythology");
                });
#pragma warning restore 612, 618
        }
    }
}
