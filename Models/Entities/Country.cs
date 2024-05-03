namespace Models.Entities;

public class Country : BaseEntity
{
    public Country(Guid ownerId) : base(ownerId)
    {
    }

    public string Code { get; set; }
    public ActivationStatus Status { get; set; }
    public IEnumerable<City> Cities { get; set; }
}
