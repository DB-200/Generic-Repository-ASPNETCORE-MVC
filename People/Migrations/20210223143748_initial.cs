using Microsoft.EntityFrameworkCore.Migrations;

namespace People.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "People",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Firstname = table.Column<string>(nullable: true),
                    Lastname = table.Column<string>(nullable: true),
                    ContactNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_People", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "ContactNo", "Firstname", "Lastname" },
                values: new object[,]
                {
                    { 1, "98888232736", "Fred", "Smith" },
                    { 2, "43888232736", "Sam", "Tomato" },
                    { 3, "436688232736", "Laura", "Pizza" },
                    { 4, "938888232736", "Bob", "Bob-bob" },
                    { 5, "12148888232736", "Emily", "Jones" },
                    { 6, "76888232736", "Walter", "Cabbage" },
                    { 7, "32888232736", "Lisa", "Bean" },
                    { 8, "4888232736", "Simon", "Steak" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "People");
        }
    }
}
