using System;
using System.Collections.Generic;
using System.Windows.Controls;
using ToolsRent.LIB.Model.HumanModel;

namespace ToolsRent.LIB.Controllers;

public class AddEditClientController : AddEditEntityController
{
    private Client? _client;

    public AddEditClientController(Client? client)
    {
        
    }
    
    public override string AddEditEntity(UIElementCollection collection, Dictionary<string, string> valuesRelDict)
    {
        var valuesDict = new Dictionary<string, string>(valuesRelDict);

        throw new NotImplementedException();
    }
}