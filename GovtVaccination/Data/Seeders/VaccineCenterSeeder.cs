using Bogus;
using GovtVaccination.Models;

namespace GovtVaccination.Data.Seeders;

public static class VaccineCenterSeeder
{
    public static void Seed(AppDbContext context)
    {
        if (!context.VaccineCenters.Any())
        {
            var faker = new Faker<VaccineCenters>("en_US") 
                .RuleFor(vc => vc.Name, f => $"{f.Company.CompanyName()} Vaccination Center")
                .RuleFor(vc => vc.Address, f => $"{f.Address.StreetAddress()}, {f.Address.City()}, {f.Address.State()}, Bangladesh")
                .RuleFor(vc => vc.DailyLimit, f => f.Random.Int(100, 1000))
                .RuleFor(vc => vc.Status, f => f.PickRandom(new[] { 0, 1 }))
                .RuleFor(vc => vc.CreatedAt, f => f.Date.Past(1))
                .RuleFor(vc => vc.UpdatedAt, (f, vc) => vc.CreatedAt.AddDays(f.Random.Int(1, 100)));
    
            var fakeCenters = faker.Generate(50); // Generate 50 centers
    
            context.VaccineCenters.AddRange(fakeCenters);
            context.SaveChanges();
        }
    }
}
