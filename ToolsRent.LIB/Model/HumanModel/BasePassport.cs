namespace ToolsRent.LIB.Model.HumanModel;

public abstract class BasePassport : BaseEntity
{
    public abstract string? IdentityNumber { get; set; }
    public abstract string? IssuingDate { get; set; }
    public abstract string? IssuingOrganization { get; set; }
    public abstract string? RegistrationPlace { get; set; }
}