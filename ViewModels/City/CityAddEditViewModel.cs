using Enums.City;
using Enums.Country;
using ViewModels.General;

namespace ViewModels.City;

public class CityAddEditViewModel : AddEditViewModelBase
{
    public string Code { get; set; }
    public ActivationStatus Status { get; set; }
    public CityPositionType PositionType { get; set; }
    public Guid CountryId { get; set; }
}
