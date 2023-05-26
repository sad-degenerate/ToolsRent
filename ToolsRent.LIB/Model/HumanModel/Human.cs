namespace ToolsRent.LIB.Model.HumanModel;

public class Human : IBaseEntity
{
    public int Id { get; set; }
    public string? Surname { get; set; }
    public string? Name { get; set; }
    public string? Patronymic { get; set; }
    public IBasePassport? Passport { get; set; }
    public string? PhoneNumber { get; set; }
}