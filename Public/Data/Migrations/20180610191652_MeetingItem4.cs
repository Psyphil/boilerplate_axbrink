using Microsoft.EntityFrameworkCore.Migrations;

namespace Public.Data.Migrations
{
    public partial class MeetingItem4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_MeetingsItems_MeetingID",
                table: "MeetingsItems",
                column: "MeetingID");

            migrationBuilder.AddForeignKey(
                name: "FK_MeetingsItems_Meetings_MeetingID",
                table: "MeetingsItems",
                column: "MeetingID",
                principalTable: "Meetings",
                principalColumn: "MeetingID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MeetingsItems_Meetings_MeetingID",
                table: "MeetingsItems");

            migrationBuilder.DropIndex(
                name: "IX_MeetingsItems_MeetingID",
                table: "MeetingsItems");
        }
    }
}
