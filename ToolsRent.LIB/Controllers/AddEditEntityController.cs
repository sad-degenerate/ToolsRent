using System.Collections.Generic;
using System.Windows.Controls;
using ToolsRent.LIB.DataBase;
using ToolsRent.LIB.Model;

namespace ToolsRent.LIB.Controllers;

public abstract class AddEditEntityController
{
    public abstract string AddEditEntity(UIElementCollection collection, Dictionary<string, string> valuesRelDict);

    protected virtual void SaveItemInDb<T>(T item) where T: class, IBaseEntity
    {
        if (item.Id == 0)
        {
            DbCommands<T>.Add(item);
        }    
        else
        {
            DbCommands<T>.Modify(item);
        }
    }
}