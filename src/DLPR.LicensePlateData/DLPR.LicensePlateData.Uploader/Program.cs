using CsvHelper;
using DLPR.LicensePlateData.Domain.Entities;
using DLPR.LicensePlateData.Infrastructure.Data;
using DLPR.LicensePlateData.Uploader.Csv;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Diagnostics;
using System.Globalization;

namespace DLPR.LicensePlateData.Uploader
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = Host.CreateApplicationBuilder(args);

            Infrastructure.DependencyResolver.DependencyResolverService.Register(builder.Services, builder.Configuration);

            var host = builder.Build();


            using (var scope = host.Services.CreateScope())
            {
                using (var dbContext = scope.ServiceProvider.GetService<DLPRLicensePlateDbContext>())
                {
                    var curPlates = dbContext.LicensePlates.ToList();



                    using (var reader = new CsvReader(new StreamReader(@"D:\Open_Data_RDW__Gekentekende_voertuigen.csv"), CultureInfo.InvariantCulture))
                    {
                        var records = reader.GetRecords<LicensePlateCsv>();
                        int countTotal = 0;
                        int count = 0;

                        var licensePlatesToAdd = new List<LicensePlate>();
                        foreach (var licensePlateCsv in records)
                        {
                            Console.WriteLine(countTotal);

                            count++;
                            countTotal++;

                            licensePlatesToAdd.Add(LicensePlateMapper.Map(licensePlateCsv));

                            if (count % 1000 == 0)
                            {
                                var foundLastItem = dbContext.LicensePlates.Find(licensePlatesToAdd.Last().Kenteken);

                                if (foundLastItem == null)
                                {
                                    var w = Stopwatch.StartNew();
                                    dbContext.BulkInsert(licensePlatesToAdd);
                                    Console.WriteLine($"Elapsed: {w.Elapsed}");
                                }

                                licensePlatesToAdd.Clear(); licensePlatesToAdd.Clear();
                                count = 0;
                            }
                        }
                        dbContext.BulkInsert(licensePlatesToAdd);
                        //dbContext.SaveChanges();
                        dbContext.BulkSaveChanges();
                    }

                }
            }

            Console.WriteLine("Done :)");
            Console.ReadLine();


        }
    }
}