using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmlineTestingSystem.Database.Migrations
{
    /// <inheritdoc />
    public partial class db3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "language",
                table: "tb_employees",
                type: "character varying(2)",
                maxLength: 2,
                nullable: false,
                defaultValue: "ru");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "language",
                table: "tb_employees");

            migrationBuilder.UpdateData(
                table: "tb_users",
                keyColumn: "id",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 11, 19, 15, 48, 4, 55, DateTimeKind.Local).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "tb_users",
                keyColumn: "id",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 11, 19, 15, 48, 4, 55, DateTimeKind.Local).AddTicks(7041));

            migrationBuilder.UpdateData(
                table: "tb_users",
                keyColumn: "id",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 11, 19, 15, 48, 4, 55, DateTimeKind.Local).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "tb_users",
                keyColumn: "id",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 11, 19, 15, 48, 4, 55, DateTimeKind.Local).AddTicks(7110));
        }
    }
}
