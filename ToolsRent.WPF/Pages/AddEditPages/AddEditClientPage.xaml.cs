using System.Windows.Controls;
using ToolsRent.LIB.Controllers;
using ToolsRent.LIB.Model.HumanModel;
using ToolsRent.LIB.ViewControllers;

namespace ToolsRent.WPF.Pages.AddEditPages;

public partial class AddEditClientPage : Page
{
    private readonly AddEditClientController _addEditController;
    private readonly FillingClientFieldsController _fillingFieldsController;
    
    public AddEditClientPage(Client? client = null)
    {
        InitializeComponent();

        var passport = new RussianPassport
        {
            Id = 1,
            IdentityNumber = "5434 567832",
            IssuingDate = "27.03.2022",
            IssuingOrganization = "ГУ МВД РОССИИ ПО НОВОСИБИРСКОЙ ОБЛАСТИ",
            RegistrationPlace = "г. Новосибирск ул. Большая д. 336А"
        };

        var human = new Human
        {
            Id = 1,
            Name = "Максим",
            Surname = "Бабаков",
            Patronymic = "Максимович",
            Passport = passport,
            PhoneNumber = "8 903 932 83 56"
        };

        var clientStats = new ClientStats
        {
            AmountOfPurchases = 1_000,
            ClientList = ClientList.Red,
            Comments = "Хороший покупатель!",
            Id = 1,
            WithoutDeposit = true
        };

        client = new Client()
        {
            Id = 1,
            Human = human,
            ClientStats = clientStats,
        };
        
        _addEditController = new AddEditClientController(client);
        _fillingFieldsController = new FillingClientFieldsController();

        if (client == null)
        {
            return;
        }

        var collection = ClientData.Children;
        var valuesRelDict = _fillingFieldsController.CreateValuesRelationDict(client);
        _fillingFieldsController.FillFields(ref collection, valuesRelDict);
    }
}