using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VitrineLuxury.DataAccess.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ImageUrls",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ImageUrls", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ImageUrls_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedTime", "Description", "Name" },
                values: new object[] { 1, new DateTime(2021, 8, 28, 19, 29, 30, 480, DateTimeKind.Local).AddTicks(3275), "Project Description Test", "Project Name Test" });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "CreatedTime", "Description", "Name" },
                values: new object[] { 2, new DateTime(2021, 8, 28, 19, 29, 30, 481, DateTimeKind.Local).AddTicks(2950), "Project Description Test 2", "Project Name Test 2" });

            migrationBuilder.InsertData(
                table: "ImageUrls",
                columns: new[] { "Id", "CreatedTime", "ProjectId", "Url" },
                values: new object[] { 1, new DateTime(2021, 8, 28, 19, 29, 30, 482, DateTimeKind.Local).AddTicks(7742), 1, "https://image.freepik.com/free-photo/yellow-sofa-wooden-table-living-room-interior-with-plant_41470-3559.jpg" });

            migrationBuilder.InsertData(
                table: "ImageUrls",
                columns: new[] { "Id", "CreatedTime", "ProjectId", "Url" },
                values: new object[] { 2, new DateTime(2021, 8, 28, 19, 29, 30, 482, DateTimeKind.Local).AddTicks(8523), 1, "https://image.freepik.com/free-photo/yellow-sofa-wooden-table-living-room-interior-with-plant_41470-3559.jpg" });

            migrationBuilder.InsertData(
                table: "ImageUrls",
                columns: new[] { "Id", "CreatedTime", "ProjectId", "Url" },
                values: new object[] { 3, new DateTime(2021, 8, 28, 19, 29, 30, 482, DateTimeKind.Local).AddTicks(8528), 2, "https://image.freepik.com/free-photo/empty-living-room-with-blue-sofa-plants-table-empty-white-wall-background-3d-rendering_41470-1778.jpg" });

            migrationBuilder.CreateIndex(
                name: "IX_ImageUrls_ProjectId",
                table: "ImageUrls",
                column: "ProjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ImageUrls");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Projects");
        }
    }
}
