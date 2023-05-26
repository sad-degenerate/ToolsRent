namespace ToolsRent.LIB.Model.ToolModel;

public class Consumables : IBaseEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int PricePerUnit { get; set; }
    public int Count { get; set; }
    public string UnitName { get; set; }
}