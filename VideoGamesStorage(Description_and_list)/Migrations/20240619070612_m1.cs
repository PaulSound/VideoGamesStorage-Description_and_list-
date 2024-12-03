using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VideoGamesStorage_Description_and_list_.Migrations
{
    /// <inheritdoc />
    public partial class m1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GameList",
                columns: table => new
                {
                    GameId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    game_name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    age_limit = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: false),
                    platform = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    game_genre = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    price = table.Column<decimal>(type: "decimal(6,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true, defaultValue: "NO ENTRIES")
                },
                constraints: table =>
                {
                    table.PrimaryKey("game_id", x => x.GameId);
                    table.CheckConstraint("genreLimits", "game_genre = 'Action' OR game_genre = 'RPG' OR game_genre = 'Shooter' OR game_genre = 'Puzzle' OR game_genre = 'Simulator'");
                    table.CheckConstraint("platformLimits", "platform = 'Nintendo Switch' OR platform = 'Playstation 4' OR platform = 'Playstation 5' OR platform = 'PC' OR platform = 'Xbox One' ");
                    table.CheckConstraint("valueLimits", "age_limit= 'G' OR age_limit= 'PG' OR age_limit= 'PG-13' OR age_limit= 'R' OR age_limit= 'NC-17' ");
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameList");
        }
    }
}
