using System.Windows;

namespace MDK_Volkov
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTxb.Text == "admin" && PasswordPsb.Password == "admin")
                MessageBox.Show("Введены верные данные", "Пока", MessageBoxButton.OK, MessageBoxImage.Information);
            else
                MessageBox.Show("Введены неверные данные", "ОШИБКА!!!", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            new WinRegister().ShowDialog();
        }
    }
}