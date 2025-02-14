﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System;
using TeacherAdmin.Data;

namespace TeacherAdmin.Migrations
{
    [DbContext(typeof(ItalkiDatabaseContext))]
    [Migration("20210916194228_Add Annotations And Course")]
    partial class AddAnnotationsAndCourse
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TeacherAdmin.Models.LessonBlog", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Grammar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NextLessonIdeas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SlidesUsed")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeAndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Vocab")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("StudentID");

                    b.ToTable("LessonBlogs");
                });

            modelBuilder.Entity("TeacherAdmin.Models.Student", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Age")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Course")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Info")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItalkiName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LessonsTaught")
                        .HasColumnType("int");

                    b.Property<string>("Likes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Platform")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StudentName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("TeacherAdmin.Models.LessonBlog", b =>
                {
                    b.HasOne("TeacherAdmin.Models.Student", "Student")
                        .WithMany("Lessons")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
