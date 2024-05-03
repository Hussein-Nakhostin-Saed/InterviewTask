using Enums.Country;
using ViewModels.General;

namespace ViewModels.Country;

public class CountryViewModel : ViewModelBase
{
    public ActivationStatus Status { get; set; }
    public string Code { get; set; }
}
