using System.Windows;

namespace MDK_Volkov
{
    /// <summary>
    /// Interaction logic for WinMain.xaml
    /// </summary>
    public partial class WinMain : Window
    {
        Student student;
        public WinMain()
        {
            InitializeComponent();
        }
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTxb.Text == student?.Name && PasswordPsb.Password == student?.Password)
                MessageBox.Show("Введены верные данные", "Пока", MessageBoxButton.OK, MessageBoxImage.Information);
            else
                MessageBox.Show("Введены неверные данные", "ОШИБКА!!!", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            student = new Student("", "");
            if(new WinRegister(student).ShowDialog().Value == true)
                MessageBox.Show($"Запись успешно создана (\"{student.Name}\")", "УРАА", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}