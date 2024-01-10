﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PharmlineTestingSystem.Database;

#nullable disable

namespace PharmlineTestingSystem.Database.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20231226060155_db4")]
    partial class db4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("PharmlineTestingSystem.Models.spDrug", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("create_date");

                    b.Property<int>("CreateUser")
                        .HasColumnType("integer")
                        .HasColumnName("create_user");

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("name");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("update_date");

                    b.Property<int?>("UpdateUser")
                        .HasColumnType("integer")
                        .HasColumnName("update_user");

                    b.HasKey("Id")
                        .HasName("pk_sp_drugs");

                    b.ToTable("sp_drugs", (string)null);
                });

            modelBuilder.Entity("PharmlineTestingSystem.Models.spStatus", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("pk_sp_statuses");

                    b.ToTable("sp_statuses", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Активный"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Архив"
                        });
                });

            modelBuilder.Entity("PharmlineTestingSystem.Models.tbAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("create_date");

                    b.Property<int>("CreateUser")
                        .HasColumnType("integer")
                        .HasColumnName("create_user");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("integer")
                        .HasColumnName("employee_id");

                    b.Property<int>("OptionId")
                        .HasColumnType("integer")
                        .HasColumnName("option_id");

                    b.Property<int>("QuestionId")
                        .HasColumnType("integer")
                        .HasColumnName("question_id");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("update_date");

                    b.Property<int?>("UpdateUser")
                        .HasColumnType("integer")
                        .HasColumnName("update_user");

                    b.HasKey("Id")
                        .HasName("pk_tb_answers");

                    b.HasIndex("EmployeeId")
                        .HasDatabaseName("ix_tb_answers_employee_id");

                    b.HasIndex("OptionId")
                        .HasDatabaseName("ix_tb_answers_option_id");

                    b.HasIndex("QuestionId")
                        .HasDatabaseName("ix_tb_answers_question_id");

                    b.ToTable("tb_answers", (string)null);
                });

            modelBuilder.Entity("PharmlineTestingSystem.Models.tbEmployee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("create_date");

                    b.Property<int>("CreateUser")
                        .HasColumnType("integer")
                        .HasColumnName("create_user");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)")
                        .HasColumnName("full_name");

                    b.Property<string>("Language")
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)")
                        .HasColumnName("language");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("password");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("phone");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<long?>("TelegramId")
                        .HasColumnType("bigint")
                        .HasColumnName("telegram_id");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("update_date");

                    b.Property<int?>("UpdateUser")
                        .HasColumnType("integer")
                        .HasColumnName("update_user");

                    b.HasKey("Id")
                        .HasName("pk_tb_employees");

                    b.HasIndex("FullName")
                        .HasDatabaseName("ix_tb_employees_full_name");

                    b.HasIndex("Phone")
                        .IsUnique()
                        .HasDatabaseName("ix_tb_employees_phone");

                    b.ToTable("tb_employees", (string)null);
                });

            modelBuilder.Entity("PharmlineTestingSystem.Models.tbOption", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Answer")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("answer");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("create_date");

                    b.Property<int>("CreateUser")
                        .HasColumnType("integer")
                        .HasColumnName("create_user");

                    b.Property<bool>("IsCorrect")
                        .HasColumnType("boolean")
                        .HasColumnName("is_correct");

                    b.Property<int>("QuestionId")
                        .HasColumnType("integer")
                        .HasColumnName("question_id");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("update_date");

                    b.Property<int?>("UpdateUser")
                        .HasColumnType("integer")
                        .HasColumnName("update_user");

                    b.Property<string>("Variant")
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)")
                        .HasColumnName("variant");

                    b.HasKey("Id")
                        .HasName("pk_tb_options");

                    b.HasIndex("QuestionId")
                        .HasDatabaseName("ix_tb_options_question_id");

                    b.ToTable("tb_options", (string)null);
                });

            modelBuilder.Entity("PharmlineTestingSystem.Models.tbQuestion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Context")
                        .HasMaxLength(2000)
                        .HasColumnType("character varying(2000)")
                        .HasColumnName("context");

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("create_date");

                    b.Property<int>("CreateUser")
                        .HasColumnType("integer")
                        .HasColumnName("create_user");

                    b.Property<int>("DrugId")
                        .HasColumnType("integer")
                        .HasColumnName("drug_id");

                    b.Property<bool>("IsOpen")
                        .HasColumnType("boolean")
                        .HasColumnName("is_open");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("update_date");

                    b.Property<int?>("UpdateUser")
                        .HasColumnType("integer")
                        .HasColumnName("update_user");

                    b.HasKey("Id")
                        .HasName("pk_tb_questions");

                    b.HasIndex("DrugId")
                        .HasDatabaseName("ix_tb_questions_drug_id");

                    b.ToTable("tb_questions", (string)null);
                });

            modelBuilder.Entity("PharmlineTestingSystem.Models.tbUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("CreateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("create_date");

                    b.Property<int>("CreateUser")
                        .HasColumnType("integer")
                        .HasColumnName("create_user");

                    b.Property<string>("FIO")
                        .HasMaxLength(300)
                        .HasColumnType("character varying(300)")
                        .HasColumnName("fio");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("character varying(20)")
                        .HasColumnName("login");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)")
                        .HasColumnName("password");

                    b.Property<int>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("update_date");

                    b.Property<int?>("UpdateUser")
                        .HasColumnType("integer")
                        .HasColumnName("update_user");

                    b.HasKey("Id")
                        .HasName("pk_tb_users");

                    b.HasIndex("Login")
                        .IsUnique()
                        .HasDatabaseName("ix_tb_users_login");

                    b.ToTable("tb_users", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreateDate = new DateTime(2023, 12, 26, 11, 1, 55, 349, DateTimeKind.Local).AddTicks(4773),
                            CreateUser = 1,
                            FIO = "Admin",
                            Login = "admin",
                            Password = "bf6e55cd42d6d5dedfafcdd05ba5d8b8",
                            Status = 1
                        },
                        new
                        {
                            Id = 2,
                            CreateDate = new DateTime(2023, 12, 26, 11, 1, 55, 349, DateTimeKind.Local).AddTicks(4887),
                            CreateUser = 1,
                            FIO = "Gavxar",
                            Login = "director",
                            Password = "bf6e55cd42d6d5dedfafcdd05ba5d8b8",
                            Status = 1
                        },
                        new
                        {
                            Id = 3,
                            CreateDate = new DateTime(2023, 12, 26, 11, 1, 55, 349, DateTimeKind.Local).AddTicks(4945),
                            CreateUser = 1,
                            FIO = "Jenya",
                            Login = "manager",
                            Password = "fcea920f7412b5da7be0cf42b8c93759",
                            Status = 1
                        },
                        new
                        {
                            Id = 4,
                            CreateDate = new DateTime(2023, 12, 26, 11, 1, 55, 349, DateTimeKind.Local).AddTicks(5073),
                            CreateUser = 1,
                            FIO = "Sklad",
                            Login = "sklad",
                            Password = "f0898af949a373e72a4f6a34b4de9090",
                            Status = 1
                        });
                });

            modelBuilder.Entity("PharmlineTestingSystem.Models.tbAnswer", b =>
                {
                    b.HasOne("PharmlineTestingSystem.Models.tbEmployee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("fk_tb_answers_tb_employees_employee_id");

                    b.HasOne("PharmlineTestingSystem.Models.tbOption", "Option")
                        .WithMany()
                        .HasForeignKey("OptionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("fk_tb_answers_tb_options_option_id");

                    b.HasOne("PharmlineTestingSystem.Models.tbQuestion", "Question")
                        .WithMany()
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("fk_tb_answers_tb_questions_question_id");

                    b.Navigation("Employee");

                    b.Navigation("Option");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("PharmlineTestingSystem.Models.tbOption", b =>
                {
                    b.HasOne("PharmlineTestingSystem.Models.tbQuestion", "Question")
                        .WithMany("Options")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("fk_tb_options_tb_questions_question_id");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("PharmlineTestingSystem.Models.tbQuestion", b =>
                {
                    b.HasOne("PharmlineTestingSystem.Models.spDrug", "Drug")
                        .WithMany()
                        .HasForeignKey("DrugId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("fk_tb_questions_sp_drugs_drug_id");

                    b.Navigation("Drug");
                });

            modelBuilder.Entity("PharmlineTestingSystem.Models.tbQuestion", b =>
                {
                    b.Navigation("Options");
                });
#pragma warning restore 612, 618
        }
    }
}
