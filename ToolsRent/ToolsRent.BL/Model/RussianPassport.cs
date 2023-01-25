namespace ToolsRent.BL.Model;

public class RussianPassport : BasePassport
{
    public override string? IdentityNumber { get; set; }
    
    public override string? IssuingDate { get; set; }
    
    public override string? IssuingOrganization { get; set; }
    
    public override string? RegistrationPlace { get; set; }
}