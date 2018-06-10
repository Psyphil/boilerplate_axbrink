using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Public.Data.Migrations
{
    public partial class MeetingItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Meetings");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Meetings");

            migrationBuilder.RenameColumn(
                name: "Title",
                table: "Meetings",
                newName: "MeetingTitle");

            migrationBuilder.RenameColumn(
                name: "ReleaseDate",
                table: "Meetings",
                newName: "MeetingDate");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Meetings",
                newName: "MeetingID");

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Meetings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Meetings",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "MeetingDuration",
                table: "Meetings",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OrganisationID",
                table: "Meetings",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Meetings");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Meetings");

            migrationBuilder.DropColumn(
                name: "MeetingDuration",
                table: "Meetings");

            migrationBuilder.DropColumn(
                name: "OrganisationID",
                table: "Meetings");

            migrationBuilder.RenameColumn(
                name: "MeetingTitle",
                table: "Meetings",
                newName: "Title");

            migrationBuilder.RenameColumn(
                name: "MeetingDate",
                table: "Meetings",
                newName: "ReleaseDate");

            migrationBuilder.RenameColumn(
                name: "MeetingID",
                table: "Meetings",
                newName: "ID");

            migrationBuilder.AddColumn<string>(
                name: "Genre",
                table: "Meetings",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Meetings",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
