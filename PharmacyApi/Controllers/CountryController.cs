using AutoMapper;
using Models.Entities;
using PharmacyApi.Infrastructure;
using ViewModels.Country;

namespace PharmacyApi.Controllers;

public class CountryController : EntityControllerBase<Country, CountryAddEditViewModel, CountryViewModel, CountryViewModel>
{
    public CountryController(ILogger<CountryViewModel> logger, IMapper mapper) : base(logger, mapper)
    {
    }

    protected override async Task Validation(Country entity)
    {
    }

    public override async Task SoftDelete(Guid id)
    {
        var entity = await MyDatabaseContext.Countries.Include(x => x.Cities).SingleAsync(x => x.Id == id);
        entity.IsDeleted = true;

        foreach (var city in entity.Cities)
            city.IsDeleted = true;

        await MyDatabaseContext.SaveChangesAsync();
    }
}
