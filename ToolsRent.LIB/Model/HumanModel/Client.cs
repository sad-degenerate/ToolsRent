namespace ToolsRent.LIB.Model.HumanModel;

public class Client : IBaseEntity
{
    public int Id { get; set; }
    public Human Human { get; set; }
    public ClientStats ClientStats { get; set; }
}