using DLPR.LicensePlateData.Domain.Core.Models;
using System.ComponentModel.DataAnnotations;

namespace DLPR.LicensePlateData.Domain.Entities
{
    public class LicensePlate : BaseEntity
    {
        [Key]
        public string Kenteken { get; set; }
        public string Voertuigsoort { get; set; }
        public string Merk { get; set; }
        public string Handelsbenaming { get; set; }
        public string VervaldatumAPK { get; set; }
        public DateTime? Datumtenaamstelling { get; set; }
        public int? BrutoBPM { get; set; }
        public string Inrichting { get; set; }
        public int? Aantalzitplaatsen { get; set; }
        public string Eerstekleur { get; set; }
        public string Tweedekleur { get; set; }
        public int? Aantalcilinders { get; set; }
        public int? Cilinderinhoud { get; set; }
        public int? Massaledigvoertuig { get; set; }
        public int? Toegestanemaximummassavoertuig { get; set; }
        public int? Massarijklaar { get; set; }
        public int? Maximummassatrekkenongeremd { get; set; }
        public int? Maximumtrekkenmassageremd { get; set; }
        public string Retrofitroetfilter { get; set; }
        public string Zuinigheidslabel { get; set; }
        public DateTime? Datumeerstetoelating { get; set; }
        public DateTime? DatumeersteafgifteNederland { get; set; }
        public string Wachtopkeuren { get; set; }
        public int? Catalogusprijs { get; set; }
        public string WAMverzekerd { get; set; }
        public int? Maximaleconstructiesnelheidbromsnorfiets { get; set; }
        public int? Laadvermogen { get; set; }
        public int? Opleggergeremd { get; set; }
        public int? Aanhangwagenautonoomgeremd { get; set; }
        public int? Aanhangwagenmiddenasgeremd { get; set; }
        public decimal? Vermogenbromsnorfiets { get; set; }
        public int? Aantalstaanplaatsen { get; set; }
        public int? Aantaldeuren { get; set; }
        public int? Aantalwielen { get; set; }
        public int? Afstandhartkoppelingtotachterzijdevoertuig { get; set; }
        public int? Afstandvoorzijdevoertuigtothartkoppeling { get; set; }
        public int? Afwijkendemaximumsnelheid { get; set; }
        public int? Lengte { get; set; }
        public int? Breedte { get; set; }
        public string Europesevoertuigcategorie { get; set; }
        public string Europesevoertuigcategorietoevoeging { get; set; }
        public string Europeseuitvoeringcategorietoevoeging { get; set; }
        public string Plaatschassisnummer { get; set; }
        public int? Technischemaxmassavoertuig { get; set; }
        public string Type { get; set; }
        public string Typegasinstallatie { get; set; }
        public string Typegoedkeuringsnummer { get; set; }
        public string Variant { get; set; }
        public string Uitvoering { get; set; }
        public string VolgnummerwijzigingEUtypegoedkeuring { get; set; }
        public decimal? Vermogenmassarijklaar { get; set; }
        public int? Wielbasis { get; set; }
        public string Exportindicator { get; set; }
        public string Openstaandeterugroepactieindicator { get; set; }
        public DateTime? Vervaldatumtachograaf { get; set; }
        public string Taxiindicator { get; set; }
        public int? Maximummassasamenstelling { get; set; }
        public int? Aantalrolstoelplaatsen { get; set; }
        public decimal? Maximumondersteunendesnelheid { get; set; }
        public string APIGekentekende_voertuigen_assen { get; set; }
        public string APIGekentekende_voertuigen_brandstof { get; set; }
        public string APIGekentekende_voertuigen_carrosserie { get; set; }
        public string APIGekentekende_voertuigen_carrosserie_specifiek { get; set; }
        public string APIGekentekende_voertuigen_voertuigklasse { get; set; }
    }
}
