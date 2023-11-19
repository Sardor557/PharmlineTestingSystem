using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PharmlineTestingSystem.Database.Migrations
{
    /// <inheritdoc />
    public partial class db1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "sp_drugs",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true),
                    status = table.Column<int>(type: "integer", nullable: false),
                    create_user = table.Column<int>(type: "integer", nullable: false),
                    create_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    update_user = table.Column<int>(type: "integer", nullable: true),
                    update_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_drugs", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "sp_statuses",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_sp_statuses", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_employees",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    full_name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    phone = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    telegram_id = table.Column<long>(type: "bigint", nullable: true),
                    password = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    status = table.Column<int>(type: "integer", nullable: false),
                    create_user = table.Column<int>(type: "integer", nullable: false),
                    create_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    update_user = table.Column<int>(type: "integer", nullable: true),
                    update_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_employees", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_users",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    login = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    password = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    fio = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: true),
                    status = table.Column<int>(type: "integer", nullable: false),
                    create_user = table.Column<int>(type: "integer", nullable: false),
                    create_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    update_user = table.Column<int>(type: "integer", nullable: true),
                    update_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_users", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "tb_questions",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    title = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: true),
                    drug_id = table.Column<int>(type: "integer", nullable: false),
                    is_open = table.Column<bool>(type: "boolean", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    create_user = table.Column<int>(type: "integer", nullable: false),
                    create_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    update_user = table.Column<int>(type: "integer", nullable: true),
                    update_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_questions", x => x.id);
                    table.ForeignKey(
                        name: "fk_tb_questions_sp_drugs_drug_id",
                        column: x => x.drug_id,
                        principalTable: "sp_drugs",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_options",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    answer = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    question_id = table.Column<int>(type: "integer", nullable: false),
                    is_correct = table.Column<bool>(type: "boolean", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    create_user = table.Column<int>(type: "integer", nullable: false),
                    create_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    update_user = table.Column<int>(type: "integer", nullable: true),
                    update_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_options", x => x.id);
                    table.ForeignKey(
                        name: "fk_tb_options_tb_questions_question_id",
                        column: x => x.question_id,
                        principalTable: "tb_questions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "tb_answers",
                columns: table => new
                {
                    id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    question_id = table.Column<int>(type: "integer", nullable: false),
                    employee_id = table.Column<int>(type: "integer", nullable: false),
                    option_id = table.Column<int>(type: "integer", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: false),
                    create_user = table.Column<int>(type: "integer", nullable: false),
                    create_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    update_user = table.Column<int>(type: "integer", nullable: true),
                    update_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_tb_answers", x => x.id);
                    table.ForeignKey(
                        name: "fk_tb_answers_tb_employees_employee_id",
                        column: x => x.employee_id,
                        principalTable: "tb_employees",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_tb_answers_tb_options_option_id",
                        column: x => x.option_id,
                        principalTable: "tb_options",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_tb_answers_tb_questions_question_id",
                        column: x => x.question_id,
                        principalTable: "tb_questions",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "sp_statuses",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "Активный" },
                    { 2, "Архив" }
                });

            migrationBuilder.InsertData(
                table: "tb_users",
                columns: new[] { "id", "create_date", "create_user", "fio", "login", "password", "status", "update_date", "update_user" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 11, 19, 14, 14, 48, 581, DateTimeKind.Local).AddTicks(8077), 1, "Admin", "admin", "bf6e55cd42d6d5dedfafcdd05ba5d8b8", 1, null, null },
                    { 2, new DateTime(2023, 11, 19, 14, 14, 48, 581, DateTimeKind.Local).AddTicks(8129), 1, "Gavxar", "director", "bf6e55cd42d6d5dedfafcdd05ba5d8b8", 1, null, null },
                    { 3, new DateTime(2023, 11, 19, 14, 14, 48, 581, DateTimeKind.Local).AddTicks(8202), 1, "Jenya", "manager", "fcea920f7412b5da7be0cf42b8c93759", 1, null, null },
                    { 4, new DateTime(2023, 11, 19, 14, 14, 48, 581, DateTimeKind.Local).AddTicks(8240), 1, "Sklad", "sklad", "f0898af949a373e72a4f6a34b4de9090", 1, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "ix_tb_answers_employee_id",
                table: "tb_answers",
                column: "employee_id");

            migrationBuilder.CreateIndex(
                name: "ix_tb_answers_option_id",
                table: "tb_answers",
                column: "option_id");

            migrationBuilder.CreateIndex(
                name: "ix_tb_answers_question_id",
                table: "tb_answers",
                column: "question_id");

            migrationBuilder.CreateIndex(
                name: "ix_tb_employees_full_name",
                table: "tb_employees",
                column: "full_name");

            migrationBuilder.CreateIndex(
                name: "ix_tb_employees_phone",
                table: "tb_employees",
                column: "phone",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "ix_tb_options_question_id",
                table: "tb_options",
                column: "question_id");

            migrationBuilder.CreateIndex(
                name: "ix_tb_questions_drug_id",
                table: "tb_questions",
                column: "drug_id");

            migrationBuilder.CreateIndex(
                name: "ix_tb_users_login",
                table: "tb_users",
                column: "login",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "sp_statuses");

            migrationBuilder.DropTable(
                name: "tb_answers");

            migrationBuilder.DropTable(
                name: "tb_users");

            migrationBuilder.DropTable(
                name: "tb_employees");

            migrationBuilder.DropTable(
                name: "tb_options");

            migrationBuilder.DropTable(
                name: "tb_questions");

            migrationBuilder.DropTable(
                name: "sp_drugs");
        }
    }
}
