using System.Windows;
using MDK_Volkov.Practice_4;

namespace MDK_Volkov.Practice_3
{
    public partial class WinAuthorization : Window
    {
        private Student _student = new Student("", "");
        public WinAuthorization()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            if (NameTxb.Text == _student.Name && PasswordPsb.Password == _student.Password &&
                NameTxb.Text != "" && PasswordPsb.Password != "")
            {
                new WinStartMain().Show();
            }
            else
                MessageBox.Show("Введены неверные данные", "ОШИБКА!!!", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void SignUoButton_Click(object sender, RoutedEventArgs e)
        {
            if(new WinRegister(_student).ShowDialog() == true)
                MessageBox.Show($"{_student.Name}", "Создан аккаунт", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
