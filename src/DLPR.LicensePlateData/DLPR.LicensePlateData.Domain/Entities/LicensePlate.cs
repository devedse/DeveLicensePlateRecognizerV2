using DLPR.LicensePlateData.Domain.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace DLPR.LicensePlateData.Domain.Entities
{
    public class LicensePlate : BaseEntity
    {
        [Key]
        public string Kenteken { get; set; }
        public string? Voertuigsoort { get; set; }
        public string? Merk { get; set; }
        public string? Handelsbenaming { get; set; }
        public string? Vervaldatum_APK { get; set; }
        public DateTime? Datum_tenaamstelling { get; set; }
        public int? Bruto_BPM { get; set; }
        public string? Inrichting { get; set; }
        public int? Aantal_zitplaatsen { get; set; }
        public string? Eerste_kleur { get; set; }
        public string? Tweede_kleur { get; set; }
        public int? Aantal_cilinders { get; set; }
        public int? Cilinderinhoud { get; set; }
        public int? Massa_ledig_voertuig { get; set; }
        public int? Toegestane_maximum_massa_voertuig { get; set; }
        public int? Massa_rijklaar { get; set; }
        public int? Maximum_massa_trekken_ongeremd { get; set; }
        public int? Maximum_trekken_massa_geremd { get; set; }
        public DateTime? Datum_eerste_toelating { get; set; }
        public DateTime? Datum_eerste_tenaamstelling_in_Nederland { get; set; }
        public string? Wacht_op_keuren { get; set; }
        public int? Catalogusprijs { get; set; }
        public string? WAM_verzekerd { get; set; }
        public int? Maximale_constructiesnelheid { get; set; }
        public int? Laadvermogen { get; set; }
        public int? Oplegger_geremd { get; set; }
        public int? Aanhangwagen_autonoom_geremd { get; set; }
        public int? Aanhangwagen_middenas_geremd { get; set; }
        public int? Aantal_staanplaatsen { get; set; }
        public int? Aantal_deuren { get; set; }
        public int? Aantal_wielen { get; set; }
        public int? Afstand_hart_koppeling_tot_achterzijde_voertuig { get; set; }
        public int? Afstand_voorzijde_voertuig_tot_hart_koppeling { get; set; }
        public int? Afwijkende_maximum_snelheid { get; set; }
        public int? Lengte { get; set; }
        public int? Breedte { get; set; }
        public string? Europese_voertuigcategorie { get; set; }
        public string? Europese_voertuigcategorie_toevoeging { get; set; }
        public string? Europese_uitvoeringcategorie_toevoeging { get; set; }
        public string? Plaats_chassisnummer { get; set; }
        public int? Technische_max_massa_voertuig { get; set; }
        public string? Type { get; set; }
        public string? Type_gasinstallatie { get; set; }
        public string? Typegoedkeuringsnummer { get; set; }
        public string? Variant { get; set; }
        public string? Uitvoering { get; set; }
        public string? Volgnummer_wijziging_EU_typegoedkeuring { get; set; }
        public decimal? Vermogen_massarijklaar { get; set; }
        public int? Wielbasis { get; set; }
        public string? Export_indicator { get; set; }
        public string? Openstaande_terugroepactie_indicator { get; set; }
        public DateTime? Vervaldatum_tachograaf { get; set; }
        public string? Taxi_indicator { get; set; }
        public int? Maximum_massa_samenstelling { get; set; }
        public int? Aantal_rolstoelplaatsen { get; set; }
        public decimal? Maximum_ondersteunende_snelheid { get; set; }
        public string? Jaar_laatste_registratie_tellerstand { get; set; }
        public string? Tellerstandoordeel { get; set; }
        public string? Code_toelichting_tellerstandoordeel { get; set; }
        public string? Tenaamstellen_mogelijk { get; set; }
        public DateTime? Vervaldatum_APK_DT { get; set; }
        public DateTime? Datum_tenaamstelling_DT { get; set; }
        public DateTime? Datum_eerste_toelating_DT { get; set; }
        public DateTime? Datum_eerste_tenaamstelling_in_Nederland_DT { get; set; }
        public DateTime? Vervaldatum_tachograaf_DT { get; set; }
        public string? Maximum_last_onder_de_voorassen_tezamenkoppeling { get; set; }
        public string? Type_remsysteem_voertuig_code { get; set; }
        public string? Rupsonderstelconfiguratiecode { get; set; }
        public string? Wielbasis_voertuig_minimum { get; set; }
        public string? Wielbasis_voertuig_maximum { get; set; }
        public string? Lengte_voertuig_minimum { get; set; }
        public string? Lengte_voertuig_maximum { get; set; }
        public string? Breedte_voertuig_minimum { get; set; }
        public string? Breedte_voertuig_maximum { get; set; }
        public string? Hoogte_voertuig { get; set; }
        public string? Hoogte_voertuig_minimum { get; set; }
        public string? Hoogte_voertuig_maximum { get; set; }
        public string? Massa_bedrijfsklaar_minimaal { get; set; }
        public string? Massa_bedrijfsklaar_maximaal { get; set; }
        public string? Technisch_toelaatbaar_massa_koppelpunt { get; set; }
        public string? Maximum_massa_technisch_maximaal { get; set; }
        public string? Maximum_massa_technisch_minimaal { get; set; }
        public string? Subcategorie_Nederland { get; set; }
        public string? Verticale_belasting_koppelpunt_getrokken_voertuig { get; set; }
        public string? Zuinigheidsclassificatie { get; set; }
        public string? Registratie_datum_goedkeuring_afschrijvingsmoment_BPM { get; set; }
        public string? Registratie_datum_goedkeuring_afschrijvingsmoment_BPM_DT { get; set; }
        public string? API_Gekentekende_voertuigen_assen { get; set; }
        public string? API_Gekentekende_voertuigen_brandstof { get; set; }
        public string? API_Gekentekende_voertuigen_carrosserie { get; set; }
        public string? API_Gekentekende_voertuigen_carrosserie_specifiek { get; set; }
        public string? API_Gekentekende_voertuigen_voertuigklasse { get; set; }
    }
}
