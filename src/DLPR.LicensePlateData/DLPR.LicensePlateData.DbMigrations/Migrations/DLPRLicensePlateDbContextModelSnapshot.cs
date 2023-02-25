﻿// <auto-generated />
using System;
using DLPR.LicensePlateData.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DLPR.LicensePlateData.DbMigrations.Migrations
{
    [DbContext(typeof(DLPRLicensePlateDbContext))]
    partial class DLPRLicensePlateDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DLPR.LicensePlateData.Domain.Entities.LicensePlate", b =>
                {
                    b.Property<string>("Kenteken")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("APIGekentekende_voertuigen_assen")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("APIGekentekende_voertuigen_brandstof")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("APIGekentekende_voertuigen_carrosserie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("APIGekentekende_voertuigen_carrosserie_specifiek")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("APIGekentekende_voertuigen_voertuigklasse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Aanhangwagenautonoomgeremd")
                        .HasColumnType("int");

                    b.Property<int?>("Aanhangwagenmiddenasgeremd")
                        .HasColumnType("int");

                    b.Property<int?>("Aantalcilinders")
                        .HasColumnType("int");

                    b.Property<int?>("Aantaldeuren")
                        .HasColumnType("int");

                    b.Property<int?>("Aantalrolstoelplaatsen")
                        .HasColumnType("int");

                    b.Property<int?>("Aantalstaanplaatsen")
                        .HasColumnType("int");

                    b.Property<int?>("Aantalwielen")
                        .HasColumnType("int");

                    b.Property<int?>("Aantalzitplaatsen")
                        .HasColumnType("int");

                    b.Property<int?>("Afstandhartkoppelingtotachterzijdevoertuig")
                        .HasColumnType("int");

                    b.Property<int?>("Afstandvoorzijdevoertuigtothartkoppeling")
                        .HasColumnType("int");

                    b.Property<int?>("Afwijkendemaximumsnelheid")
                        .HasColumnType("int");

                    b.Property<int?>("Breedte")
                        .HasColumnType("int");

                    b.Property<int?>("BrutoBPM")
                        .HasColumnType("int");

                    b.Property<int?>("Catalogusprijs")
                        .HasColumnType("int");

                    b.Property<int?>("Cilinderinhoud")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DatumeersteafgifteNederland")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Datumeerstetoelating")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("Datumtenaamstelling")
                        .HasColumnType("datetime2");

                    b.Property<string>("Eerstekleur")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Europeseuitvoeringcategorietoevoeging")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Europesevoertuigcategorie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Europesevoertuigcategorietoevoeging")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Exportindicator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Handelsbenaming")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Inrichting")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Laadvermogen")
                        .HasColumnType("int");

                    b.Property<int?>("Lengte")
                        .HasColumnType("int");

                    b.Property<int?>("Massaledigvoertuig")
                        .HasColumnType("int");

                    b.Property<int?>("Massarijklaar")
                        .HasColumnType("int");

                    b.Property<int?>("Maximaleconstructiesnelheidbromsnorfiets")
                        .HasColumnType("int");

                    b.Property<int?>("Maximummassasamenstelling")
                        .HasColumnType("int");

                    b.Property<int?>("Maximummassatrekkenongeremd")
                        .HasColumnType("int");

                    b.Property<decimal?>("Maximumondersteunendesnelheid")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("Maximumtrekkenmassageremd")
                        .HasColumnType("int");

                    b.Property<string>("Merk")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Openstaandeterugroepactieindicator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Opleggergeremd")
                        .HasColumnType("int");

                    b.Property<string>("Plaatschassisnummer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Retrofitroetfilter")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Taxiindicator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Technischemaxmassavoertuig")
                        .HasColumnType("int");

                    b.Property<int?>("Toegestanemaximummassavoertuig")
                        .HasColumnType("int");

                    b.Property<string>("Tweedekleur")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Typegasinstallatie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Typegoedkeuringsnummer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Uitvoering")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Variant")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Vermogenbromsnorfiets")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Vermogenmassarijklaar")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("VervaldatumAPK")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Vervaldatumtachograaf")
                        .HasColumnType("datetime2");

                    b.Property<string>("Voertuigsoort")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VolgnummerwijzigingEUtypegoedkeuring")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WAMverzekerd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Wachtopkeuren")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("Wielbasis")
                        .HasColumnType("int");

                    b.Property<string>("Zuinigheidslabel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Kenteken");

                    b.ToTable("LicensePlates");
                });
#pragma warning restore 612, 618
        }
    }
}
