using CsvHelper.Configuration.Attributes;

namespace DLPR.LicensePlateData.Uploader.Csv
{
    public class LicensePlateCsv
    {
        [Index(0)]
        public string Kenteken { get; set; }
        [Index(1)]
        public string Voertuigsoort { get; set; }
        [Index(2)]
        public string Merk { get; set; }
        [Index(3)]
        public string Handelsbenaming { get; set; }
        [Index(4)]
        public string Vervaldatum_APK { get; set; }
        [Index(5)]
        public string Datum_tenaamstelling { get; set; }
        [Index(6)]
        public string Bruto_BPM { get; set; }
        [Index(7)]
        public string Inrichting { get; set; }
        [Index(8)]
        public string Aantal_zitplaatsen { get; set; }
        [Index(9)]
        public string Eerste_kleur { get; set; }
        [Index(10)]
        public string Tweede_kleur { get; set; }
        [Index(11)]
        public string Aantal_cilinders { get; set; }
        [Index(12)]
        public string Cilinderinhoud { get; set; }
        [Index(13)]
        public string Massa_ledig_voertuig { get; set; }
        [Index(14)]
        public string Toegestane_maximum_massa_voertuig { get; set; }
        [Index(15)]
        public string Massa_rijklaar { get; set; }
        [Index(16)]
        public string Maximum_massa_trekken_ongeremd { get; set; }
        [Index(17)]
        public string Maximum_trekken_massa_geremd { get; set; }
        [Index(18)]
        public string Datum_eerste_toelating { get; set; }
        [Index(19)]
        public string Datum_eerste_tenaamstelling_in_Nederland { get; set; }
        [Index(20)]
        public string Wacht_op_keuren { get; set; }
        [Index(21)]
        public string Catalogusprijs { get; set; }
        [Index(22)]
        public string WAM_verzekerd { get; set; }
        [Index(23)]
        public string Maximale_constructiesnelheid { get; set; }
        [Index(24)]
        public string Laadvermogen { get; set; }
        [Index(25)]
        public string Oplegger_geremd { get; set; }
        [Index(26)]
        public string Aanhangwagen_autonoom_geremd { get; set; }
        [Index(27)]
        public string Aanhangwagen_middenas_geremd { get; set; }
        [Index(28)]
        public string Aantal_staanplaatsen { get; set; }
        [Index(29)]
        public string Aantal_deuren { get; set; }
        [Index(30)]
        public string Aantal_wielen { get; set; }
        [Index(31)]
        public string Afstand_hart_koppeling_tot_achterzijde_voertuig { get; set; }
        [Index(32)]
        public string Afstand_voorzijde_voertuig_tot_hart_koppeling { get; set; }
        [Index(33)]
        public string Afwijkende_maximum_snelheid { get; set; }
        [Index(34)]
        public string Lengte { get; set; }
        [Index(35)]
        public string Breedte { get; set; }
        [Index(36)]
        public string Europese_voertuigcategorie { get; set; }
        [Index(37)]
        public string Europese_voertuigcategorie_toevoeging { get; set; }
        [Index(38)]
        public string Europese_uitvoeringcategorie_toevoeging { get; set; }
        [Index(39)]
        public string Plaats_chassisnummer { get; set; }
        [Index(40)]
        public string Technische_max_massa_voertuig { get; set; }
        [Index(41)]
        public string Type { get; set; }
        [Index(42)]
        public string Type_gasinstallatie { get; set; }
        [Index(43)]
        public string Typegoedkeuringsnummer { get; set; }
        [Index(44)]
        public string Variant { get; set; }
        [Index(45)]
        public string Uitvoering { get; set; }
        [Index(46)]
        public string Volgnummer_wijziging_EU_typegoedkeuring { get; set; }
        [Index(47)]
        public string Vermogen_massarijklaar { get; set; }
        [Index(48)]
        public string Wielbasis { get; set; }
        [Index(49)]
        public string Export_indicator { get; set; }
        [Index(50)]
        public string Openstaande_terugroepactie_indicator { get; set; }
        [Index(51)]
        public string Vervaldatum_tachograaf { get; set; }
        [Index(52)]
        public string Taxi_indicator { get; set; }
        [Index(53)]
        public string Maximum_massa_samenstelling { get; set; }
        [Index(54)]
        public string Aantal_rolstoelplaatsen { get; set; }
        [Index(55)]
        public string Maximum_ondersteunende_snelheid { get; set; }
        [Index(56)]
        public string Jaar_laatste_registratie_tellerstand { get; set; }
        [Index(57)]
        public string Tellerstandoordeel { get; set; }
        [Index(58)]
        public string Code_toelichting_tellerstandoordeel { get; set; }
        [Index(59)]
        public string Tenaamstellen_mogelijk { get; set; }
        [Index(60)]
        public string Vervaldatum_APK_DT { get; set; }
        [Index(61)]
        public string Datum_tenaamstelling_DT { get; set; }
        [Index(62)]
        public string Datum_eerste_toelating_DT { get; set; }
        [Index(63)]
        public string Datum_eerste_tenaamstelling_in_Nederland_DT { get; set; }
        [Index(64)]
        public string Vervaldatum_tachograaf_DT { get; set; }
        [Index(65)]
        public string Maximum_last_onder_de_voorassen_tezamenkoppeling { get; set; }
        [Index(66)]
        public string Type_remsysteem_voertuig_code { get; set; }
        [Index(67)]
        public string Rupsonderstelconfiguratiecode { get; set; }
        [Index(68)]
        public string Wielbasis_voertuig_minimum { get; set; }
        [Index(69)]
        public string Wielbasis_voertuig_maximum { get; set; }
        [Index(70)]
        public string Lengte_voertuig_minimum { get; set; }
        [Index(71)]
        public string Lengte_voertuig_maximum { get; set; }
        [Index(72)]
        public string Breedte_voertuig_minimum { get; set; }
        [Index(73)]
        public string Breedte_voertuig_maximum { get; set; }
        [Index(74)]
        public string Hoogte_voertuig { get; set; }
        [Index(75)]
        public string Hoogte_voertuig_minimum { get; set; }
        [Index(76)]
        public string Hoogte_voertuig_maximum { get; set; }
        [Index(77)]
        public string Massa_bedrijfsklaar_minimaal { get; set; }
        [Index(78)]
        public string Massa_bedrijfsklaar_maximaal { get; set; }
        [Index(79)]
        public string Technisch_toelaatbaar_massa_koppelpunt { get; set; }
        [Index(80)]
        public string Maximum_massa_technisch_maximaal { get; set; }
        [Index(81)]
        public string Maximum_massa_technisch_minimaal { get; set; }
        [Index(82)]
        public string Subcategorie_Nederland { get; set; }
        [Index(83)]
        public string Verticale_belasting_koppelpunt_getrokken_voertuig { get; set; }
        [Index(84)]
        public string Zuinigheidsclassificatie { get; set; }
        [Index(85)]
        public string Registratie_datum_goedkeuring_afschrijvingsmoment_BPM { get; set; }
        [Index(86)]
        public string Registratie_datum_goedkeuring_afschrijvingsmoment_BPM_DT { get; set; }
        [Index(87)]
        public string API_Gekentekende_voertuigen_assen { get; set; }
        [Index(88)]
        public string API_Gekentekende_voertuigen_brandstof { get; set; }
        [Index(89)]
        public string API_Gekentekende_voertuigen_carrosserie { get; set; }
        [Index(90)]
        public string API_Gekentekende_voertuigen_carrosserie_specifiek { get; set; }
        [Index(91)]
        public string API_Gekentekende_voertuigen_voertuigklasse { get; set; }
    }
}
