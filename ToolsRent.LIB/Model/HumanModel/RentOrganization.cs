namespace ToolsRent.LIB.Model.HumanModel;

public class RentOrganization : IBaseEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string RegistrationState { get; set; }
}