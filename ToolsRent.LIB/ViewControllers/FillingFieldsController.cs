using System.Collections.Generic;
using System.Windows.Controls;
using ToolsRent.LIB.Model;

namespace ToolsRent.LIB.ViewControllers;

public abstract class FillingFieldsController
{
    public abstract Dictionary<string, string> CreateValuesRelationDict(IBaseEntity item);

    private string DeletePrefix(string fieldName)
    {
        if (fieldName.StartsWith("Tbx") || fieldName.StartsWith("Rbn") || fieldName.StartsWith("Cbx"))
        {
            fieldName = fieldName.Remove(0, 3);
        }

        return char.ToLower(fieldName[0]) + fieldName[1..];
    }

    public IEnumerable<KeyValuePair<string, string>> CreateValuesRelationDict(UIElementCollection collection)
    {
        foreach (var item in collection)
        {
            var value = string.Empty;
            var name = string.Empty;

            switch (item)
            {
                case TextBox textBox:
                    name = textBox.Name;
                    value = textBox.Text;
                    break;
                
                case RadioButton radioButton:
                    if (radioButton.IsChecked == false)
                    {
                        continue;
                    }
                    name = radioButton.GroupName;
                    value = radioButton.Tag.ToString();
                    break;
                
                case CheckBox checkBox:
                    name = checkBox.Name;
                    value = checkBox.IsChecked.ToString();
                    break;

                default:
                    continue;
            }

            yield return new KeyValuePair<string, string>(DeletePrefix(name), value);
        }
    }

    public void FillFields(ref UIElementCollection collection, Dictionary<string, string> valuesDict)
    {
        foreach (var element in collection)
        {
            switch (element)
            {
                case TextBox textBox:
                    if (valuesDict.ContainsKey(DeletePrefix(textBox.Name)) == false)
                    {
                        continue;
                    }
                    textBox.Text = valuesDict[DeletePrefix(textBox.Name)];
                    break;
                
                case RadioButton radioButton:
                    if (valuesDict.ContainsKey(DeletePrefix(radioButton.GroupName)) == false)
                    {
                        continue;
                    }
                    if (valuesDict[DeletePrefix(radioButton.GroupName)] == (string)radioButton.Tag)
                    {
                        radioButton.IsChecked = true;
                    }
                    break;
                
                case CheckBox checkBox:
                    if (valuesDict.ContainsKey(DeletePrefix(checkBox.Name)) == false)
                    {
                        continue;
                    }

                    checkBox.IsChecked = valuesDict[DeletePrefix(checkBox.Name)] == "True";
                    break;

                default:
                    continue;
            }
        }
    }
}