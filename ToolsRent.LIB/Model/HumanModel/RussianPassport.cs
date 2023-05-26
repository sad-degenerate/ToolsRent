﻿namespace ToolsRent.LIB.Model.HumanModel;

public class RussianPassport : IBasePassport
{
    public int Id { get; set; }
    public string? IdentityNumber { get; set; }
    public string? IssuingDate { get; set; }
    public string? IssuingOrganization { get; set; }
    public string? RegistrationPlace { get; set; }
}