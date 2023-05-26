using System.Windows;
using System.Windows.Navigation;
using ToolsRent.WPF.Pages.AddEditPages;

namespace ToolsRent.WPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RentersClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new AddEditRenterPage();
        }

        private void MainFrame_OnNavigated(object sender, NavigationEventArgs e)
        {
            MainFrame.NavigationUIVisibility = NavigationUIVisibility.Hidden;
        }

        private void ToolsClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new AddEditToolPage();
        }

        private void ConsumablesClick(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new AddEditConsumablePage();
        }
    }
}