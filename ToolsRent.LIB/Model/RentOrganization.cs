namespace ToolsRent.LIB.Model;

public class RentOrganization : BaseEntity
{
    public override int Id { get; set; }
    public string Name { get; set; }
    public string RegistrationState { get; set; }
}