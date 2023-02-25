using DLPR.LicensePlateData.Domain.Entities;
using DLPR.LicensePlateData.Uploader.Csv;
using System.Globalization;

namespace DLPR.LicensePlateData.Uploader
{
    public static class LicensePlateMapper
    {
        private static decimal? ToDecimal(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return null;
            }
            if (decimal.TryParse(input, out var result))
            {
                return result;
            }
            return null;
        }

        private static int? ToInt(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return null;
            }
            if (input.Contains(".") || input.Contains(","))
            {
                throw new InvalidDataException($"Trying to parse {input} as int but is actually a decimal. Pls fix");
            }
            if (int.TryParse(input, out var result))
            {
                return result;
            }
            return null;
        }

        private static DateTime? ToDateTime(string input)
        {
            if (input == null || input.Length != 8)
            {
                return null;
            }

            var year = int.Parse(input.Substring(0, 4));
            var month = int.Parse(input.Substring(4, 2));
            var day = int.Parse(input.Substring(6, 2));

            return new DateTime(year, month, day);
        }

        private static DateTime? ParseDateTime(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return null;
            }
            var retval = DateTime.ParseExact(input, "MM/dd/yyyy hh:mm:ss tt", CultureInfo.InvariantCulture);
            return retval;
        }

        public static LicensePlate Map(LicensePlateCsv input)
        {
            return new LicensePlate()
            {
                Kenteken = input.Kenteken,
                Voertuigsoort = input.Voertuigsoort,
                Merk = input.Merk,
                Handelsbenaming = input.Handelsbenaming,
                Vervaldatum_APK = input.Vervaldatum_APK,
                Datum_tenaamstelling = ToDateTime(input.Datum_tenaamstelling),
                Bruto_BPM = ToInt(input.Bruto_BPM),
                Inrichting = input.Inrichting,
                Aantal_zitplaatsen = ToInt(input.Aantal_zitplaatsen),
                Eerste_kleur = input.Eerste_kleur,
                Tweede_kleur = input.Tweede_kleur,
                Aantal_cilinders = ToInt(input.Aantal_cilinders),
                Cilinderinhoud = ToInt(input.Cilinderinhoud),
                Massa_ledig_voertuig = ToInt(input.Massa_ledig_voertuig),
                Toegestane_maximum_massa_voertuig = ToInt(input.Toegestane_maximum_massa_voertuig),
                Massa_rijklaar = ToInt(input.Massa_rijklaar),
                Maximum_massa_trekken_ongeremd = ToInt(input.Maximum_massa_trekken_ongeremd),
                Maximum_trekken_massa_geremd = ToInt(input.Maximum_trekken_massa_geremd),
                Datum_eerste_toelating = ToDateTime(input.Datum_eerste_toelating),
                Datum_eerste_tenaamstelling_in_Nederland = ToDateTime(input.Datum_eerste_tenaamstelling_in_Nederland),
                Wacht_op_keuren = input.Wacht_op_keuren,
                Catalogusprijs = ToInt(input.Catalogusprijs),
                WAM_verzekerd = input.WAM_verzekerd,
                Maximale_constructiesnelheid = ToInt(input.Maximale_constructiesnelheid),
                Laadvermogen = ToInt(input.Laadvermogen),
                Oplegger_geremd = ToInt(input.Oplegger_geremd),
                Aanhangwagen_autonoom_geremd = ToInt(input.Aanhangwagen_autonoom_geremd),
                Aanhangwagen_middenas_geremd = ToInt(input.Aanhangwagen_middenas_geremd),
                Aantal_staanplaatsen = ToInt(input.Aantal_staanplaatsen),
                Aantal_deuren = ToInt(input.Aantal_deuren),
                Aantal_wielen = ToInt(input.Aantal_wielen),
                Afstand_hart_koppeling_tot_achterzijde_voertuig = ToInt(input.Afstand_hart_koppeling_tot_achterzijde_voertuig),
                Afstand_voorzijde_voertuig_tot_hart_koppeling = ToInt(input.Afstand_voorzijde_voertuig_tot_hart_koppeling),
                Afwijkende_maximum_snelheid = ToInt(input.Afwijkende_maximum_snelheid),
                Lengte = ToInt(input.Lengte),
                Breedte = ToInt(input.Breedte),
                Europese_voertuigcategorie = input.Europese_voertuigcategorie,
                Europese_voertuigcategorie_toevoeging = input.Europese_voertuigcategorie_toevoeging,
                Europese_uitvoeringcategorie_toevoeging = input.Europese_uitvoeringcategorie_toevoeging,
                Plaats_chassisnummer = input.Plaats_chassisnummer,
                Technische_max_massa_voertuig = ToInt(input.Technische_max_massa_voertuig),
                Type = input.Type,
                Type_gasinstallatie = input.Type_gasinstallatie,
                Typegoedkeuringsnummer = input.Typegoedkeuringsnummer,
                Variant = input.Variant,
                Uitvoering = input.Uitvoering,
                Volgnummer_wijziging_EU_typegoedkeuring = input.Volgnummer_wijziging_EU_typegoedkeuring,
                Vermogen_massarijklaar = ToDecimal(input.Vermogen_massarijklaar),
                Wielbasis = ToInt(input.Wielbasis),
                Export_indicator = input.Export_indicator,
                Openstaande_terugroepactie_indicator = input.Openstaande_terugroepactie_indicator,
                Vervaldatum_tachograaf = ToDateTime(input.Vervaldatum_tachograaf),
                Taxi_indicator = input.Taxi_indicator,
                Maximum_massa_samenstelling = ToInt(input.Maximum_massa_samenstelling),
                Aantal_rolstoelplaatsen = ToInt(input.Aantal_rolstoelplaatsen),
                Maximum_ondersteunende_snelheid = ToDecimal(input.Maximum_ondersteunende_snelheid),
                Jaar_laatste_registratie_tellerstand = input.Jaar_laatste_registratie_tellerstand,
                Tellerstandoordeel = input.Tellerstandoordeel,
                Code_toelichting_tellerstandoordeel = input.Code_toelichting_tellerstandoordeel,
                Tenaamstellen_mogelijk = input.Tenaamstellen_mogelijk,
                Vervaldatum_APK_DT = ParseDateTime(input.Vervaldatum_APK_DT),
                Datum_tenaamstelling_DT = ParseDateTime(input.Datum_tenaamstelling_DT),
                Datum_eerste_toelating_DT = ParseDateTime(input.Datum_eerste_toelating_DT),
                Datum_eerste_tenaamstelling_in_Nederland_DT = ParseDateTime(input.Datum_eerste_tenaamstelling_in_Nederland_DT),
                Vervaldatum_tachograaf_DT = ParseDateTime(input.Vervaldatum_tachograaf_DT),
                Maximum_last_onder_de_voorassen_tezamenkoppeling = input.Maximum_last_onder_de_voorassen_tezamenkoppeling,
                Type_remsysteem_voertuig_code = input.Type_remsysteem_voertuig_code,
                Rupsonderstelconfiguratiecode = input.Rupsonderstelconfiguratiecode,
                Wielbasis_voertuig_minimum = input.Wielbasis_voertuig_minimum,
                Wielbasis_voertuig_maximum = input.Wielbasis_voertuig_maximum,
                Lengte_voertuig_minimum = input.Lengte_voertuig_minimum,
                Lengte_voertuig_maximum = input.Lengte_voertuig_maximum,
                Breedte_voertuig_minimum = input.Breedte_voertuig_minimum,
                Breedte_voertuig_maximum = input.Breedte_voertuig_maximum,
                Hoogte_voertuig = input.Hoogte_voertuig,
                Hoogte_voertuig_minimum = input.Hoogte_voertuig_minimum,
                Hoogte_voertuig_maximum = input.Hoogte_voertuig_maximum,
                Massa_bedrijfsklaar_minimaal = input.Massa_bedrijfsklaar_minimaal,
                Massa_bedrijfsklaar_maximaal = input.Massa_bedrijfsklaar_maximaal,
                Technisch_toelaatbaar_massa_koppelpunt = input.Technisch_toelaatbaar_massa_koppelpunt,
                Maximum_massa_technisch_maximaal = input.Maximum_massa_technisch_maximaal,
                Maximum_massa_technisch_minimaal = input.Maximum_massa_technisch_minimaal,
                Subcategorie_Nederland = input.Subcategorie_Nederland,
                Verticale_belasting_koppelpunt_getrokken_voertuig = input.Verticale_belasting_koppelpunt_getrokken_voertuig,
                Zuinigheidsclassificatie = input.Zuinigheidsclassificatie,
                Registratie_datum_goedkeuring_afschrijvingsmoment_BPM = input.Registratie_datum_goedkeuring_afschrijvingsmoment_BPM,
                Registratie_datum_goedkeuring_afschrijvingsmoment_BPM_DT = input.Registratie_datum_goedkeuring_afschrijvingsmoment_BPM_DT,
                API_Gekentekende_voertuigen_assen = input.API_Gekentekende_voertuigen_assen,
                API_Gekentekende_voertuigen_brandstof = input.API_Gekentekende_voertuigen_brandstof,
                API_Gekentekende_voertuigen_carrosserie = input.API_Gekentekende_voertuigen_carrosserie,
                API_Gekentekende_voertuigen_carrosserie_specifiek = input.API_Gekentekende_voertuigen_carrosserie_specifiek,
                API_Gekentekende_voertuigen_voertuigklasse = input.API_Gekentekende_voertuigen_voertuigklasse,
            };
        }
    }
}
