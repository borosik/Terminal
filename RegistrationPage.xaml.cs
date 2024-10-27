using System;
using System.Windows;
using System.Windows.Controls;

namespace CharityApp
{
    public partial class RegistrationPage : Page
    {
        // Событие для уведомления об успешном входе
        public event Action? LoginSuccessful;

        public RegistrationPage()
        {
            InitializeComponent();
        }

        // Обработчик для кнопки "Вход"
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string surname = SurnameInput.Text;
            string name = NameInput.Text;
            string patronymic = PatronymicInput.Text;

            if (string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(name) || string.IsNullOrEmpty(patronymic))
            {
                MessageBox.Show("Пожалуйста, заполните все поля: фамилию, имя и отчество.");
            }
            else
            {
                MessageBox.Show($"Добро пожаловать, {name} {surname}!");
                // Вызываем событие для перехода на страницу с выбором услуг
                LoginSuccessful?.Invoke();
            }
        }
    }
}


