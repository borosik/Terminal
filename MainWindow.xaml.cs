using System.Windows;

namespace CharityApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ShowRegistrationPage();
        }

        private void ShowRegistrationPage()
        {
            var registrationPage = new RegistrationPage();
            registrationPage.LoginSuccessful += ShowServicesPage;
            MainContentFrame.Navigate(registrationPage);
        }

        private void ShowServicesPage()
        {
            var servicesPage = new ServicesPage();
            MainContentFrame.Navigate(servicesPage);
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            ShowRegistrationPage();
        }
    }
}





