﻿// <auto-generated />
using System;
using DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(SchoolDbContext))]
    partial class SchoolDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("DataAccess.Models.AdditionalFile", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ArticleId")
                        .HasColumnType("int");

                    b.Property<string>("Heading")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("ArticleId");

                    b.ToTable("AdditionalFiles");
                });

            modelBuilder.Entity("DataAccess.Models.Article", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Content")
                        .HasColumnType("text");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime");

                    b.Property<string>("FilePath")
                        .HasColumnType("text");

                    b.Property<int?>("NormType")
                        .HasColumnType("int");

                    b.Property<string>("PostedById")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("Subtitle")
                        .HasColumnType("text");

                    b.Property<int?>("Target")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("TypeId")
                        .HasColumnType("varchar(767)");

                    b.HasKey("Id");

                    b.HasIndex("PostedById");

                    b.HasIndex("TypeId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("DataAccess.Models.ArticleType", b =>
                {
                    b.Property<string>("Name")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("Heading")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Name");

                    b.ToTable("Types");

                    b.HasData(
                        new
                        {
                            Name = "News",
                            Heading = "съобщение"
                        },
                        new
                        {
                            Name = "SchoolPlan",
                            Heading = "училищен план"
                        },
                        new
                        {
                            Name = "Course",
                            Heading = "курс"
                        },
                        new
                        {
                            Name = "AfterSeventhGrade",
                            Heading = "новина относно приема след 7. клас"
                        },
                        new
                        {
                            Name = "AfterFourthGrade",
                            Heading = "новина относно приема след 4. клас"
                        });
                });

            modelBuilder.Entity("DataAccess.Models.Class", b =>
                {
                    b.Property<string>("Year")
                        .HasColumnType("varchar(767)");

                    b.Property<int>("Letter")
                        .HasColumnType("int");

                    b.Property<string>("HomeroomTeacherId")
                        .HasColumnType("varchar(767)");

                    b.HasKey("Year", "Letter");

                    b.HasIndex("HomeroomTeacherId");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("DataAccess.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("JobDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MiddleName")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("DataAccess.Models.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsInSchoolBoard")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MiddleName")
                        .HasColumnType("text");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("Members");
                });

            modelBuilder.Entity("DataAccess.Models.Photo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ClassLetter")
                        .HasColumnType("int");

                    b.Property<string>("ClassYear")
                        .HasColumnType("varchar(767)");

                    b.HasKey("Id");

                    b.HasIndex("ClassYear", "ClassLetter");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("DataAccess.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("DataAccess.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("FamilyName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Letter")
                        .HasColumnType("int");

                    b.Property<string>("Year")
                        .HasColumnType("varchar(767)");

                    b.HasKey("Id");

                    b.HasIndex("Year", "Letter");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("DataAccess.Models.Subject", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("ColorHex")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("DataAccess.Models.Teacher", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("AdditionalRole")
                        .HasColumnType("text");

                    b.Property<string>("Biography")
                        .HasColumnType("text");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("datetime");

                    b.Property<string>("Email")
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("IsHeadTeacher")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MiddleName")
                        .HasColumnType("text");

                    b.Property<string>("SubjectId")
                        .HasColumnType("varchar(767)");

                    b.HasKey("Username");

                    b.HasIndex("SubjectId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("DataAccess.Models.User", b =>
                {
                    b.Property<string>("Username")
                        .HasColumnType("varchar(767)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Username");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Username = "Admin",
                            Password = "RandomPassword"
                        });
                });

            modelBuilder.Entity("DataAccess.Models.AdditionalFile", b =>
                {
                    b.HasOne("DataAccess.Models.Article", "Article")
                        .WithMany("AdditionalFiles")
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Article");
                });

            modelBuilder.Entity("DataAccess.Models.Article", b =>
                {
                    b.HasOne("DataAccess.Models.User", "PostedBy")
                        .WithMany("Articles")
                        .HasForeignKey("PostedById");

                    b.HasOne("DataAccess.Models.ArticleType", "Type")
                        .WithMany("Articles")
                        .HasForeignKey("TypeId");

                    b.Navigation("PostedBy");

                    b.Navigation("Type");
                });

            modelBuilder.Entity("DataAccess.Models.Class", b =>
                {
                    b.HasOne("DataAccess.Models.Teacher", "HomeroomTeacher")
                        .WithMany("HomeroomClasses")
                        .HasForeignKey("HomeroomTeacherId");

                    b.Navigation("HomeroomTeacher");
                });

            modelBuilder.Entity("DataAccess.Models.Member", b =>
                {
                    b.HasOne("DataAccess.Models.Role", "Role")
                        .WithMany("Members")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("DataAccess.Models.Photo", b =>
                {
                    b.HasOne("DataAccess.Models.Class", "Class")
                        .WithMany("Photos")
                        .HasForeignKey("ClassYear", "ClassLetter");

                    b.Navigation("Class");
                });

            modelBuilder.Entity("DataAccess.Models.Student", b =>
                {
                    b.HasOne("DataAccess.Models.Class", "Class")
                        .WithMany("Students")
                        .HasForeignKey("Year", "Letter");

                    b.Navigation("Class");
                });

            modelBuilder.Entity("DataAccess.Models.Teacher", b =>
                {
                    b.HasOne("DataAccess.Models.Subject", "Subject")
                        .WithMany("Teachers")
                        .HasForeignKey("SubjectId");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("DataAccess.Models.Article", b =>
                {
                    b.Navigation("AdditionalFiles");
                });

            modelBuilder.Entity("DataAccess.Models.ArticleType", b =>
                {
                    b.Navigation("Articles");
                });

            modelBuilder.Entity("DataAccess.Models.Class", b =>
                {
                    b.Navigation("Photos");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("DataAccess.Models.Role", b =>
                {
                    b.Navigation("Members");
                });

            modelBuilder.Entity("DataAccess.Models.Subject", b =>
                {
                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("DataAccess.Models.Teacher", b =>
                {
                    b.Navigation("HomeroomClasses");
                });

            modelBuilder.Entity("DataAccess.Models.User", b =>
                {
                    b.Navigation("Articles");
                });
#pragma warning restore 612, 618
        }
    }
}
