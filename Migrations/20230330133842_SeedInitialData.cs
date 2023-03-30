using Microsoft.Build.ObjectModelRemoting;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineResume.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
            name: "ProjectModel",
            columns: table => new
            {
                Id = table.Column<Guid>(nullable: false),
                Name = table.Column<string>(maxLength: 50, nullable: false),
                Description = table.Column<string>(maxLength: 50, nullable: false),
                Author = table.Column<string>(maxLength: 50, nullable: false),
                ProjectLink = table.Column<string>(maxLength:50, nullable: false),
                CreatedDate = table.Column<DateTime>(nullable: false)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_ProjectModel", x => x.Id);
            });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
            name: "ProjectModel");
        }
    }
}
