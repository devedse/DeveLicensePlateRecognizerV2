using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DLPR.LicensePlateData.DbMigrations.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "LicensePlates",
                columns: table => new
                {
                    Kenteken = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Voertuigsoort = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Merk = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Handelsbenaming = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VervaldatumAPK = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Datumtenaamstelling = table.Column<DateTime>(type: "datetime2", nullable: true),
                    BrutoBPM = table.Column<int>(type: "int", nullable: true),
                    Inrichting = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aantalzitplaatsen = table.Column<int>(type: "int", nullable: true),
                    Eerstekleur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tweedekleur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Aantalcilinders = table.Column<int>(type: "int", nullable: true),
                    Cilinderinhoud = table.Column<int>(type: "int", nullable: true),
                    Massaledigvoertuig = table.Column<int>(type: "int", nullable: true),
                    Toegestanemaximummassavoertuig = table.Column<int>(type: "int", nullable: true),
                    Massarijklaar = table.Column<int>(type: "int", nullable: true),
                    Maximummassatrekkenongeremd = table.Column<int>(type: "int", nullable: true),
                    Maximumtrekkenmassageremd = table.Column<int>(type: "int", nullable: true),
                    Retrofitroetfilter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Zuinigheidslabel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Datumeerstetoelating = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DatumeersteafgifteNederland = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Wachtopkeuren = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Catalogusprijs = table.Column<int>(type: "int", nullable: true),
                    WAMverzekerd = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Maximaleconstructiesnelheidbromsnorfiets = table.Column<int>(type: "int", nullable: true),
                    Laadvermogen = table.Column<int>(type: "int", nullable: true),
                    Opleggergeremd = table.Column<int>(type: "int", nullable: true),
                    Aanhangwagenautonoomgeremd = table.Column<int>(type: "int", nullable: true),
                    Aanhangwagenmiddenasgeremd = table.Column<int>(type: "int", nullable: true),
                    Vermogenbromsnorfiets = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Aantalstaanplaatsen = table.Column<int>(type: "int", nullable: true),
                    Aantaldeuren = table.Column<int>(type: "int", nullable: true),
                    Aantalwielen = table.Column<int>(type: "int", nullable: true),
                    Afstandhartkoppelingtotachterzijdevoertuig = table.Column<int>(type: "int", nullable: true),
                    Afstandvoorzijdevoertuigtothartkoppeling = table.Column<int>(type: "int", nullable: true),
                    Afwijkendemaximumsnelheid = table.Column<int>(type: "int", nullable: true),
                    Lengte = table.Column<int>(type: "int", nullable: true),
                    Breedte = table.Column<int>(type: "int", nullable: true),
                    Europesevoertuigcategorie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Europesevoertuigcategorietoevoeging = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Europeseuitvoeringcategorietoevoeging = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Plaatschassisnummer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Technischemaxmassavoertuig = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Typegasinstallatie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Typegoedkeuringsnummer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Variant = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Uitvoering = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VolgnummerwijzigingEUtypegoedkeuring = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vermogenmassarijklaar = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Wielbasis = table.Column<int>(type: "int", nullable: true),
                    Exportindicator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Openstaandeterugroepactieindicator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vervaldatumtachograaf = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Taxiindicator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Maximummassasamenstelling = table.Column<int>(type: "int", nullable: true),
                    Aantalrolstoelplaatsen = table.Column<int>(type: "int", nullable: true),
                    Maximumondersteunendesnelheid = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    APIGekentekende_voertuigen_assen = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    APIGekentekende_voertuigen_brandstof = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    APIGekentekende_voertuigen_carrosserie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    APIGekentekende_voertuigen_carrosserie_specifiek = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    APIGekentekende_voertuigen_voertuigklasse = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LicensePlates", x => x.Kenteken);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LicensePlates");
        }
    }
}
