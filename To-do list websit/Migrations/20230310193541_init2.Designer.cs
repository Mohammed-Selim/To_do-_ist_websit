﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using To_do_list_websit.models;

#nullable disable

namespace To_do_list_websit.Migrations
{
    [DbContext(typeof(context))]
    [Migration("20230310193541_init2")]
    partial class init2
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("To_do_list_websit.models.DTOs.TaskDto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime?>("AssignDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("states")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("TaskDto");
                });

            modelBuilder.Entity("To_do_list_websit.models.categorys.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("TaskCategory", (string)null);
                });

            modelBuilder.Entity("To_do_list_websit.models.mytask.tasks", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime?>("AssignDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Categoryid")
                        .HasColumnType("int");

                    b.Property<int?>("Userid")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("states")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("Categoryid");

                    b.HasIndex("Userid");

                    b.ToTable("tasks", (string)null);
                });

            modelBuilder.Entity("To_do_list_websit.models.user.Users", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ID");

                    b.ToTable("user", (string)null);
                });

            modelBuilder.Entity("To_do_list_websit.models.mytask.tasks", b =>
                {
                    b.HasOne("To_do_list_websit.models.categorys.Category", "Category")
                        .WithMany("tasks")
                        .HasForeignKey("Categoryid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("To_do_list_websit.models.user.Users", "user")
                        .WithMany("tasks")
                        .HasForeignKey("Userid")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Category");

                    b.Navigation("user");
                });

            modelBuilder.Entity("To_do_list_websit.models.categorys.Category", b =>
                {
                    b.Navigation("tasks");
                });

            modelBuilder.Entity("To_do_list_websit.models.user.Users", b =>
                {
                    b.Navigation("tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
