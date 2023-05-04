namespace ToolsRent.LIB.Model;

public class RussianPassport : BasePassport
{
    public override int Id { get; set; }
    public override string? IdentityNumber { get; set; }
    public override string? IssuingDate { get; set; }
    public override string? IssuingOrganization { get; set; }
    public override string? RegistrationPlace { get; set; }
}