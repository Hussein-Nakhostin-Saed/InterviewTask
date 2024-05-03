using AutoMapper;
using Models.Entities;
using ViewModels.City;
using ViewModels.Country;

namespace PharmacyApi.Mappers;

public class Mapper : Profile
{
    public Mapper()
    {
        CreateMap<City, CityViewModel>();
        CreateMap<CityAddEditViewModel, City>()
            .ConstructUsing(x => new City(Guid.Empty));

        CreateMap<Country, CountryViewModel>();
        CreateMap<CountryAddEditViewModel, Country>()
            .ConstructUsing(x => new Country(Guid.Empty));
    }
}
