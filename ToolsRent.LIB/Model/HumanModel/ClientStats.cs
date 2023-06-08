using System.Collections.Generic;

namespace ToolsRent.LIB.Model.HumanModel;

public class ClientStats : IBaseEntity
{
    public int Id { get; set; }
    public long AmountOfPurchases { get; set; }
    public string Comments { get; set; }
    public ClientList ClientList { get; set; }
    public bool WithoutDeposit { get; set; }
}