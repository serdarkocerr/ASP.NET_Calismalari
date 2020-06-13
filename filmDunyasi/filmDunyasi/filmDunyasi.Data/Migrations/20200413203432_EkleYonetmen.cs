using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace filmDunyasi.Data.Migrations
{
    public partial class EkleYonetmen : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Yonetmen",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(nullable: true),
                    Soyad = table.Column<string>(nullable: true),
                    DogumTarihi = table.Column<DateTime>(nullable: false),
                    Cinsiyet = table.Column<int>(nullable: false),
                    UlkeID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yonetmen", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Yonetmen_Ulke_UlkeID",
                        column: x => x.UlkeID,
                        principalTable: "Ulke",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Film",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriID = table.Column<int>(nullable: false),
                    DilID = table.Column<int>(nullable: false),
                    FilmAdi = table.Column<string>(nullable: false),
                    VizyonTarihi = table.Column<DateTime>(nullable: false),
                    Sure = table.Column<int>(nullable: false),
                    IMDBRating = table.Column<double>(nullable: false),
                    Afis = table.Column<string>(nullable: true),
                    Fragman = table.Column<string>(nullable: true),
                    BaslamaTarihi = table.Column<DateTime>(nullable: false),
                    BitisTarihi = table.Column<DateTime>(nullable: false),
                    YonetmenID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Film", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Film_Dil_DilID",
                        column: x => x.DilID,
                        principalTable: "Dil",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Film_Kategoris_KategoriID",
                        column: x => x.KategoriID,
                        principalTable: "Kategoris",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Film_Yonetmen_YonetmenID",
                        column: x => x.YonetmenID,
                        principalTable: "Yonetmen",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Film_DilID",
                table: "Film",
                column: "DilID");

            migrationBuilder.CreateIndex(
                name: "IX_Film_KategoriID",
                table: "Film",
                column: "KategoriID");

            migrationBuilder.CreateIndex(
                name: "IX_Film_YonetmenID",
                table: "Film",
                column: "YonetmenID");

            migrationBuilder.CreateIndex(
                name: "IX_Yonetmen_UlkeID",
                table: "Yonetmen",
                column: "UlkeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Film");

            migrationBuilder.DropTable(
                name: "Yonetmen");
        }
    }
}
