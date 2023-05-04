namespace ToolsRent.LIB.Model;

public class Human : BaseEntity
{
    public override int Id { get; set; }
    public string? Surname { get; set; }
    public string? Name { get; set; }
    public string? Patronymic { get; set; }
    public BasePassport? Passport { get; set; }
    public string? PhoneNumber { get; set; }
}