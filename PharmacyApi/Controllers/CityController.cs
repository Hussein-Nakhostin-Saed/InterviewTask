using Enums.Country;
using Models.Entities;
using PharmacyApi.Infrastructure;
using ViewModels.City;

namespace PharmacyApi.Controllers;

public class CityController : EntityControllerBase<City, CityAddEditViewModel, CityViewModel, CityController>
{
    public CityController(ILogger<CityController> logger, IMapper mapper) : base(logger, mapper)
    {
    }

    protected override async Task Validation(City entity)
    {
        //به جای پیاده سازی و استفاده از این متد میتوان از انوتِیشِن ها روی مدل افزودن و ویرایش استفاده نمود.
        if (entity.Code.Length > 4)
            ModelState.AddModelError("LengthOutOfRange", "City code is out of range");

        var country = await MyDatabaseContext.Countries.SingleAsync(x => x.Id == entity.CountryId);
        if (country.Status == ActivationStatus.Deactive)
            ModelState.AddModelError("DeactiveCountry", "Inactive country can not has any city");
    }

    protected override string[] IncludableProperties => new string[] { "Country" };
}
