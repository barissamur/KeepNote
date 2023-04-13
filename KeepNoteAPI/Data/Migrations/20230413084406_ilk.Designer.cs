﻿// <auto-generated />
using KeepNoteAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace KeepNoteAPI.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230413084406_ilk")]
    partial class ilk
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("KeepNoteAPI.Data.Note", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Notes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "This is the content of the first note.",
                            Title = "First Note"
                        },
                        new
                        {
                            Id = 2,
                            Content = "This is the content of the second note.",
                            Title = "Second Note"
                        },
                        new
                        {
                            Id = 3,
                            Title = "Third Note"
                        },
                        new
                        {
                            Id = 4,
                            Content = "This is the content of the fourth note.",
                            Title = "Fourth Note"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
