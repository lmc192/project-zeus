using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectZeus.Migrations
{
    public partial class renameddeitiestogods : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Deities");

            migrationBuilder.CreateTable(
                name: "Gods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MythologyId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gods", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Gods_Mythologies_MythologyId",
                        column: x => x.MythologyId,
                        principalTable: "Mythologies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Gods",
                columns: new[] { "Id", "MythologyId", "Name" },
                values: new object[,]
                {
                    { 1, 2, "Odin" },
                    { 2, 1, "Zeus" },
                    { 3, 2, "Loki" },
                    { 4, 2, "Thor" },
                    { 5, 2, "Freya" },
                    { 6, 1, "Hera" },
                    { 7, 1, "Athena" },
                    { 8, 1, "Achilles" },
                    { 9, 1, "Hercules" },
                    { 10, 1, "Hermes" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gods_MythologyId",
                table: "Gods",
                column: "MythologyId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Gods");

            migrationBuilder.CreateTable(
                name: "Deities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MythologyId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Deities_Mythologies_MythologyId",
                        column: x => x.MythologyId,
                        principalTable: "Mythologies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Deities",
                columns: new[] { "Id", "MythologyId", "Name" },
                values: new object[,]
                {
                    { 1, 2, "Odin" },
                    { 2, 1, "Zeus" },
                    { 3, 2, "Loki" },
                    { 4, 2, "Thor" },
                    { 5, 2, "Freya" },
                    { 6, 1, "Hera" },
                    { 7, 1, "Athena" },
                    { 8, 1, "Achilles" },
                    { 9, 1, "Hercules" },
                    { 10, 1, "Hermes" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Deities_MythologyId",
                table: "Deities",
                column: "MythologyId");
        }
    }
}
