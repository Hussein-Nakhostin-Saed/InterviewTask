using Enums.Country;
using ViewModels.General;

namespace ViewModels.Country;

public class CountryAddEditViewModel : AddEditViewModelBase
{
    public string Code { get; set; }
    public ActivationStatus Status { get; set; }
}
