using System.Collections.Generic;

namespace ToolsRent.LIB.Model.ToolModel;

public class Tool : IBaseEntity
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Count { get; set; }
    public int Deposit { get; set; }
    public int Price { get; set; }
    public List<Consumables> Consumables { get; set; }
}