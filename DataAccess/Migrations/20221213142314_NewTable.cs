using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace DataAccess.Migrations
{
    public partial class NewTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "image",
                table: "destinations");

            migrationBuilder.CreateTable(
                name: "destination_images",
                columns: table => new
                {
                    destination_images_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    destination_id = table.Column<int>(type: "integer", nullable: false),
                    path_name = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_destination_images", x => x.destination_images_id);
                    table.ForeignKey(
                        name: "FK_destination_images_destinations_destination_id",
                        column: x => x.destination_id,
                        principalTable: "destinations",
                        principalColumn: "destination_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "other_details",
                columns: table => new
                {
                    other_details_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    destination_id = table.Column<int>(type: "integer", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: true),
                    description = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_other_details", x => x.other_details_id);
                    table.ForeignKey(
                        name: "FK_other_details_destinations_destination_id",
                        column: x => x.destination_id,
                        principalTable: "destinations",
                        principalColumn: "destination_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_destination_images_destination_id",
                table: "destination_images",
                column: "destination_id");

            migrationBuilder.CreateIndex(
                name: "IX_other_details_destination_id",
                table: "other_details",
                column: "destination_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "destination_images");

            migrationBuilder.DropTable(
                name: "other_details");

            migrationBuilder.AddColumn<string>(
                name: "image",
                table: "destinations",
                type: "text",
                nullable: true);
        }
    }
}
