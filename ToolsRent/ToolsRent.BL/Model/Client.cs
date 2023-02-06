namespace ToolsRent.BL.Model;

public class Client : BaseEntity
{
    public override int Id { get; set; }
    
    public Human Human { get; set; }
    
    public ClientStats ClientStats { get; set; }
}