using System.Collections.Generic;
using ToolsRent.LIB.Model;
using ToolsRent.LIB.Model.HumanModel;

namespace ToolsRent.LIB.ViewControllers;

public class FillingClientFieldsController : FillingFieldsController
{
    public override Dictionary<string, string> CreateValuesRelationDict(IBaseEntity item)
    {
        if (item is not Client client)
        {
            return new Dictionary<string, string>();
        }

        return new Dictionary<string, string>()
        {
            { "surname", client.Human.Surname },
            { "name", client.Human.Name },
            { "patronymic", client.Human.Patronymic },
            { "phone", client.Human.PhoneNumber },
            { "passportNumber", client.Human.Passport.IdentityNumber },
            { "passportIssuingDate", client.Human.Passport.IssuingDate },
            { "passportIssuingOrganization", client.Human.Passport.IssuingOrganization },
            { "registration", client.Human.Passport.RegistrationPlace },
            { "amountOfPurchases", client.ClientStats.AmountOfPurchases.ToString() },
            { "comments", client.ClientStats.Comments },
            { "status", ((int)client.ClientStats.ClientList).ToString() },
            { "deposit", client.ClientStats.WithoutDeposit.ToString() },
        };
    }
}