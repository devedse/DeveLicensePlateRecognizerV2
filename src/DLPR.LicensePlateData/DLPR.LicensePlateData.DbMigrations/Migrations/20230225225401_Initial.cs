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
                    Voertuigsoort = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Merk = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Handelsbenaming = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Vervaldatum_APK = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Datum_tenaamstelling = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Bruto_BPM = table.Column<int>(type: "int", nullable: true),
                    Inrichting = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aantal_zitplaatsen = table.Column<int>(type: "int", nullable: true),
                    Eerste_kleur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tweede_kleur = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aantal_cilinders = table.Column<int>(type: "int", nullable: true),
                    Cilinderinhoud = table.Column<int>(type: "int", nullable: true),
                    Massa_ledig_voertuig = table.Column<int>(type: "int", nullable: true),
                    Toegestane_maximum_massa_voertuig = table.Column<int>(type: "int", nullable: true),
                    Massa_rijklaar = table.Column<int>(type: "int", nullable: true),
                    Maximum_massa_trekken_ongeremd = table.Column<int>(type: "int", nullable: true),
                    Maximum_trekken_massa_geremd = table.Column<int>(type: "int", nullable: true),
                    Datum_eerste_toelating = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Datum_eerste_tenaamstelling_in_Nederland = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Wacht_op_keuren = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Catalogusprijs = table.Column<int>(type: "int", nullable: true),
                    WAM_verzekerd = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Maximale_constructiesnelheid = table.Column<int>(type: "int", nullable: true),
                    Laadvermogen = table.Column<int>(type: "int", nullable: true),
                    Oplegger_geremd = table.Column<int>(type: "int", nullable: true),
                    Aanhangwagen_autonoom_geremd = table.Column<int>(type: "int", nullable: true),
                    Aanhangwagen_middenas_geremd = table.Column<int>(type: "int", nullable: true),
                    Aantal_staanplaatsen = table.Column<int>(type: "int", nullable: true),
                    Aantal_deuren = table.Column<int>(type: "int", nullable: true),
                    Aantal_wielen = table.Column<int>(type: "int", nullable: true),
                    Afstand_hart_koppeling_tot_achterzijde_voertuig = table.Column<int>(type: "int", nullable: true),
                    Afstand_voorzijde_voertuig_tot_hart_koppeling = table.Column<int>(type: "int", nullable: true),
                    Afwijkende_maximum_snelheid = table.Column<int>(type: "int", nullable: true),
                    Lengte = table.Column<int>(type: "int", nullable: true),
                    Breedte = table.Column<int>(type: "int", nullable: true),
                    Europese_voertuigcategorie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Europese_voertuigcategorie_toevoeging = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Europese_uitvoeringcategorie_toevoeging = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Plaats_chassisnummer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Technische_max_massa_voertuig = table.Column<int>(type: "int", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type_gasinstallatie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Typegoedkeuringsnummer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Variant = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Uitvoering = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Volgnummer_wijziging_EU_typegoedkeuring = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vermogen_massarijklaar = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Wielbasis = table.Column<int>(type: "int", nullable: true),
                    Export_indicator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Openstaande_terugroepactie_indicator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vervaldatum_tachograaf = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Taxi_indicator = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Maximum_massa_samenstelling = table.Column<int>(type: "int", nullable: true),
                    Aantal_rolstoelplaatsen = table.Column<int>(type: "int", nullable: true),
                    Maximum_ondersteunende_snelheid = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Jaar_laatste_registratie_tellerstand = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tellerstandoordeel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Code_toelichting_tellerstandoordeel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tenaamstellen_mogelijk = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Vervaldatum_APK_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Datum_tenaamstelling_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Datum_eerste_toelating_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Datum_eerste_tenaamstelling_in_Nederland_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Vervaldatum_tachograaf_DT = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Maximum_last_onder_de_voorassen_tezamenkoppeling = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type_remsysteem_voertuig_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rupsonderstelconfiguratiecode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wielbasis_voertuig_minimum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Wielbasis_voertuig_maximum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lengte_voertuig_minimum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Lengte_voertuig_maximum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Breedte_voertuig_minimum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Breedte_voertuig_maximum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hoogte_voertuig = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hoogte_voertuig_minimum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hoogte_voertuig_maximum = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Massa_bedrijfsklaar_minimaal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Massa_bedrijfsklaar_maximaal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Technisch_toelaatbaar_massa_koppelpunt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Maximum_massa_technisch_maximaal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Maximum_massa_technisch_minimaal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Subcategorie_Nederland = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Verticale_belasting_koppelpunt_getrokken_voertuig = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zuinigheidsclassificatie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Registratie_datum_goedkeuring_afschrijvingsmoment_BPM = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Registratie_datum_goedkeuring_afschrijvingsmoment_BPM_DT = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    API_Gekentekende_voertuigen_assen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    API_Gekentekende_voertuigen_brandstof = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    API_Gekentekende_voertuigen_carrosserie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    API_Gekentekende_voertuigen_carrosserie_specifiek = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    API_Gekentekende_voertuigen_voertuigklasse = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LicensePlates", x => x.Kenteken);
                });

            migrationBuilder.CreateIndex(
                name: "IX_LicensePlates_Bruto_BPM",
                table: "LicensePlates",
                column: "Bruto_BPM");

            migrationBuilder.CreateIndex(
                name: "IX_LicensePlates_Catalogusprijs",
                table: "LicensePlates",
                column: "Catalogusprijs");

            migrationBuilder.CreateIndex(
                name: "IX_LicensePlates_Handelsbenaming",
                table: "LicensePlates",
                column: "Handelsbenaming");

            migrationBuilder.CreateIndex(
                name: "IX_LicensePlates_Merk",
                table: "LicensePlates",
                column: "Merk");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LicensePlates");
        }
    }
}
