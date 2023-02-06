namespace ToolsRent.BL.Model;

public class OrganizationThatRents : BaseEntity
{
    public override int Id { get; set; }
    
    public string Name { get; set; }
    
    public string StateRegistration { get; set; }
}