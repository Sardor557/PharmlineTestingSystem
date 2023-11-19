using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PharmlineTestingSystem.Database.Migrations
{
    /// <inheritdoc />
    public partial class db2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "title",
                table: "tb_questions",
                newName: "context");

            migrationBuilder.AddColumn<string>(
                name: "variant",
                table: "tb_options",
                type: "character varying(2)",
                maxLength: 2,
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "variant",
                table: "tb_options");

            migrationBuilder.RenameColumn(
                name: "context",
                table: "tb_questions",
                newName: "title");

            migrationBuilder.UpdateData(
                table: "tb_users",
                keyColumn: "id",
                keyValue: 1,
                column: "create_date",
                value: new DateTime(2023, 11, 19, 14, 14, 48, 581, DateTimeKind.Local).AddTicks(8077));

            migrationBuilder.UpdateData(
                table: "tb_users",
                keyColumn: "id",
                keyValue: 2,
                column: "create_date",
                value: new DateTime(2023, 11, 19, 14, 14, 48, 581, DateTimeKind.Local).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "tb_users",
                keyColumn: "id",
                keyValue: 3,
                column: "create_date",
                value: new DateTime(2023, 11, 19, 14, 14, 48, 581, DateTimeKind.Local).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "tb_users",
                keyColumn: "id",
                keyValue: 4,
                column: "create_date",
                value: new DateTime(2023, 11, 19, 14, 14, 48, 581, DateTimeKind.Local).AddTicks(8240));
        }
    }
}
