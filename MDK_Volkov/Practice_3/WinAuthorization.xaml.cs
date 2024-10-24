using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

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
                (NameTxb.Text != "" && PasswordPsb.Password != ""))
                MessageBox.Show("Введены верные данные", "Пока", MessageBoxButton.OK, MessageBoxImage.Information);
            else
                MessageBox.Show("Введены неверные данные", "ОШИБКА!!!", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        private void SignUoButton_Click(object sender, RoutedEventArgs e)
        {
            new WinRegister(_student).ShowDialog();
            MessageBox.Show($"{_student.Name}", "Создан аккаунт", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
