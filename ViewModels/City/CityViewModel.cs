using Enums.City;
using Enums.Country;
using ViewModels.Country;
using ViewModels.General;

namespace ViewModels.City;

public class CityViewModel : ViewModelBase
{
    public string Code { get; set; }
    public ActivationStatus Status { get; set; }
    public CityPositionType PositionType { get; set; }
    public CountryViewModel Country { get; set; }
}
