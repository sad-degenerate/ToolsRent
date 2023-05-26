namespace ToolsRent.LIB.Model.ToolModel;

public class Tool : BaseEntity
{
    public override int Id { get; set; }
    public string Name { get; set; }
    public int Count { get; set; }
    public int Deposit { get; set; }
    public int Price { get; set; }
    public List<Consumables> Consumables { get; set; }
}