﻿using System.Collections.Generic;
using System.Windows.Controls;
using ToolsRent.LIB.Model;

namespace ToolsRent.LIB.ViewControllers;

public abstract class FillingFieldsController
{
    public abstract Dictionary<string, string> CreateValuesRelationDict(IBaseEntity item);

    private string DeletePrefix(string fieldName)
    {
        if (fieldName.StartsWith("Tbx") || fieldName.StartsWith("Cbx") || fieldName.StartsWith("Lbx"))
        {
            fieldName = fieldName.Remove(0, 3);
        }

        return char.ToLower(fieldName[0]) + fieldName[1..];
    }

    public IEnumerable<KeyValuePair<string, string>> CreateValuesRelationDict(UIElementCollection collection)
    {
        foreach (var item in collection)
        {
            string value;
            string name;

            switch (item)
            {
                case TextBox textBox:
                    name = textBox.Name;
                    value = textBox.Text;
                    break;
                
                case ComboBox comboBox:
                    name = comboBox.Name;
                    value = comboBox.SelectedIndex.ToString();
                    break;
                
                case ListBox listBox:
                    name = listBox.Name;
                    if (listBox.SelectedItem is IBaseEntity entity)
                    {
                        value = entity.Id.ToString();
                    }
                    else
                    {
                        value = string.Empty;
                    }
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
                
                case ComboBox comboBox when int.TryParse(valuesDict[DeletePrefix(comboBox.Name)], out var index):
                    comboBox.SelectedIndex = index;
                    break;
                
                default:
                    continue;
            }
        }
    }
}