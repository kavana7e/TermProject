using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TermProject.Migrations
{
    public partial class ClassAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DesignerId",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Designers",
                columns: table => new
                {
                    DesignerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designers", x => x.DesignerId);
                });

            migrationBuilder.InsertData(
                table: "Designers",
                columns: new[] { "DesignerId", "Name" },
                values: new object[,]
                {
                    { 1, "Elia Schall" },
                    { 2, "Romy Linder" },
                    { 3, "Hugo Karlen" },
                    { 4, "Elinora Felix" },
                    { 5, "Tessa Abeline" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "DesignerId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "DesignerId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "DesignerId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "DesignerId",
                value: 1);

            migrationBuilder.CreateIndex(
                name: "IX_Products_DesignerId",
                table: "Products",
                column: "DesignerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Designers_DesignerId",
                table: "Products",
                column: "DesignerId",
                principalTable: "Designers",
                principalColumn: "DesignerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Designers_DesignerId",
                table: "Products");

            migrationBuilder.DropTable(
                name: "Designers");

            migrationBuilder.DropIndex(
                name: "IX_Products_DesignerId",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DesignerId",
                table: "Products");
        }
    }
}
