using System.Windows;
using System.Windows.Controls;

namespace CharityApp
{
    public partial class ServicesPage : Page
    {
        public ServicesPage()
        {
            InitializeComponent();
        }

        // Обработчик для кнопки подтверждения выбора услуг
        private void ConfirmButton_Click(object sender, RoutedEventArgs e)
        {
            // Логика подтверждения выбора услуг
            MessageBox.Show("Выбранные услуги подтверждены!");
        }
    }
}

