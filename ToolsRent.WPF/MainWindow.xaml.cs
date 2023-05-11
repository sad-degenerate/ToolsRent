using System.Windows;
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
    }
}