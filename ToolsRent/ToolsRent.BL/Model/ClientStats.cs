namespace ToolsRent.BL.Model;

public class ClientStats : BaseEntity
{
    // ClientId
    public override int Id { get; set; }

    public long AmountOfPurchases { get; set; }
    
    public List<string> Comments { get; set; }
    
    public ClientList ClientList { get; set; }
    
    public bool WithoutDeposit { get; set; }
}