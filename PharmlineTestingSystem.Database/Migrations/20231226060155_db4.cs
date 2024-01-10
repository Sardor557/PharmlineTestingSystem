using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmlineTestingSystem.Database.Migrations
{
    /// <inheritdoc />
    public partial class db4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "tb_employees",
                type: "character varying(255)",
                maxLength: 255,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "language",
                table: "tb_employees",
                type: "character varying(2)",
                maxLength: 2,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(2)",
                oldMaxLength: 2);

            migrationBuilder.UpdateData(
                table: "tb_users",
                keyColumn: "id",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 12, 26, 11, 1, 55, 349, DateTimeKind.Local).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "tb_users",
                keyColumn: "id",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 12, 26, 11, 1, 55, 349, DateTimeKind.Local).AddTicks(4887));

            migrationBuilder.UpdateData(
                table: "tb_users",
                keyColumn: "id",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 12, 26, 11, 1, 55, 349, DateTimeKind.Local).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "tb_users",
                keyColumn: "id",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 12, 26, 11, 1, 55, 349, DateTimeKind.Local).AddTicks(5073));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "tb_employees",
                type: "character varying(255)",
                maxLength: 255,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "character varying(255)",
                oldMaxLength: 255);

            migrationBuilder.AlterColumn<string>(
                name: "language",
                table: "tb_employees",
                type: "character varying(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "character varying(2)",
                oldMaxLength: 2,
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "tb_users",
                keyColumn: "id",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 11, 26, 15, 3, 55, 348, DateTimeKind.Local).AddTicks(8717));

            migrationBuilder.UpdateData(
                table: "tb_users",
                keyColumn: "id",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 11, 26, 15, 3, 55, 348, DateTimeKind.Local).AddTicks(8781));

            migrationBuilder.UpdateData(
                table: "tb_users",
                keyColumn: "id",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 11, 26, 15, 3, 55, 348, DateTimeKind.Local).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "tb_users",
                keyColumn: "id",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 11, 26, 15, 3, 55, 348, DateTimeKind.Local).AddTicks(8863));
        }
    }
}
