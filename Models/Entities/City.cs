namespace Models.Entities;

public class City : BaseEntity
{
    public City(Guid ownerId) : base(ownerId)
    {
    }

    public string Code { get; set; }
    public ActivationStatus Status { get; set; }
    public CityPositionType PositionType { get; set; }
    public Guid CountryId { get; set; }
    public Country Country { get; set; }
}
